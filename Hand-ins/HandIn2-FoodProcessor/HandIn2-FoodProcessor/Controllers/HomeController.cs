using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using HandIn2_FoodProcessor.Models;



namespace HandIn2_FoodProcessor.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var userID = User.Identity.GetUserName();
            List<Posts> potato = db.Posts.Where(c => c.User.Name == userID).ToList();

            return View(potato);
        }
    }
}