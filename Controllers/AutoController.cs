[Route ("api/auto/quotes")]
public class AutoController : AutoController
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
// DELETE api/auto/quotes/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    return Delete(id);
}

//HomeController
[Route ("api/home/quotes")]
public class HomeController : HomeController
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
// DELETE api/home/quotes/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    return Delete(id);
}

//LifeController
[Route ("api/life/quotes")]
public class LifeController : LifeController
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

//ClaimsController
[Route ("api/customer/claims")]
public class CustomerCareController : CustomerCareController
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
// DELETE api/customer/claims/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    return Delete(id);
}