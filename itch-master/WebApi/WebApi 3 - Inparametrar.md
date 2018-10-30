# WebApi 3 - Inparametrar


## Frukost

Om användaren matar in “ägg” (med stora eller små bokstäver), ska du komma till en sida “Å nej, du borde inte äta ägg till frukost!”. Annars skriv Ja, mango är gott! (om användaren skrev mango)

	Min frukostmat
	[                               ]
    [OK]

Extra: Använd en dropdown istället för textruta

## Sätta bakgrundfärg (front-end)

Visa en sida med samma bakgrundsfärg som användaren matar in

	Bakgrundsfärg
	[                               ]
    [OK]

Extra: Använd en color-picker istället för textruta


## Kvadrera

Kvadrera det tal som användaren matar in

	Nummer
	[                               ]
    [OK]

Extra: validera indata. 

## Lista med siffror

Visa en sida med texten 3,4,5,6,7 (om användaren matar in 3 och 7)

	Från 
	[                               ]
	Till
	[                               ]
    [OK]

Extra: använd en slider istället för textrutorna

## Postman

Testa dina metoder från Postman

## Tips

För att returnera text skriv som vanligt:

    return Ok("Collectors promenadstråk");

För att returnera **html** skriv:

    return Content("Collectors <b>promenadstråk</b>", "text/html");
