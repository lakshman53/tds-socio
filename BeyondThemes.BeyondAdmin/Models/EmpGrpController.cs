using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDS.Socio.Models
{
    public class EmpGrpController : Controller
    {
        // GET: EmpGrp
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmpGrp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpGrp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpGrp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                azure_sociodataEntities1 ctx = new azure_sociodataEntities1();

                EmpGroup oEmpGroup = new EmpGroup();

                oEmpGroup.EmpId = Convert.ToInt16(collection.Get("EmpList"));
                oEmpGroup.GroupId = Convert.ToInt16(collection.Get("groupName"));

                ctx.EmpGroups.Add(oEmpGroup);
                ctx.SaveChanges();


                return RedirectToAction("SendMessages", "Home");

            }
            catch
            {
                return View();
            }
        }

        // GET: EmpGrp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpGrp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpGrp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpGrp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
