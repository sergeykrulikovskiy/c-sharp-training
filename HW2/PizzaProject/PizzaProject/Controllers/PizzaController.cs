using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace PizzaProject.Controllers
{
    using Models;
    using Services;
    using Interfaces;
    using Microsoft.AspNetCore.Http.HttpResults;

    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        // --> GET by ID
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var result = new PizzaService().GetPizza(id);
            if (result == null)
                return NotFound($"Pizza with ID:{id} not found.");
            
            return Ok(result);
        }
        // --> GET ALL
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = new PizzaService().GetAllPizza().ToArray();
            if (result == null || result.Count() == 0)
                return NotFound("No Pizza(s) created yet.");
            
            return Ok(result);
        }

        // --> DELETE by ID
        [HttpDelete ("{id}")]
        public IActionResult Delete(string id)
        {
            var result = new PizzaService().DeletePizza(id);
            if (! result)
                return BadRequest($"Failed to remove Pizza with ID:{id}");

            return Ok($"Pizza with ID:{id} removed.");
        }

        // --> CREATE
        [HttpPost("CreatePizza")]
        public IActionResult Create(Pizza pizza)
        {
            var result = new PizzaService().CreatePizza(pizza);
            if (result == null)
                return BadRequest("Failed to create Pizza.");

            return Ok(result);

        }
        // --> CREATE with random values
        [HttpPost("AutoGeneratePizza")]
        public IActionResult Create()
        {
            var result = new PizzaService().GeneratePizza();
            if (result == null)
                return BadRequest("Failed to create Pizza.");

            return Ok(result);
        }

        // --> PUT
        [HttpPut]
        public IActionResult Put(Pizza pizza)
        {
            if (pizza == null)
                return BadRequest("Cannot continue. Check your data.");
            var result = new PizzaService().UpdatePizza(pizza);

            if (! result)
                return BadRequest($"Failed to update pizza with id: {pizza.Id}");

            return Ok($"Updated pizza with id: {pizza.Id}");
        }

    }
}
