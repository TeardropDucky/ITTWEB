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
    public class ComponentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Components
        public ActionResult Index()
        {
            string category = Request.QueryString["ID"];
            int componentInfoID = 1;
            var components = db.Components.Include(c => c.ComponentInfo);
            if (category != null)
            {
                Int32.TryParse(category, out componentInfoID);
                components = db.Components.Where(x => x.ComponentInfoId == componentInfoID);
            }   

            return View(components.ToList());
        }

        // GET: Components/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Component component = db.Components.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // GET: Components/Create
        public ActionResult Create()
        {
            ViewBag.ComponentInfoId = new SelectList(db.ComponentInformations, "InfoId", "ComponentName");
            return View();
        }

        // POST: Components/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,ComponentNumber,SerialNr,AdminComment,UserComment,ComponentInfoId")] Component component)
        {
            if (ModelState.IsValid)
            {
                string category = Request.QueryString["ID"];
                int componentInfoID = 1;
                if (category != null)
                {
                    Int32.TryParse(category, out componentInfoID);
                }
                component.ComponentInfoId = componentInfoID;

                db.Components.Add(component);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ComponentInfoId = new SelectList(db.ComponentInformations, "InfoId", "ComponentName", component.ComponentInfoId);
            return View(component);
        }

        // GET: Components/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Component component = db.Components.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            ViewBag.ComponentInfoId = new SelectList(db.ComponentInformations, "InfoId", "ComponentName", component.ComponentInfoId);
            return View(component);
        }

        // POST: Components/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,ComponentNumber,SerialNr,AdminComment,UserComment,ComponentInfoId")] Component component)
        {
            if (ModelState.IsValid)
            {
                db.Entry(component).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComponentInfoId = new SelectList(db.ComponentInformations, "InfoId", "ComponentName", component.ComponentInfoId);
            return View(component);
        }

        // GET: Components/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Component component = db.Components.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // POST: Components/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Component component = db.Components.Find(id);
            db.Components.Remove(component);
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

        public ActionResult ComponentInformationOptions()
        {
            var ComponentInformation = db.ComponentInformations.ToList();
            return View(ComponentInformation);
        }
    }
}
