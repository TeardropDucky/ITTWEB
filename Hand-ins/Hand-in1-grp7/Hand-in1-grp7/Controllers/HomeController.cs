﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hand_in1_grp7.Models;

namespace Hand_in1_grp7.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            var Overview = new ComponentOverview();

            var categories = new List<Category>();
            var components = new List<Component>();
            for (int i = 0; i < 10; i++)
            {
                var potato = new Category();
                potato.Name = "hej" + i;
                //potato.Link = "#";
                categories.Add(potato);
                components.Add(new Component(i, i, "potato" + i));
            }

            Overview.Categories = categories;
            Overview.Components = components;

            return View(Overview);
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditComponent()
        {

            return View();
        }
    }
}