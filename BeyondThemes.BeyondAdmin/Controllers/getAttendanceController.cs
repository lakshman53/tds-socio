using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TDS.Socio.Controllers
{
    public class getAttendanceController : ApiController
    {

        static azure_sociodataEntities1 ctx = new azure_sociodataEntities1();

        // GET: api/getAttendance
       
           public dynamic Get()
        {
            var records = (from t in ctx.getAttendanceDetails()
                           select new
                           {
                               EmpName = t.EmpName,
                               StoreName = t.StoreName,
                               City = t.City,
                               Region = t.Region,
                               LogDate = t.LogDate,
                               InTime = t.InTime,
                               OutTime = t.OutTime,
                               Area = t.Area
                           });

            return Json(records);
               }

        // GET: api/getAttendance/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/getAttendance
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/getAttendance/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/getAttendance/5
        public void Delete(int id)
        {
        }
    }
}
