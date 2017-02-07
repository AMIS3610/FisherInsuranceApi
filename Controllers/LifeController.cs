using Microsoft.AspNetCore.Mvc;
//LifeController
[Route ("api/life/quotes")]
public class LifeController : Controller
{
    [HttpPost]
    public IActionResult Post([FromBody]string value)
    {
        return Created("",value);
    }
}
[HttpGet("{id}")]
public IActionResult Get(int id)

{
    return Ok("The id is: " + id);
}
[HttpPut("{id}")]
public IActionResult Put(int id, [FromBody]string value)
{
    return NoContent();
}
// DELETE api/life/quotes/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    return Delete(id);
}