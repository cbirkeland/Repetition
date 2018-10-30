# SQL Injection

Utg� ifr�n checkpointen med tomtar.

L�gg till en metod i DataAccess.cs:

    void AddGnome_Vulnerable(string gnomeName)

... som �r k�nslig f�r SQL-injection. (Skapa SQL-kod genom att helt enklet foga ihop str�ngar)

Utf�r sedan SQL-injection och ta bort alla rader i Gnome-tabellen.

L�gg sedan till en till metod:

    void AddGnome(string gnomeName)

... som skyddar mot SQL-injections genom att anv�nda SqlParameters 

Slutligen, g�r en egen metod som skyddar mot SQL-injection, men du f�r inte anv�nda SqlParameters:

    void AddGnome_CustomProtection(string gnomeName)


