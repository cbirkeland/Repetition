# WebApi 1 - Oldshool

## L�gga till en planet (POST)

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

Skapa en fil **webapi1.html** med ett formul�r d�r anv�ndaren kan skriva in en planet och en storlek.

N�r anv�ndaren trycker p� en knapp svara med en text, t.ex:

    Ny planet Saturnus skapad med storleken 123

Tips: 

S�h�r kan du l�sa in v�rden fr�n formul�ret

    string formContent = "";
    using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
    {
        formContent = reader.ReadToEndAsync().Result;
    }

Skapa en klass **Planet** med tv� properties och anv�nd denna.

# S�k upp planeter (GET)

Skapa ett formul�r d�r anv�ndaren kan ange namn p� planet att s�ka p� samt storlek.

N�r anv�ndaren trycker p� en knapp skriv t.ex

    S�ker i databasen efter planeter med namn Pluto och storlek 4500

Tips:

    Request.QueryString inneh�ller info fr�n ett GET

# Tips

Skapa ett formul�r som anv�nder **post**:

    <h3>Post formul�r till AddPlanet</h3>

    <form method="post" action="/SomeRouteName/AddPlanet">
        Planet: <input name="Planet" value="Saturnus" />
        Storlek: <input name="Size" value="123" />
        <button>Ok</button>
    </form>

    <hr/>

P� samma s�tt n�r du g�r ett **get**-formul�r (byt bara ut "method")

