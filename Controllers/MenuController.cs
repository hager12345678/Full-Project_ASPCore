using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Restaurant_MVC_Project.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public IActionResult Menu()
        {
            return View();
        }
    }
}