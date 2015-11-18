using System;
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
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About()
        {
            
            string category = Request.QueryString["category"];
            var Overview = new ComponentOverview();

            var categories = getCategories();
            //var categories = new List<Category>();

            if (category != null)
            {
                var categoryID = 0;
                Int32.TryParse(category, out categoryID);
                Overview.SelectedCategory = categoryID;
            }
            var components = getComponentInfo(Overview.SelectedCategory);                

            Overview.Categories = categories;
            Overview.Components = components;

            return View(Overview);
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditComponent()
        {
            var Component = new Component();
            //somehow get what component is picked
            //var Component = new Component(10, 10, "Im a component");
            return View(Component);
        }

        public ActionResult Component()
        {
            var Component = new Component();
           // var Component = new Component(1, 1, "We are in componentView");
            return View(Component);
        }

        public List<ComponentInformation> getComponentInfo(int categoryID_)
        {
            var componentInfo = db.ComponentInformations.Where(c => c.Category == categoryID_).ToList();
            return componentInfo;
        }

        public List<Category> getCategories()
        {
            var categories = db.Categories.ToList();
            return categories;
        }

        public FullComponent getComponents(int InfoId)
        {
            FullComponent fullComponent = new FullComponent();
            fullComponent.ComponentInfo = db.ComponentInformations.Find(InfoId);
            fullComponent.Components = db.Components.Where(x => x.ComponentInfoId == InfoId).ToList();
            return fullComponent;
        }
    }
}