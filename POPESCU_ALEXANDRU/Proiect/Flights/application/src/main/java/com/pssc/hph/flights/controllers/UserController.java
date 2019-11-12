package com.pssc.hph.flights.controllers;

import com.pssc.hph.flights.configs.WebSecurityConfiguration;
import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.entities.User;
import com.pssc.hph.flights.services.UserService;
import lombok.RequiredArgsConstructor;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.web.bind.annotation.*;

import javax.annotation.PostConstruct;
import java.security.Principal;
import java.util.List;

@RestController
@RequestMapping("/users")
@RequiredArgsConstructor
public class UserController {
    private final UserService userService;

    @GetMapping("/profile")
    public User getProfile(Principal principal) {
        return userService.getUser(principal.getName());
    }

    @GetMapping("/profile/bookings")
    public List<Booking> getProfileBookings(Principal principal) {
        return userService.getUser(principal.getName()).getBookings();
    }

    @PostMapping
    public User createUser(@RequestBody User user) {
        return userService.createUser(user);
    }
}
