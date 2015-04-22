using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TDS.Socio.Controllers
{
    public class EmpGroupDetailsController : ApiController
    {
        static azure_sociodataEntities1 ctx = new azure_sociodataEntities1();
        
        
        // GET: api/EmpGroupDetails
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EmpGroupDetails/5
        public dynamic Get(int id)
        {
            var records = (from t in ctx.getEmployeeGroupDetails(id)
                           select new
                           {
                               EmpName = t.EmpName,
                               StoreName = t.StoreName,
                               City = t.City
                           });

            return Json(records);
            
        }

        // POST: api/EmpGroupDetails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EmpGroupDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmpGroupDetails/5
        public void Delete(int id)
        {
        }
    }
}
