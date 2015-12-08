using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HandIn2_FoodProcessor.Models;

namespace HandIn2_FoodProcessor.Controllers
{
    public class ConsumablesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Consumables
        public ActionResult Index()
        {
            return View(db.Consumables.ToList());
        }

        // GET: Consumables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consumables consumables = db.Consumables.Find(id);
            if (consumables == null)
            {
                return HttpNotFound();
            }
            return View(consumables);
        }

        // GET: Consumables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consumables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConsumableId,ConsumableName,ProteinPer100Gram")] Consumables consumables)
        {
            if (ModelState.IsValid)
            {
                db.Consumables.Add(consumables);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consumables);
        }

        // GET: Consumables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consumables consumables = db.Consumables.Find(id);
            if (consumables == null)
            {
                return HttpNotFound();
            }
            return View(consumables);
        }

        // POST: Consumables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConsumableId,ConsumableName,ProteinPer100Gram")] Consumables consumables)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consumables).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consumables);
        }

        // GET: Consumables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consumables consumables = db.Consumables.Find(id);
            if (consumables == null)
            {
                return HttpNotFound();
            }
            return View(consumables);
        }

        // POST: Consumables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Consumables consumables = db.Consumables.Find(id);
            db.Consumables.Remove(consumables);
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
