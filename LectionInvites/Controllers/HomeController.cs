using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LectionInvites.Models;

namespace LectionInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Добрый день" : "Добрый вечер";
            return View();
        }
        [HttpGet]
        public ViewResult InvationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InvationForm(Student student)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", student);
            }
            else
            {
                // there is a validation error
                return View();
            }
          
        }
    }
}
