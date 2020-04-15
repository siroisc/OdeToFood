using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // Mvc looks for parameters in query string
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Name = name ?? "no name"; // option for no match null colloation
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}