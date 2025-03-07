using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/nummern")] // Feste API-Route setzen
    public class NummernController : ControllerBase
    {
        [HttpPut("Summe")] // Korrekt auf POST ändern
        public ActionResult<int> AddNumbers([FromBody] Summe summe)
        {
            if (summe == null)
                return BadRequest("Ungültige Eingabe.");

            return Ok(new { summe = summe.Ausgangszahl + summe.Summant });
        }
    }
}
