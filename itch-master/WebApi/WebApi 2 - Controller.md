# WebApi 2 - Controller

## Hello world

N�r anv�ndaren trycker p� knappen �Hello world� s� skicka till en sidan med texten Hello World

**Extra:** Slumpa s� antingen "Hello world", "Bonjour le monde" eller "Hei maailma" dyker upp

## Veckodag

Knappen �Skriv veckodag� ska g� till en sidan som skriver �Idag �r det onsdag� (om det �r onsdag)

**Extra:** Skriv p� samma s�tt ut vilken veckodag det var f�r tio �r sedan 

## Dagens floskel

Knappen �Dagens floskel�  ska g� till en sidan som skriver ut en floskel beroende p� veckodag. T.ex �Uh-oh. Sounds like somebody�s got a case of the mondays�.

**Extra:** S�k upp en sajt som genererar floskler. Integrera mot den, s� om anv�ndaren trycker p� �Slump-floskel� s� via en floskel fr�n den sajten.

## Extra: Postman

Installera Postman och testa dina metoder d�rifr�n

## Extra: Bootstrap

Anv�nd Bootstrap f�r att g�ra designen snyggare

## Tips

    [Route("webapi1")]
    public class WebApi1Controller : Controller
    {

        [HttpGet("Hello")]
        public string Hello()
        {
            return "Hello";
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello World");
        }
    }