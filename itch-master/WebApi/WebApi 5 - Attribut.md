# WebApi 5 - Attribut

## Syfte

Validera med och utan attribut.

## Lägg till en person

Skapa en actionmetod **AddPerson** som tar emot ett objekt av typen **SimplePerson** och ger svar, t.ex “Lisa som är 25 år lades till i databasen”

    Förnamn: [       ]
    Ålder: [     ]
    [OK]

**Extra**: Lägg till en radio-button i formuläret


## Validera person

Skapa ett likadant formulär och en till actionmetod **AddPersonValidate**

Validera nu namnet enligt följande:

- Förnamn och ålder är obligatoriskt. 
- Ålder kan vara mellan 0 och 120år. 
- Förnamnet får inte vara längre än 20 tecken.

Om ovan inte uppfylls så ge *Bad Request*. Skriv om åldern är fel eller namnet eller båda. Ge annars positivt svar, t.ex “Lisa som är 25 år lades till i databasen”

(Använd inte attribut för att lösa uppgiften)

**Extra**: Undersök tre olika reguljäruttryck för att validera ett förnamn och diskutera med din kollega vilket som är bäst

## Validera person med attribut

Skapa ett likadant formulär och en till actionmetod **AddPersonValidateAttribute**

Låt actionmetoden förvänta sig ett objekt av **SimplePersonWithAttributes**

Lägg in attribut i SimplePersonWithAttributes

Validera med hjälp av **ModelState**

Tips:

För att kolla om modellen (den inskickade personen) är ok:

    ModelState.IsValid

För att vid fel returnera vad som är fel:

    return BadRequest(ModelState)


## Postman

Testa dina metoder från Postman

