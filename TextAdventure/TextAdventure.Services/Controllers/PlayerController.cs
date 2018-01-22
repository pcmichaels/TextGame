using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextAdventure.Model;

namespace TextAdventure.Services.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        // GET api/player
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return null;
        }

        // GET api/player/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return null;
        }

        // POST api/player
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/player/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
