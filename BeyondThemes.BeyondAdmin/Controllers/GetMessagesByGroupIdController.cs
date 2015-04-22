using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TDS.Socio.Controllers
{
    public class GetMessagesByGroupIdController : ApiController
    {
        static azure_sociodataEntities1 ctx = new azure_sociodataEntities1();
        // GET: api/GetMessagesByGroupId
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetMessagesByGroupId/5
        public dynamic Get(int id)
        {
            var records = (from t in ctx.getMessagesByGroupId(id)
                           select new
                           {
                               Subject = t.subject,
                               Message = t.message,
                               Sent = t.sent
                           });

            return Json(records);
            
        }

        // POST: api/GetMessagesByGroupId
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetMessagesByGroupId/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetMessagesByGroupId/5
        public void Delete(int id)
        {
        }
    }
}
