## Databasmodellering

Identifiera alla användare av databasen. T.ex i ett biblitek: båda de som lånar och bibliotikarien.

Lista det du vill spara:
- personer
- saker
- platser
- händelser

Separarera data. Ex landet från adressen (då kan du senare söka på länder)

Bestäm primary key för varje tabell.

Identifiera relationer:

## Ett-till-ett

Normalt inte bra. Kan va bra om det är ett fält ex "description" som ofta är tomt.

## En till många

T.ex en kund har placerat många orders (men en order kan inte vara beställd av flera kunder)

En besökare har lånat flera böcker (men en bok kan inte lånas av flera samtidigt)

Ett politiskt parti har flera presidentkandidater (Men en kandidat kan inte kandidera för flera partier)

## Många-till-många

En student kan gå i flera klasser. En klass kan ha flera studenter.

Krävs att du skapar en till mellanliggande tabell.

    Student -< Enrollments >- Course

En beställning kan bestå av flera produkter
- Skruv
- Hammare
- Spik

Samtidigt kan en produkt vara med i flera olika beställningar (en annan beställning kan också innehålla skruvar)

    Sales -< SoldProducts >- Product

## Obligatorisk eller ej


En produkt kan ha extra info (men behöver inte ha det)

ExtraInfo måste tillhöra en produkt

    Product 1----01 ExtraInfo

Mutually dependent: den ena existerar inte utan den andra.

## Rekursiva relationer

En tabell som pekar tillbaka till sig själv.

Ex i en kundtabell pekar "manager" på en annan kund.

## Onödiga relationer

Ta bort relationer som inte tillför något

## Normalisering
 
Normalisering är bra för databaser där data ska skapas, läsas, uppdateras och tas bort. (OLTP)

Normalisering är inte bra när bara ska läsa data - ex analysera data eller skapa rapporter. Det kan försämra prestandan.

## Första normalformen

En cell får bara ha ett värde

En grupp av fält är inte heller bra (ex Color1, Color2, Color3)

Lösning: dela upp i fler tabeller

## Andra normalformen

Alla attribut ska vara beroende av primärnyckeln.

En tabell med multipla nycklar som t.ex den här:

- Order number (primary key)
- Product ID (primary key)
- Product name

bryter mot 2NF eftersom produktnamnet *inte* är beroende av ordernumret.

## Tredje normalformen

Alla kolumner (som inte är nycklar) ska vara oberoende av de andra.

En tabell med
- OrderId
- Price
- Tax

bryter mot 3NF för "Tax" är beroende av "Price" (och kan räknas ut av det)

## Index

Ett index används för att snabbare söka upp data. Nackdel: det tar längre tid att lägga till, uppdatera och ta bort.

I grunden är det en sorterad kopia av en eller fler kolumner.

## View

En vy är helt enkelt en sparad query.

