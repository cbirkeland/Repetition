# SQL Injection

Utgå ifrån checkpointen med tomtar.

Lägg till en metod i DataAccess.cs:

    void AddGnome_Vulnerable(string gnomeName)

... som är känslig för SQL-injection. (Skapa SQL-kod genom att helt enklet foga ihop strängar)

Utför sedan SQL-injection och ta bort alla rader i Gnome-tabellen.

Lägg sedan till en till metod:

    void AddGnome(string gnomeName)

... som skyddar mot SQL-injections genom att använda SqlParameters 

Slutligen, gör en egen metod som skyddar mot SQL-injection, men du får inte använda SqlParameters:

    void AddGnome_CustomProtection(string gnomeName)


