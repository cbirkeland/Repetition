# WebApi 3 - Inparametrar


## Frukost

Om anv�ndaren matar in ��gg� (med stora eller sm� bokst�ver), ska du komma till en sida �� nej, du borde inte �ta �gg till frukost!�. Annars skriv Ja, mango �r gott! (om anv�ndaren skrev mango)

	Min frukostmat
	[                               ]
    [OK]

Extra: Anv�nd en dropdown ist�llet f�r textruta

## S�tta bakgrundf�rg (front-end)

Visa en sida med samma bakgrundsf�rg som anv�ndaren matar in

	Bakgrundsf�rg
	[                               ]
    [OK]

Extra: Anv�nd en color-picker ist�llet f�r textruta


## Kvadrera

Kvadrera det tal som anv�ndaren matar in

	Nummer
	[                               ]
    [OK]

Extra: validera indata. 

## Lista med siffror

Visa en sida med texten 3,4,5,6,7 (om anv�ndaren matar in 3 och 7)

	Fr�n 
	[                               ]
	Till
	[                               ]
    [OK]

Extra: anv�nd en slider ist�llet f�r textrutorna

## Postman

Testa dina metoder fr�n Postman

## Tips

F�r att returnera text skriv som vanligt:

    return Ok("Collectors promenadstr�k");

F�r att returnera **html** skriv:

    return Content("Collectors <b>promenadstr�k</b>", "text/html");
