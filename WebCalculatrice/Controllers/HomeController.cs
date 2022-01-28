using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebCalculatrice.Logic.Controleurs;

namespace WebCalculatrice.Controllers
{
    public class HomeController : Controller
    {
       
        [Route("")]
        [Route("/Home")]
        [Route("/Home/Index")]
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        
        public IActionResult Index([FromForm] int nunerateur1 )
        {

           
            return View();
        }
    }
}
