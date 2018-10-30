# WebApi 4 - Response

 
## Dela choklad

Beräkna hur många chokladbitar alla får. Det finns 25 bitar från början.

Om användaren matar in 0 eller lägre så ge statuskoden “Bad Request” och lämpligt felmeddelande.

    Antal personer
    [          ]    
    [OK]       

**Extra:** Gör valideringen först på klientsidan sedan på serversidan

## Hämta order

Användaren matar in en order på formen XX-9999. Alltså två bokstäver och sedan fyra siffror. T.ex AB-1234 eller SE-9500.

Om fel format på ordernumret matas in så ge **bad request** med lämpligt meddelande.

Om de fyra siffrorna är högre än 3000 så ge **not found**.

Annars ge ok med meddelande, t.ex “Order RE-2523 hittades i databasen”.

    Ordernummer
    [RE-2523                           ]
    [OK]       

**Extra:** Skapa en textfil som innehåller en lista på ordernummer och ordertext. Använd detta som dina datakälla och gör uppslag. T.ex “Order RE-2523  innehåller texten Kalle köper en kofta”. Utdrag ur textfilen:

    RE-2523		Kalle köper en kofta
    AB-9345		Lisa köper tre biobiljetter

## Slå upp användarnamn 

Gränsnitt:

    Användarnamn
    [               ]
    [OK]


Funktion:

    Om Stewie matas in => Exception med innehåll “DATA ERROR!”
    Om Peter matas in => visa bild på en explosion
    Om Lois, Meg, Chris, Brian matar in => visa en bild på nån som gör tummen upp
    Annars => visa tummen ner

**Extra:** gör en snygg design av detta, använd stora reglage och mycket bilder


## Postman

Testa dina metoder från Postman


## Extra: Lampa (front-end)

Visa en gul sida om checkboxen är ifylld och knappen trycks ner. Annars en grå. Lös detta med javascript.

    ☑ Slå på lampa
    [OK]


## Extra: Lampa II (front-end)

Samma som förra uppgiften men ta bort OK-knappen.

    ☑ Slå på lampa
