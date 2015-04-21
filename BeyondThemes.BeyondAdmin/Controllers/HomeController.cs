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

        public ActionResult Elements()
        {
            return View();
        }
        
        public ActionResult Tabs()
        {
            return View();
        }
        public ActionResult Modals()
        {
            return View();
        }
        public ActionResult Buttons()
        {
            return View();
        }
        public ActionResult FormLayouts()
        {
            return View();
        }
        public ActionResult FormInputs()
        {
            return View();
        }
        public ActionResult Widgets()
        {
            return View();
        }
        public ActionResult Databoxes()
        {
            return View();
        }
        public ActionResult Alerts()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FontAwesome()
        {
            return View();
        }
        public ActionResult GlyphIcons()
        {
            return View();
        }
        public ActionResult Typicons()
        {
            return View();
        }
        public ActionResult WeatherIcons()
        {
            return View();
        }
        public ActionResult NestableList()
        {
            return View();
        }
        public ActionResult TreeView()
        {
            return View();
        }
        public ActionResult SimpleTables()
        {
            return View();
        }
        public ActionResult DataTables()
        {
            return View();
        }
        public ActionResult DataPickers()
        {
            return View();
        }

        public ActionResult Wizards()
        {
            return View();
        }

        public ActionResult FormValidation()
        {
            return View();
        }
        public ActionResult FormEditors()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult FlotCharts()
        {
            return View();
        }
        public ActionResult MorrisCharts()
        {
            return View();
        }
        public ActionResult SparklineCharts()
        {
            return View();
        }
        public ActionResult EasyPieCharts()
        {
            return View();
        }
        public ActionResult ChartJS()
        {
            return View();
        }
        public ActionResult Inbox()
        {
            return View();
        }
        public ActionResult Compose()
        {
            return View();
        }
        public ActionResult ViewMessage()
        {
            return View();
        }
        public ActionResult Timeline()
        {
            return View();
        }
        public ActionResult PricingTables()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult Typography()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult Error500()
        {
            return View();
        }
        public ActionResult Grid()
        {
            return View();
        }
        public ActionResult Persian()
        {
            return View();
        }
        public ActionResult Arabic()
        {
            return View();
        }
    }
}
