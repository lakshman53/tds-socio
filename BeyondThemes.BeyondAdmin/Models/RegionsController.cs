using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TDS.Socio;

namespace TDS.Socio.Models
{
    public class RegionsController : Controller
    {
        private azure_sociodataEntities1 db = new azure_sociodataEntities1();

        // GET: Regions
        public ActionResult Index()
        {
            var regions = db.Regions.Include(r => r.Employee);
            return View(regions.ToList());
        }

        // GET: Regions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        // GET: Regions/Create
        public ActionResult Create()
        {
            ViewBag.PersResponsible = new SelectList(db.Employees, "EmpId", "EmpNum");
            return View();
        }

        // POST: Regions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegionId,Region1,PersResponsible,RegionCode")] Region region)
        {
            if (ModelState.IsValid)
            {
                db.Regions.Add(region);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersResponsible = new SelectList(db.Employees, "EmpId", "EmpNum", region.PersResponsible);
            return View(region);
        }

        // GET: Regions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersResponsible = new SelectList(db.Employees, "EmpId", "EmpNum", region.PersResponsible);
            return View(region);
        }

        // POST: Regions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegionId,Region1,PersResponsible,RegionCode")] Region region)
        {
            if (ModelState.IsValid)
            {
                db.Entry(region).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersResponsible = new SelectList(db.Employees, "EmpId", "EmpNum", region.PersResponsible);
            return View(region);
        }

        // GET: Regions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        // POST: Regions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Region region = db.Regions.Find(id);
            db.Regions.Remove(region);
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
