## Databasmodellering

Identifiera alla anv�ndare av databasen. T.ex i ett biblitek: b�da de som l�nar och bibliotikarien.

Lista det du vill spara:
- personer
- saker
- platser
- h�ndelser

Separarera data. Ex landet fr�n adressen (d� kan du senare s�ka p� l�nder)

Best�m primary key f�r varje tabell.

Identifiera relationer:

## Ett-till-ett

Normalt inte bra. Kan va bra om det �r ett f�lt ex "description" som ofta �r tomt.

## En till m�nga

T.ex en kund har placerat m�nga orders (men en order kan inte vara best�lld av flera kunder)

En bes�kare har l�nat flera b�cker (men en bok kan inte l�nas av flera samtidigt)

Ett politiskt parti har flera presidentkandidater (Men en kandidat kan inte kandidera f�r flera partier)

## M�nga-till-m�nga

En student kan g� i flera klasser. En klass kan ha flera studenter.

Kr�vs att du skapar en till mellanliggande tabell.

    Student -< Enrollments >- Course

En best�llning kan best� av flera produkter
- Skruv
- Hammare
- Spik

Samtidigt kan en produkt vara med i flera olika best�llningar (en annan best�llning kan ocks� inneh�lla skruvar)

    Sales -< SoldProducts >- Product

## Obligatorisk eller ej


En produkt kan ha extra info (men beh�ver inte ha det)

ExtraInfo m�ste tillh�ra en produkt

    Product 1----01 ExtraInfo

Mutually dependent: den ena existerar inte utan den andra.

## Rekursiva relationer

En tabell som pekar tillbaka till sig sj�lv.

Ex i en kundtabell pekar "manager" p� en annan kund.

## On�diga relationer

Ta bort relationer som inte tillf�r n�got

## Normalisering
 
Normalisering �r bra f�r databaser d�r data ska skapas, l�sas, uppdateras och tas bort. (OLTP)

Normalisering �r inte bra n�r bara ska l�sa data - ex analysera data eller skapa rapporter. Det kan f�rs�mra prestandan.

## F�rsta normalformen

En cell f�r bara ha ett v�rde

En grupp av f�lt �r inte heller bra (ex Color1, Color2, Color3)

L�sning: dela upp i fler tabeller

## Andra normalformen

Alla attribut ska vara beroende av prim�rnyckeln.

En tabell med multipla nycklar som t.ex den h�r:

- Order number (primary key)
- Product ID (primary key)
- Product name

bryter mot 2NF eftersom produktnamnet *inte* �r beroende av ordernumret.

## Tredje normalformen

Alla kolumner (som inte �r nycklar) ska vara oberoende av de andra.

En tabell med
- OrderId
- Price
- Tax

bryter mot 3NF f�r "Tax" �r beroende av "Price" (och kan r�knas ut av det)

## Index

Ett index anv�nds f�r att snabbare s�ka upp data. Nackdel: det tar l�ngre tid att l�gga till, uppdatera och ta bort.

I grunden �r det en sorterad kopia av en eller fler kolumner.

## View

En vy �r helt enkelt en sparad query.

