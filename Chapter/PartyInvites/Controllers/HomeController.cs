using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.multy = DateTime.Now;
            return View();
        }
        //get
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            return View("thanks",guestResponse);
        }


    }
}