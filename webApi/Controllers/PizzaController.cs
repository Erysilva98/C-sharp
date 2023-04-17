using webApi.Models;
using webApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>>GetAll() =>
        PizzaService.GetAll(); 

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();

        return pizza;
    }

    // POST action

    // PUT action

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();
            
        var existingPizza = PizzaService.Get(id);
        if(existingPizza is null)
            return NotFound();
    
        PizzaService.Update(pizza);           
    
        return NoContent();
    }

    // DELETE action

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);
    
        if (pizza is null)
            return NotFound();
        
        PizzaService.Delete(id);
    
        return NoContent();
    }

}
