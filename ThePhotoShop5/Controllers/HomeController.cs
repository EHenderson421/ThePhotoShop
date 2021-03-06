﻿using Stripe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThePhotoShop5.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.BackgroundImage = "~/Content/Images/shp2.jpg";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Home()
        {
            bool role = User.IsInRole("Owner");
            if (role)
            {
                return RedirectToAction("Home", "Owners");
            }
            role = User.IsInRole("Client");
            if (role)
            {
                return RedirectToAction("Home", "Clients");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}