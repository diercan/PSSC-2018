using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Users;
using PsscProject.Models.Users;

namespace PsscProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        private IUserService _userService;
        private ICustomerService customerService;
        private IMapper _mapper;
        public AuthController(IUserService userService, ICustomerService customerService, IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
            this.customerService = customerService;
        }

        [HttpPost, Route("login")]
        public IActionResult Login([FromBody]UserDTO userDto)
        {
            var user = _userService.Authenticate(userDto.Username, userDto.Password);

            if (user == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) 
            };
            var tokeOptions = new JwtSecurityToken(
                issuer: "http://0.0.0.0:5000",
                audience: "http://0.0.0.0:5000",
                claims: claims,
                expires: DateTime.Now.AddMinutes(300),
                signingCredentials: signinCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return Ok(new { Role = "Manager", Token = tokenString, message = "Successfull Login." });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserDTO userDto)
        {
            Console.WriteLine("hei");
            var user = _mapper.Map<User>(userDto);

            try
            {
                var _user = _userService.Create(user, userDto.Password);
                CustomerDTO customerDto = new CustomerDTO()
                {
                    Id = Guid.NewGuid(),
                    UserId = _user.Id,
                    FirstName = "-",
                    LastName = "-",
                    Email = "-@-",

                };
                customerService.Add(customerDto);
                return Ok(new { message = "Successful Register."});
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody]UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.Id = id;

            try
            {
                _userService.Update(user, userDto.Password);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
