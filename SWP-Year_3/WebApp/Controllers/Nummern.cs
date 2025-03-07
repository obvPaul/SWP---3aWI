using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Nummern : ControllerBase
    {
        [HttpPut("increment")]
        public ActionResult<int> Increment([FromBody] int number)
        {
            return Ok(number + 1);
        }
        [HttpPut("Summe")]
        public ActionResult<int> Increment1(Summe summe)
        {
            return Ok(summe.Ausgangszahl + summe.Summant);
        }
    }


}