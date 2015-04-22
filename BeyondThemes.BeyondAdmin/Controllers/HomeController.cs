using System;
using System.Web.Mvc;
using System.Collections.Generic;
using TDS.Socio.Models;
using System.Linq;


namespace TDS.Socio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult AddEmployee()
        {
            List<string> items = new List<string>();

            azure_sociodataEntities1 objentity = new azure_sociodataEntities1();
            List<Region> objcountrylist = (from data in objentity.Regions select data).ToList();

            ViewData["regions"] = new SelectList(objcountrylist, "RegionId", "Region1"); 
            
            return View();
        }
        public ActionResult AddStore()
        {
            return View();
        }

        public ActionResult EmployeeProfile()
        {
            return View();
        }
        public ActionResult Blank()
        {
            List<string> items = new List<string>();

            azure_sociodataEntities1 objentity = new azure_sociodataEntities1();
            List<Region> objcountrylist = (from data in objentity.Regions select data).ToList();
            
            ViewData["regions"] = new SelectList(objcountrylist, "RegionId", "Region1"); 
                        
            return View();
        }

        public ActionResult sendMessages()
        {
            List<string> items = new List<string>();

            azure_sociodataEntities1 objentity = new azure_sociodataEntities1();
            List<Group> objObjectsList = (from data in objentity.Groups.OrderByDescending(x => x.GroupId) select data).ToList();

            ViewData["groups"] = new SelectList(objObjectsList, "GroupId", "GroupName");

           
            return View();
        }

        public JsonResult GetStates(string country)
        {
            List<string> states = new List<string>();
            switch (country)
            {
                case "2":
                    states.Add("California");
                    states.Add("Florida");
                    states.Add("Ohio");
                    break;
                case "3":
                    states.Add("Chennai 1");
                    states.Add("Chennai 2");
                    states.Add("Chennai 3");
                    break;
                case "4":
                    states.Add("Delhi 1");
                    states.Add("Delhi 2");
                    states.Add("Delhi 3");
                    break;
            }
            return Json(states);
        }
        
    }
}
