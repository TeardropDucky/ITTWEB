using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hand_in1_grp7.Models;

namespace Hand_in1_grp7.Controllers
{
    public class ComponentInformationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ComponentInformations
        public ActionResult Index()
        {
            var componentInformations = db.ComponentInformations.Include(c => c.CategoryInfo);
            return View(componentInformations.ToList());
        }

        // GET: ComponentInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComponentInformation componentInformation = db.ComponentInformations.Find(id);
            if (componentInformation == null)
            {
                return HttpNotFound();
            }
            return View(componentInformation);
        }

        // GET: ComponentInformations/Create
        public ActionResult Create()
        {
            ViewBag.Category = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: ComponentInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InfoId,ComponentName,ComponentInfo,DataSheet,Image,ManufacturerLink,Category")] ComponentInformation componentInformation)
        {
            if (ModelState.IsValid)
            {
                db.ComponentInformations.Add(componentInformation);
                db.SaveChanges();
                return Redirect("~/Components/Create?ID=" + componentInformation.InfoId);
            }

            ViewBag.Category = new SelectList(db.Categories, "CategoryId", "CategoryName", componentInformation.Category);
            return View(componentInformation);
        }

        // GET: ComponentInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComponentInformation componentInformation = db.ComponentInformations.Find(id);
            if (componentInformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category = new SelectList(db.Categories, "CategoryId", "CategoryName", componentInformation.Category);
            return View(componentInformation);
        }

        // POST: ComponentInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InfoId,ComponentName,ComponentInfo,DataSheet,Image,ManufacturerLink,Category")] ComponentInformation componentInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(componentInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category = new SelectList(db.Categories, "CategoryId", "CategoryName", componentInformation.Category);
            return View(componentInformation);
        }

        // GET: ComponentInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComponentInformation componentInformation = db.ComponentInformations.Find(id);
            if (componentInformation == null)
            {
                return HttpNotFound();
            }
            return View(componentInformation);
        }

        // POST: ComponentInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComponentInformation componentInformation = db.ComponentInformations.Find(id);
            db.ComponentInformations.Remove(componentInformation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
