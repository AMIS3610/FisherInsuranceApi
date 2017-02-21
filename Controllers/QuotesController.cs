using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
namespace FisherInsuranceApi.Controllers{

[Route ("api/quotes")]
public class QuotesController : Controller
{
    private IMemoryStore db;
    public QuotesController(IMemoryStore repo)
    {
        db = repo;
    }
    [HttpPost]
    public IActionResult Post([FromBody]Quote quote)
    {
        return Ok(db.CreateQuote(quote));
    }
    [HttpGet]
    public IActionResult GetQuotes()
    {
        return Ok(db.RetrieveAllQuotes);
    }
[HttpGet("{id}")]
public IActionResult Get(int id)

{
    return Ok(db.RetrieveQuote(id));
}
[HttpPut("{id}")]
public IActionResult Put([FromBody]Quote quote)
{
    return Ok(db.UpdateQuote(quote));
}
// DELETE api/auto/quotes/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    db.DeleteQuote(id);
    return Ok();
}

}

}