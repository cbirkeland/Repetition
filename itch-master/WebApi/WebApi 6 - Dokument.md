
# WebApi 6 - Dokument

Skapa ett formul�r d�r anv�ndaren kan l�gga in ett dokument. 

Det ska best� av olika formul�relement: textboxar, checkboxar, dropdowner, radiobuttons och se ut s�h�r:

![Dokument Formular](img/dokument-formular.png)

N�r anv�ndaren trycker OK s� skicka till en controller som returnerar all info:

![Dokument Response](img/dokument-response.png)

## Tips

Controllern �r enkel och ser ut s�h�r:

    [Route("webapi6")]
    public class WebApi6Controller : Controller
    {
        [HttpPost("AddDocument")]
        public IActionResult AddDocument(Document document)
        {
            return Ok(document);
        }
        
    }

Skapa klassen Document (och andra typer du beh�ver)