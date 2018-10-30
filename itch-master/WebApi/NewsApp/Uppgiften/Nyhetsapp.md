# Nyhetsapp

## Intro

Skapa en nyhetsapp. Tekniker:
- WebApi
- AJAX 
- Single Page Application 
 
Anv�ndaren �r hela tiden kvar p� samma html-sida.

N�r en nyhet skapas/�ndras/tas bort s� ska tabellen automatiskt uppdateras.


## Startvyn

N�r anv�ndaren surfar in till sajten, s� visa f�ljande gr�nsnitt:

![x](img/startpage.PNG)

Alla nyheter ska listas.

## L�gg till nyhet

Om anv�ndaren trycker **Add** s� visas f�ljande:

![x](img/add.PNG)

Klick p� **Add**-knappen l�ngst ner => uppdatera nyhetstabellen.

## Uppdatera en nyhet

Om anv�ndaren trycker **Update** s� visas f�ljande:

![x](img/update.PNG)

Klick p� **Update**-knappen l�ngst ner => uppdatera nyhetstabellen.

## Ta bort en nyhet

Om anv�ndaren trycker p�  **X** s� ta bort nyheten

## Statistik

Om anv�ndaren trycker p� **Statistics** s� visa f�ljande vy d�r det g�r att se antalet nyheter:

![x](img/update.PNG)

## Validering

Validera nyheter

Rubrik, ingress och inneh�ll �r obligatoriska.

Rubriken m�ste vara mellan 5 och 20 tecken l�ng.

Visa felmeddelande i form av en popup (alertruta) och informera anv�ndaren om vad som �r fel.

S�tt **CreatedDate** och **UpdatedDate** till l�mpliga v�rden n�r du skapar och uppdatera en nyhet.

## Seed och Recreate

Seed => ta bort alla nyheter. Skapa tv� nyheter (h�rdkodade)

Recreate => sl�ng bort databasen och skapa en helt ny