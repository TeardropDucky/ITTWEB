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

            List<UserInfo> item = db.UserInfoes.Where(c => c.Name == userID).ToList();
            
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
            }

            //db.Configuration.LazyLoadingEnabled = true;
            
            //if( )
            List<Posts> potato = db.Posts.Where(c => c.User.Name == userID && c.Consumable != null).ToList();
            foreach (var post in potato)
            {
                //var consumable = db.Consumables.Where( c => c.)
                //item.Consumable.ConsumableId = db.
            }
           
            
            return View(potato);
        }

        public void AddUserConsumable(string userId, string consumableName, double proteinPer100)
        {

        }
    }
}