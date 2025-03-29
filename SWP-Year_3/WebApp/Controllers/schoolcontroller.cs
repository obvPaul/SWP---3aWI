using Microsoft.AspNetCore.Mvc;
using Test_02_Schule;

namespace MyFirstWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Schoolcontroller : ControllerBase
    {
        private static Schule schule = new Schule();
        [HttpGet("AlleSchueler")]
        public ActionResult<int> AllStudents()
        {
            return Ok(schule.SchuelerListe);
        }

        [HttpPost("AddSchueler")]
        public ActionResult<string> AddSchueler([FromBody] Schueler neuerSchueler)
        {
            schule.SchuelerHinzufuegen(neuerSchueler);
            return Ok(neuerSchueler);
        }

        [HttpGet("Durchschnittsalter")]
        public ActionResult<int> Durchschnittsalter()
        {
            return Ok(schule.Durchschnittsalter());
        }

        [HttpGet("Geschlecht")]
        public ActionResult<Dictionary<string, int>> Geschlechter()
        {
            var ergebnis = new Dictionary<string, int>
            {
                { "m", schule.AnzahlSchuelerNachGeschlecht("Männlich") },
                { "w", schule.AnzahlSchuelerNachGeschlecht("Weiblich") }
            };
            return Ok(ergebnis);
        }

    }
}