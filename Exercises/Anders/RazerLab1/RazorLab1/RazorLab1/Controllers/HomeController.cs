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
        List<Model> information = new List<Model>();
        // GET: Home
        public ActionResult Index()
        {
            var keys = Request.ServerVariables.Keys;
            for(int i = 0; i < keys.Count; i++)
            {
                var Object = new Model();
                Object.Name = keys[i];
                Object.Value = Request.ServerVariables.Get(keys[i]);
                information.Add(Object);
            }
            return View(information);
        }
    }
}