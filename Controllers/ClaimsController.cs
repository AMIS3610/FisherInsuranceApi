using Microsoft.AspNetCore.Mvc;
//ClaimsController
[Route ("api/customer/claims")]
public class CustomerCareController : Controller
{
    [HttpPost]
    public IActionResult Post([FromBody]string value)
    {
        return Created("",value);
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
// DELETE api/customer/claims/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    return Delete(id);
}
}