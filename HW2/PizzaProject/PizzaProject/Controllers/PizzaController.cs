using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace PizzaProject
{
    using Microsoft.AspNetCore.Http.HttpResults;

    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        /// <summary>
        /// Get Pizza by ID
        /// </summary>
        /// <response code="200">Returns the requested item</response>
        /// <response code="404">If the item is missing</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string id)
        {
            var result = new PizzaService().GetPizza(id);

            if (result == null)
                return NotFound($"Pizza with ID:{id} not found.");
            
            return Ok(result);
        }

        /// <summary>
        /// Get the list of all Pizzas
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            var result = new PizzaService().GetAllPizza().ToArray();
            if (result == null || result.Count() == 0)
                return NotFound("No Pizza(s) created yet.");
            
            return Ok(result);
        }

        /// <summary>
        /// Delete Pizza by ID
        /// </summary>
        [HttpDelete ("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(string id)
        {
            var result = new PizzaService().DeletePizza(id);
            if (! result)
                return BadRequest($"Failed to remove Pizza with ID:{id}");

            return Ok($"Pizza with ID:{id} removed.");
        }

        /// <summary>
        /// Create new pizza using data entered by the user
        /// </summary>
        [HttpPost("CreatePizza")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(Pizza pizza)
        {
            var result = new PizzaService().CreatePizza(pizza);
            if (result == null)
                return BadRequest("Failed to create Pizza.");

            return CreatedAtAction(nameof(Get), new { result.Id }, result);
        }

        /// <summary>
        /// Create new pizza via random generator
        /// </summary>
        [HttpPost("AutoGeneratePizza")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create()
        {
            var result = new PizzaService().GeneratePizza();
            if (result == null)
                return BadRequest("Failed to create Pizza.");

            return CreatedAtAction(nameof(Get), new { result.Id }, result);

        }

        /// <summary>
        /// Update Pizza
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(Pizza pizza)
        {
            if (pizza == null)
                return BadRequest("Cannot continue. Check your data.");
            var result = new PizzaService().UpdatePizza(pizza);

            if (! result)
                return BadRequest($"Failed to update pizza with id: {pizza.Id}");

            //return Ok($"Updated pizza with id: {pizza.Id}");
            return CreatedAtAction(nameof(Get), new { pizza.Id }, $"Updated pizza with id: {pizza.Id}");
        }

    }
}
