using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Restaurant_MVC_Project.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public IActionResult Contact()
        {
            return View();
        }
    }
}