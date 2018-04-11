using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app12.Models;

namespace app12.Controllers
{
    [Route("api/[controller]")]
    public class CatController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Cat> GetAll()
        {
			var list = new List<Cat>();
			list.Add(new Cat() {Name = "Mark"});
			list.Add(new Cat() {Name = "Larss"});
            return list;
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public Cat Get(string name)
        {
            return new Cat(){ Name = name };
        }

        // POST api/values
        [HttpPost]
        public Cat Insert([FromBody]Cat cat)
        {
			return cat;
        }

        // PUT api/values/5
        [HttpPut("{name}")]
        public Cat Update(string name, [FromBody]Cat)
        {
			cat.Name = name;
			return cat;
        }

        // DELETE api/values/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
			//deletes cat from DB
        }
    }
}
