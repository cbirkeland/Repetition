# WebApi 1 - Oldshool

## Lägga till en planet (POST)

Skapa en Controller-klass med en metod **AddPlanet**

    [Route("WebApi1")]
    public class WebApi1Controller : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            ...
        }
    }

Skapa en fil **webapi1.html** med ett formulär där användaren kan skriva in en planet och en storlek.

När användaren trycker på en knapp svara med en text, t.ex:

    Ny planet Saturnus skapad med storleken 123

Tips: 

Såhär kan du läsa in värden från formuläret

    string formContent = "";
    using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
    {
        formContent = reader.ReadToEndAsync().Result;
    }

Skapa en klass **Planet** med två properties och använd denna.

# Sök upp planeter (GET)

Skapa ett formulär där användaren kan ange namn på planet att söka på samt storlek.

När användaren trycker på en knapp skriv t.ex

    Söker i databasen efter planeter med namn Pluto och storlek 4500

Tips:

    Request.QueryString innehåller info från ett GET

# Tips

Skapa ett formulär som använder **post**:

    <h3>Post formulär till AddPlanet</h3>

    <form method="post" action="/SomeRouteName/AddPlanet">
        Planet: <input name="Planet" value="Saturnus" />
        Storlek: <input name="Size" value="123" />
        <button>Ok</button>
    </form>

    <hr/>

På samma sätt när du gör ett **get**-formulär (byt bara ut "method")

