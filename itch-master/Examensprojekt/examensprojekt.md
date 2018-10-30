
# Examenarbetet 

## Rutiner

* 9.00 Samling (alla dagar)

Ha ett **standup** (ett kortare m�te, 10min, offline) varje morgon vid en best�md tid d�r ni g�r igenom hur ni ska l�gga upp dagen.

Ha ett **retrospektiv** p� onsdag 17:e oktober. G� igenom vad som funkar bra i gruppen och vad som kan f�rb�ttras sista tiden (i ert samarbete).

Ta **bilder** p� skisser och id�er under projektets g�ng. Det �r kul att se p� redovisingen.

## Demo p� torsdag

Demo av ert projekt f�r l�raren.

Vad �r gjort och vilka userstories �r uppfyllda?

## Karma

Ge av din tid f�r att hj�lpa **dina gruppmedlemmar** om de k�r fast

Dela med er av kunskap **mellan grupperna**. Har er grupp l�st n�t som en annan grupp beh�ver s� ta tid att hj�lpa dem. Det �r ingen t�vling mellan grupperna.

Att hj�lpa andra ger **Karma**. Sl�pp egot :)

## Meta karma polis

* Rezan

## Karma poliser

* Boris 		
* Johan  		
* Anastasia		
* Jesper		

## GIT

B�rja med att skapa ett gemensamt repository f�r projektet.

Tips p� namngivning:
- kort namn
- unikt
- ej s� specifikt (t�nk twitter, blocket, facebook, instagram, google)
- kan vara ett hittep�namn som inte betyder n�t

https://github.com/happy-bits/itch/blob/master/.gitignore


## Projekt att utg� ifr�n

Kolla p� denna superbra kurs av Scott Allen:

https://www.pluralsight.com/courses/aspdotnet-core-fundamentals

Skippa det som r�r Razor Pages

Utg� ifr�n en modifierad version av hans projekt som heter **OdeToFood** och bygg vidare p� det (ta s�klart bort det ni inte beh�ver och byt namn p� projektet/databasen)

## Cleancode

Vi har diskuterat clean architecture, men risken �r att det kommer sluka all tid om ni g�r in p� cleancode f�r h�rt. Jag rekommenderar att ni skapar **ett projekt** f�r allt. Och sedan **ett testprojekt**

H�ll metoderna i **Controllers korta** (1-5 rader l�nga). Actionmetoderna ska mest delegera ansvaret till �vriga.

L�t controllern och �vriga enbart vara **beroende av interface** (t.ex IGreeter) - ej konkreta klasser (t.ex Greeter)

Ha knappt n�gon logik i vyerna (Views). N�n enstaka if-sats �r okej.

Skapa ett (eller flera) **repository**, se IRestaurantData och SqlRestauranData

Anv�nd er mycket av **Services** och skapa ett interface f�r varje service. Injekta interfacet i en konstruktor f�r att f� det att funka. Se t.ex IGreeter och Greeter och hur konfigureringen g�rs i Startup.cs. Services kan med f�rdel injecta andra services.

G�r en skillnad mellan **Models** och **ViewModels**. "ViewModels" �r modeller f�r info som kommer till eller fr�n en controller.

Generellt:
- **Korta metoder** som g�r en sak
- T�nk p� **namngivning av metoder** + variabler (det �r en del av probleml�sandet)

## Tester

Testa m�nga sm�, isolerade delar av appen.

Under tiden du utvecklar n�n knepig metod: skriv tester. Det kommer snabba upp utvecklandet och du f�r testerna "p� k�pet"

Kika g�rna p� "heartbeats" och Runscope.

# User stories

Formulera 3-10 userstories uifr�n formen: 

    Som <roll> vill jag <m�l/�nskan/h�ndelse> f�r att <syfte>

H�r finns bra exempel:

https://www.happiness.se/artiklar/vad-ar-en-user-story

