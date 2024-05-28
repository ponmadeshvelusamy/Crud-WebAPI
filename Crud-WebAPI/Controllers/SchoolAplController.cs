using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWebApiClassLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crud_WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SchoolAplController : ControllerBase
    {
        RegisterRepository objject = new RegisterRepository();
       // GET: api/<SchoolAplController>
       [HttpGet]
        public IEnumerable<SchoolEntity> Get()
        {
            return objject.Showall();
        }

        // GET api/<SchoolAplController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SchoolAplController>
        [HttpPost]
        public void Post([FromBody]SchoolEntity value)
        {
            objject.SchoolLogin(value);
        }

        // PUT api/<SchoolAplController>/5
        [HttpPut("{id}")]
        public void Put(int id , long ContactNo, string Email ,[FromBody]SchoolEntity value)
        {
            objject.EditorUpdate(id,ContactNo,Email);
        }

        // DELETE api/<SchoolAplController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            objject.DeleteDetails(id);
        }
    }
}
