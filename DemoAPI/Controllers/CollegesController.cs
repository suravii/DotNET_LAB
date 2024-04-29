using DemoAPI.Models;
using DemoAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegesController : ControllerBase
    {
        IRepository<College> _colzRepo = null;
        public CollegesController(IRepository<College> colzRepo) 
        {
            _colzRepo = colzRepo;            
        }
        // GET: api/<CollegesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CollegesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollegesController>
        [HttpPost]
        public void InsertRecord(College colz)
        {
            _colzRepo.AddRecord(colz);
        }

        // PUT api/<CollegesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollegesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
