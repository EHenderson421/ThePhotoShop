using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThePhotoShop5.Controllers
{
    public class InstagramController : Controller
    {
        // GET: Instagram
        public ActionResult Instagram(object sender, EventArgs e)
        {
            var client_id = ConfigurationManager.AppSettings["instagram.clientid"].ToString();
            var redirect_uri = ConfigurationManager.AppSettings["instagram.redirecturi"].ToString();
            Response.Redirect("https://api.instagram.com/oauth/authorize/?" + "client_id=" + client_id + "&redirect_uri=" + redirect_uri + "&response_type=code");
            
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}