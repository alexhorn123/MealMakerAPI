using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MealMakerAPI.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        // GET api/recipes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Kale Salad", "Corn Salad", "Asian Salmon", "Tofu Stir Fry" };
        }

        // GET api/recipes/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/recipes
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/recipes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/recipes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
