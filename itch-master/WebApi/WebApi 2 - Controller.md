# WebApi 2 - Controller

## Hello world

När användaren trycker på knappen “Hello world” så skicka till en sidan med texten Hello World

**Extra:** Slumpa så antingen "Hello world", "Bonjour le monde" eller "Hei maailma" dyker upp

## Veckodag

Knappen “Skriv veckodag” ska gå till en sidan som skriver “Idag är det onsdag” (om det är onsdag)

**Extra:** Skriv på samma sätt ut vilken veckodag det var för tio år sedan 

## Dagens floskel

Knappen “Dagens floskel”  ska gå till en sidan som skriver ut en floskel beroende på veckodag. T.ex “Uh-oh. Sounds like somebody’s got a case of the mondays”.

**Extra:** Sök upp en sajt som genererar floskler. Integrera mot den, så om användaren trycker på “Slump-floskel” så via en floskel från den sajten.

## Extra: Postman

Installera Postman och testa dina metoder därifrån

## Extra: Bootstrap

Använd Bootstrap för att göra designen snyggare

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