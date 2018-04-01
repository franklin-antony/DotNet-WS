using Microsoft.AspNetCore.Mvc;
using NetCore01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore01.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            

            var model = new Restaurant { Id = 1, Name = "My Pizza!!" };

            //return new ObjectResult(model);

            return  View(model);


        }
    }
}
