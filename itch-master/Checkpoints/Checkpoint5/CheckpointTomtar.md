
# Checkpoint - Tomtar

## Intro

L�mna in en **zip** av hela din solution. L�gg �ven med ett script **create-and-insert.sql** som skapar databasen GnomeDb och l�gger in tre tomtar med tillh�rande info.


## Niv� 1

Skapa en databas **GnomeDb** med en tabell **Gnome**

L�gg in tre tomtar i gnome-tabellen. Varje tomte ska ha ett namn.

G�r en console-app som skriver ut namnen p� alla tomtar.

Anv�nd denna connectionstr�ng:

	string conString = "Server = (localdb)\\mssqllocaldb; Database = GnomeDb;"

Ditt huvudprogram **ska** se ut s�h�r:

    var dataAccess = new DataAccess();
    List<string> gnomes = dataAccess.GetGnomesFromDatabase();
    DisplayGnomes(gnomes);

Du beh�ver allts� skapa klassen **DataAccess**. (som inte inneh�ller n�gon Console.Write)

Exempel om efter att du lagt in tre tomtar:

![](CheckpointTomtar_1.png)


## Niv� 2

Uppdatera gnome-tabellen enligt nedan.

Varje tomte:
- har ett namn
- har sk�gg eller �r sk�ggl�sa 
- �r ond eller god 
- har ett temperament (ett heltal)
- tillh�r en ras (t.ex skogstomte, bergstomte, kaostomte)

Skriv ut info om alla tomtar:

![](CheckpointTomtar_2.png)

Obs att "har sk�gg" och "�r ond" ska skrivas ut som "Ja" eller "Nej".

L�gg till en l�mplig tabell och relation.

Ditt huvudprogram **ska** se ut s�h�r:

    var dataAccess = new DataAccess();
    List<Gnome> gnomes = dataAccess.GetGnomesFromDatabase();
    DisplayGnomes(gnomes);

Du beh�ver allts� skapa klasserna **DataAccess** och **Gnome**.
