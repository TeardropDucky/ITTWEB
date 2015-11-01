using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01.Models;

namespace Lab01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<ServerVariable> list = new List<ServerVariable>();
            var keys = Request.ServerVariables.Keys;
            var count = keys.Count;
            for (int i = 0; i < count; i++)
            {
                var s = new ServerVariable();
                s.key = keys[i];
                s.value = Request.ServerVariables.Get(keys[i]);
                list.Add(s);
            }
            return View(list);
        }
    }
}