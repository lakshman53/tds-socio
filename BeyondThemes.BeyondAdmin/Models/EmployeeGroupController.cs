using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDS.Socio.Models
{
    public class EmployeeGroupController : Controller
    {
        // GET: EmployeeGroup
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployeeGroup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeGroup/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
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

        // GET: EmployeeGroup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeGroup/Edit/5
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

        // GET: EmployeeGroup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeGroup/Delete/5
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
