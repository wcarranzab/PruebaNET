using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace CasosParte02.Controllers
{
    [Produces("application/json")]
    [Route("api/Sucursal")]
    public class SucursalController : Controller
    {
        // GET: api/Sucursal
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Models.SucursalData b = new Models.SucursalData();

            return new string[] { "value1", "value2" };
        }

        // GET: api/Sucursal/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Sucursal
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Sucursal/5
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
