
# Examenarbetet 

## Rutiner

* 9.00 Samling (alla dagar)

Ha ett **standup** (ett kortare möte, 10min, offline) varje morgon vid en bestämd tid där ni går igenom hur ni ska lägga upp dagen.

Ha ett **retrospektiv** på onsdag 17:e oktober. Gå igenom vad som funkar bra i gruppen och vad som kan förbättras sista tiden (i ert samarbete).

Ta **bilder** på skisser och idéer under projektets gång. Det är kul att se på redovisingen.

## Demo på torsdag

Demo av ert projekt för läraren.

Vad är gjort och vilka userstories är uppfyllda?

## Karma

Ge av din tid för att hjälpa **dina gruppmedlemmar** om de kör fast

Dela med er av kunskap **mellan grupperna**. Har er grupp löst nåt som en annan grupp behöver så ta tid att hjälpa dem. Det är ingen tävling mellan grupperna.

Att hjälpa andra ger **Karma**. Släpp egot :)

## Meta karma polis

* Rezan

## Karma poliser

* Boris 		
* Johan  		
* Anastasia		
* Jesper		

## GIT

Börja med att skapa ett gemensamt repository för projektet.

Tips på namngivning:
- kort namn
- unikt
- ej så specifikt (tänk twitter, blocket, facebook, instagram, google)
- kan vara ett hittepånamn som inte betyder nåt

https://github.com/happy-bits/itch/blob/master/.gitignore


## Projekt att utgå ifrån

Kolla på denna superbra kurs av Scott Allen:

https://www.pluralsight.com/courses/aspdotnet-core-fundamentals

Skippa det som rör Razor Pages

Utgå ifrån en modifierad version av hans projekt som heter **OdeToFood** och bygg vidare på det (ta såklart bort det ni inte behöver och byt namn på projektet/databasen)

## Cleancode

Vi har diskuterat clean architecture, men risken är att det kommer sluka all tid om ni går in på cleancode för hårt. Jag rekommenderar att ni skapar **ett projekt** för allt. Och sedan **ett testprojekt**

Håll metoderna i **Controllers korta** (1-5 rader långa). Actionmetoderna ska mest delegera ansvaret till övriga.

Låt controllern och övriga enbart vara **beroende av interface** (t.ex IGreeter) - ej konkreta klasser (t.ex Greeter)

Ha knappt någon logik i vyerna (Views). Nån enstaka if-sats är okej.

Skapa ett (eller flera) **repository**, se IRestaurantData och SqlRestauranData

Använd er mycket av **Services** och skapa ett interface för varje service. Injekta interfacet i en konstruktor för att få det att funka. Se t.ex IGreeter och Greeter och hur konfigureringen görs i Startup.cs. Services kan med fördel injecta andra services.

Gör en skillnad mellan **Models** och **ViewModels**. "ViewModels" är modeller för info som kommer till eller från en controller.

Generellt:
- **Korta metoder** som gör en sak
- Tänk på **namngivning av metoder** + variabler (det är en del av problemlösandet)

## Tester

Testa många små, isolerade delar av appen.

Under tiden du utvecklar nån knepig metod: skriv tester. Det kommer snabba upp utvecklandet och du får testerna "på köpet"

Kika gärna på "heartbeats" och Runscope.

# User stories

Formulera 3-10 userstories uifrån formen: 

    Som <roll> vill jag <mål/önskan/händelse> för att <syfte>

Här finns bra exempel:

https://www.happiness.se/artiklar/vad-ar-en-user-story

