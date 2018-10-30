# WebApi 5 - Attribut

## Syfte

Validera med och utan attribut.

## L�gg till en person

Skapa en actionmetod **AddPerson** som tar emot ett objekt av typen **SimplePerson** och ger svar, t.ex �Lisa som �r 25 �r lades till i databasen�

    F�rnamn: [       ]
    �lder: [     ]
    [OK]

**Extra**: L�gg till en radio-button i formul�ret


## Validera person

Skapa ett likadant formul�r och en till actionmetod **AddPersonValidate**

Validera nu namnet enligt f�ljande:

- F�rnamn och �lder �r obligatoriskt. 
- �lder kan vara mellan 0 och 120�r. 
- F�rnamnet f�r inte vara l�ngre �n 20 tecken.

Om ovan inte uppfylls s� ge *Bad Request*. Skriv om �ldern �r fel eller namnet eller b�da. Ge annars positivt svar, t.ex �Lisa som �r 25 �r lades till i databasen�

(Anv�nd inte attribut f�r att l�sa uppgiften)

**Extra**: Unders�k tre olika regulj�ruttryck f�r att validera ett f�rnamn och diskutera med din kollega vilket som �r b�st

## Validera person med attribut

Skapa ett likadant formul�r och en till actionmetod **AddPersonValidateAttribute**

L�t actionmetoden f�rv�nta sig ett objekt av **SimplePersonWithAttributes**

L�gg in attribut i SimplePersonWithAttributes

Validera med hj�lp av **ModelState**

Tips:

F�r att kolla om modellen (den inskickade personen) �r ok:

    ModelState.IsValid

F�r att vid fel returnera vad som �r fel:

    return BadRequest(ModelState)


## Postman

Testa dina metoder fr�n Postman

