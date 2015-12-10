using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebAPI_WithMVC6.Repository;
using WebAPI_WithMVC6.Models;

namespace WebAPI_WithMVC6.Controllers
{
    [Route("api/Person")]
    public class PersonController : Controller
    {
        [FromServices]
        public IPersonRepository<PersonInfo, int> _repository { get; set; }

        [HttpGet]
        public IEnumerable<PersonInfo> Get()
        {
            return _repository.Get();
        }

        [HttpGet("{id}")]
        public PersonInfo Get(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        public IEnumerable<PersonInfo> Post([FromBody]PersonInfo p)
        {
            return _repository.Add(p);
        }

        [HttpPut("{id}")]
        public IEnumerable<PersonInfo> Put(int id, [FromBody]PersonInfo p)
        {
            return _repository.Update(id, p);
        }

        [HttpDelete("{id}")]
        public IEnumerable<PersonInfo> Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
