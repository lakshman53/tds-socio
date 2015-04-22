using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TDS.Socio.Controllers
{
    public class RegionJSONController : ApiController
    {
        static azure_sociodataEntities1 ctx = new azure_sociodataEntities1();

        // GET: api/RegionJSON
        public dynamic Get()
        {
              //  return ctx.Regions.Include("Tags").Select(i => new { i.Region1, i.RegionId }).Take(5);

            var records = (from t in ctx.tmpInTimeAnalysis
                           select new
                           {
                              TimeRange = t.TimeRange,
                              PercentPeople = t.PercentPeople

                           });
                          
            return Json(records);

        }

        // GET: api/RegionJSON/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegionJSON
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/RegionJSON/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegionJSON/5
        public void Delete(int id)
        {
        }
    }
}
