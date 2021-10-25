using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MetroLink;

namespace MetroLink.Controllers
{
    public class TimeStatusController : Controller
    {
        private NewDBF1 db = new NewDBF1();

        // GET: TimeStatus
        public ActionResult Index()
        {
            return View(db.TimeStatus.ToList());
        }

        // GET: TimeStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeStatus timeStatus = db.TimeStatus.Find(id);
            if (timeStatus == null)
            {
                return HttpNotFound();
            }
            return View(timeStatus);
        }

        // GET: TimeStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatusID,Status")] TimeStatus timeStatus)
        {
            if (ModelState.IsValid)
            {
                db.TimeStatus.Add(timeStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timeStatus);
        }

        // GET: TimeStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeStatus timeStatus = db.TimeStatus.Find(id);
            if (timeStatus == null)
            {
                return HttpNotFound();
            }
            return View(timeStatus);
        }

        // POST: TimeStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusID,Status")] TimeStatus timeStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeStatus);
        }

        // GET: TimeStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeStatus timeStatus = db.TimeStatus.Find(id);
            if (timeStatus == null)
            {
                return HttpNotFound();
            }
            return View(timeStatus);
        }

        // POST: TimeStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeStatus timeStatus = db.TimeStatus.Find(id);
            db.TimeStatus.Remove(timeStatus);
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
