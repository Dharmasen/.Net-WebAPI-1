using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace WebAPI_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        // GET: api/<ValuesController> // api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/<ValuesController>/5 
        [HttpGet("{id}")]      //https://localhost:44319/api/values/6 
        public string Get(int id)
        {
            return "value: " + id.ToString();
        }
        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}