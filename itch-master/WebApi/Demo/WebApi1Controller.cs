using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace WebApiLab.Controllers
{
    [Route("webapi1")]
    public class WebApi1Controller : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            // Planet=Saturnus&Size=123
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            Planet planet = ParsePlanet(formContent);

            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size}");
        }


        [Route("SearchPlanet")]
        public IActionResult SearchPlanet()
        {
            var formcontent = Request.QueryString.Value.TrimStart('?');

            var planet = ParsePlanet(formcontent);

            return Ok($"Söker i databasen efter planeter med namn {planet.Name} och storlek {planet.Size}");
        }

        private static Planet ParsePlanet(string formcontent)
        {
            var list = formcontent.Split('&');

            var planet = new Planet();

            foreach (var row in list)
            {
                // Planet=Pluto
                var key = row.Split("=")[0];
                var value = row.Split("=")[1];

                if (key == "Name")
                    planet.Name = value;

                if (key == "Size")
                    planet.Size = int.Parse(value);
            }

            return planet;
        }

        // ---------------------------------------------------------------- Modellbinding

        [HttpPost("AddPlanet2")]
        public IActionResult AddPlanet2(Planet planet)
        {
            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size}");
        }

        [HttpGet("SearchPlanet2")]
        public IActionResult SearchPlanet2(Planet planet)
        {
            return Ok($"Söker i databasen efter planeter med namn {planet.Name} och storlek {planet.Size}");
        }

        // ---------------------------------------------------------------- Bind med JSON

        // Binder rå json. Men inte ett vanligt formulär. Krävs att "Content-Type" är "application/json"

        [HttpPost("AddPlanetJson")]
        public IActionResult AddPlanetJson([FromBody] Planet planet) 
        {
            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size} (AddPlanetJson)");
        }


        public class Planet
        {
            public string Name { get; set; }
            public int Size { get; set; }
        }

    }
}
