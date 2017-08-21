using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace CasosParte02.Controllers
{
    [Produces("application/json")]
    [Route("api/OrdenPagoData")]
    public class OrdenPagoController : Controller
    {
        Models.OrdenPagoData b = new Models.OrdenPagoData();

        // GET: api/OrdenPagoData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OrdenPagoData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/OrdenPagoData
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/OrdenPagoData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
