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
        Random rnd = new Random();
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            
            var userID = User.Identity.GetUserName();
            db.Configuration.LazyLoadingEnabled = true;
            if (db.UserInfoes.Where(c => c.Name == userID).ToList().Count == 0)
            {
                var user = new UserInfo();
                user.Name = userID;
                user.UserId = userID;
                db.UserInfoes.Add(user);
                db.SaveChanges();

                for (int i = 0; i < 10; i++)
                {
                    var derp = new Posts();
                    derp.User = user;
                    derp.PostDate = DateTime.Now;
                    derp.Consumable = db.Consumables.Find(1);
                    derp.GramProtein = rnd.Next(1, 99);
                    db.Posts.Add(derp);
                    db.SaveChanges();
                }
            }
            
            
            List<Posts> potato = db.Posts.Where(c => c.User.Name == userID).ToList();
            
            foreach (var i in potato)
            {
                i.Consumable = db.Consumables.Find(rnd.Next(1,9));
            }
           
            
            return View(potato);
        }

        public void AddUserConsumable(int userId, string consumableName, double proteinPer100)
        {

        }
    }
}