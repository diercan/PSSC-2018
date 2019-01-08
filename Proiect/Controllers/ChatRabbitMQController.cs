using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RabbitMQ.Client;
using RabbitMQ.Util;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ChatApplication.Controllers
{
    public class ChatRabbitMQController : Controller
    {

        public ActionResult Index()
        {
            Send obj = new Send();
            String message = "Hello RabbitMQ!";
            obj.send(message);
            return View();
        }

        
    }
}