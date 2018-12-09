using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KinderGal.Models;

namespace KinderGal.Controllers
{
    public class AnnouncementController : Controller
    {
        private KinderGartenEntities db = new KinderGartenEntities();

        // GET: Announcement
        public ActionResult Announcements()
        {
            return View(db.Announces.ToList());
        }

        // GET: Announcement/Create
        public ActionResult Upload()
        {
            return View();
        }

        // POST: Announcement/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload([Bind(Include = "AnnouncementID,Announcement,Date_Time")] Announce announce)
        {
            if (ModelState.IsValid)
            {
                db.Announces.Add(announce);
                db.SaveChanges();
                return RedirectToAction("Announcements");
            }

            return View(announce);
        }

        // GET: Announcement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Announce announce = db.Announces.Find(id);
            if (announce == null)
            {
                return HttpNotFound();
            }
            return View(announce);
        }

        // POST: Announcement/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnnouncementID,Announcement,Date_Time")] Announce announce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(announce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Announcements");
            }
            return View(announce);
        }

        // GET: Announcement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Announce announce = db.Announces.Find(id);
            if (announce == null)
            {
                return HttpNotFound();
            }
            return View(announce);
        }

        // POST: Announcement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Announce announce = db.Announces.Find(id);
            db.Announces.Remove(announce);
            db.SaveChanges();
            return RedirectToAction("Announcements");
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
