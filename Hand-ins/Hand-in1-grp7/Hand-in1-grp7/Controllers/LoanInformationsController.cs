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
    public class LoanInformationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LoanInformations
        public ActionResult Index()
        {
            var loanInformation = db.LoanInformation.Include(l => l.ComponentData).Include(l => l.UserInfo);
            return View(loanInformation.ToList());
        }

        // GET: LoanInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanInformation loanInformation = db.LoanInformation.Find(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            return View(loanInformation);
        }

        // GET: LoanInformations/Create
        public ActionResult Create()
        {
            ViewBag.ComponentNr = new SelectList(db.Components, "ID", "SerieNr");
            ViewBag.StudentId = new SelectList(db.UserInformation, "StudentId", "FullName");
            return View();
        }

        // POST: LoanInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoanId,ComponentNr,LoanDate,ReturnDate,IsEmailSent,ReservationDate,OwnerId,ReservationId,StudentId")] LoanInformation loanInformation)
        {
            if (ModelState.IsValid)
            {
                db.LoanInformation.Add(loanInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ComponentNr = new SelectList(db.Components, "ID", "SerieNr", loanInformation.ComponentNr);
            ViewBag.StudentId = new SelectList(db.UserInformation, "StudentId", "FullName", loanInformation.StudentId);
            return View(loanInformation);
        }

        // GET: LoanInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanInformation loanInformation = db.LoanInformation.Find(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.ComponentNr = new SelectList(db.Components, "ID", "SerieNr", loanInformation.ComponentNr);
            ViewBag.StudentId = new SelectList(db.UserInformation, "StudentId", "FullName", loanInformation.StudentId);
            return View(loanInformation);
        }

        // POST: LoanInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoanId,ComponentNr,LoanDate,ReturnDate,IsEmailSent,ReservationDate,OwnerId,ReservationId,StudentId")] LoanInformation loanInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComponentNr = new SelectList(db.Components, "ID", "SerieNr", loanInformation.ComponentNr);
            ViewBag.StudentId = new SelectList(db.UserInformation, "StudentId", "FullName", loanInformation.StudentId);
            return View(loanInformation);
        }

        // GET: LoanInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanInformation loanInformation = db.LoanInformation.Find(id);
            if (loanInformation == null)
            {
                return HttpNotFound();
            }
            return View(loanInformation);
        }

        // POST: LoanInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanInformation loanInformation = db.LoanInformation.Find(id);
            db.LoanInformation.Remove(loanInformation);
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
