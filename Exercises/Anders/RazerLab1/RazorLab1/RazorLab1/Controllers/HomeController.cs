using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RazorLab1.Models;

namespace RazorLab1.Controllers
{
    public class HomeController : Controller
    {
        Model myModel = new Model
        {
            ModelID = 1,
            Name = "Potato",
            Description = "Are great",
            Category = "Food",
            Price = 123
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(myModel);
        }
    }
}