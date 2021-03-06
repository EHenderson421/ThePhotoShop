﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using ThePhotoShop5.Models;

namespace ThePhotoShop5.Controllers
{
    public class EmailsController : Controller
    {
        // GET: Emails
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Email model)
        {
            MailMessage mm = new MailMessage(model.From, "TheBetterScheduler@gmail.com");
            // mm.From = model.From;
            mm.Subject = model.Subject;
            mm.Body = "Message sent by - " + model.From + ",  Message - " + model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("TheBetterScheduler@gmail.com", "Password123$");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Mail Has Been Sent!";
            return View();
        }
    }

}