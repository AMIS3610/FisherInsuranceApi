using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
namespace FisherInsuranceApi.Controllers{
[Route ("api/customer/claims")]
public class ClaimsController : Controller
{
     private IMemoryStore db;
    public ClaimsController (IMemoryStore repo)
    {
        db = repo;
    }
    [HttpPost]
   public IActionResult Post([FromBody] Claim claim)
    {
        return Ok(db.CreateClaim(claim));
    }

  [HttpGet]
    public IActionResult GetClaims()
    {
        return Ok(db.RetrieveAllClaims);
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)

    {
        return Ok(db.RetrieveClaim(id));
    }
[HttpPut("{id}")]
public IActionResult Put([FromBody]Claim claim)
{
    return Ok(db.UpdateClaim(claim));
}
// DELETE api/customer/claims/id

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    db.DeleteQuote(id);
    return Ok();
}
}
}