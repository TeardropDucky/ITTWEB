using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net;
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
            if (db.UserInfoes.Where(c => c.Name == userID).ToList().Count == 0)
            {
                var user = new UserInfo();
                user.Name = userID;
                user.UserId = userID;
                db.UserInfoes.Add(user);
                db.SaveChanges();

                var derp = new Posts();
                derp.User = user;
                derp.PostDate = DateTime.Now;
                derp.Consumable = db.Consumables.Find(1);
                derp.GramProtein = 100;
                db.Posts.Add(derp);
                db.SaveChanges();

                derp.User = user;
                derp.PostDate = DateTime.Now;
                derp.Consumable = db.Consumables.Find(3);
                derp.GramProtein = 200;
                db.Posts.Add(derp);
                db.SaveChanges();
            }


            
            List<Posts> potato = db.Posts.Where(c => c.User.Name == userID).ToList();
            foreach(var item in potato)
            {
                item.Consumable = db.Consumables.Find(1);
            }
            
            
            return View(potato);
        }

        public void AddUserConsumable(int userId, string consumableName, double proteinPer100)
        {

        }
    }
}