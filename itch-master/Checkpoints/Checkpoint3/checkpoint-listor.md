
# Checkpoint - Listor

## Intro

I uppgifterna nedan ska du bara skapa **metoder**. Anv�nd allts� inte Console.ReadLine eller Console.WriteLine n�nstans.

## Tid 

2h

## Niv� 1

Skriv en metod **MultipleBy100AndAdd3** som tar en lista av heltal som parameter och returnerar en ny lista med heltal.

Multiplicera varje tal med 100 och l�gg till 3

Exempel, listan:

    2 8 3 11

...ska returnera listan

    203 803 303 1103

Anv�nd **ej** Console.Write eller Console.Readline i metoden.


## Niv� 2

L�s f�rst niv�1 (krav)

Skapa sedan en metod **ReorderList** som returnerar en ny lista d�r ordningen �r omkastad.

Exempel

    List<string> result1 = ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 1, 2, 3, 5, 4 });

...ska returnera listan

    a b c e d
Exempel

    List<string> result2 = ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });

...ska returnera listan

    c a d b

Exempel

    List<string> result3 = ReorderList(new List<string> { "a", "b" }, new List<int> { 2, 2 });

...ska returnera listan

    b b
