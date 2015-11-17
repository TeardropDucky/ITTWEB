﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hand_in1_grp7.Models;

namespace Hand_in1_grp7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //Lav klasse der indeholder en liste af Components og Categories
            var Overview = new ComponentOverview();

            var categories = new List<Category>();
            var components = new List<Component>();
            for (int i = 0; i < 10; i++)
            {
                var potato = new Category();
                potato.Name = "hej " + i;
                potato.Link = "#";
                categories.Add(potato);
                components.Add(new Component(i, i, "potato " + i));
            }

            Overview.Categories = categories;
            Overview.Components = components;

            return View(Overview);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}