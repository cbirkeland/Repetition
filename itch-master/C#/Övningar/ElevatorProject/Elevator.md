# Hissapp

## Syfte

Syftet med denna uppgift:
- l�ra sig modellera verkligheten med klasser
- l�ra sig skriva tester f�r att verifiera att koden funkar


## Dom�n

Skapa ett projekt **ElevatorApp.Domain** med en klass **Elevator**.

En hiss ska ha
- ett namn
- en l�gsta v�ning
- en h�gsta v�ning
- h�lla koll p� nuvarande v�ning
- h�lla koll p� hur l�ng det �r kvar tills hissen kr�ver underh�ll
- veta om den kan k�ras eller ej (beror p� om hissen beh�ver underh�ll)

Det ska g� att skicka hissen upp och ner

Hantera fel, ge exception om hissen startar p� en v�ning som �r utanf�r hiss schaktet (ex v�ning 1000 eller -300)

## Test

Skapa ett testprojekt **ElevatorApp.Test** med en testklass i.

Skapa ett tiotal tester som verifierar att din Elevator-klass beter sig som v�ntat

D�p testerna enligt detta m�nster:

    "Should [be in some state] [after/before/when] [action takes place]"

t.ex

    [TestMethod]
    public void elevator_should_be_at_level_2_when_it_starts_at_1_and_go_up_one_floor()
    {
    }

## Console

Skapa ett projekt **ElevatorApp.Gui** av typen Console Application. 

Skapa en Elevator. Skicka den upp och ner och rapportera vilka v�ningar den passerar.

Skapa en till Elevator men ge den felaktiga v�rden. F�nga exception och skriv felmeddelande p� sk�rmen.

![Elevator](elevator.png)

## Extra

Ut�ka projeten p� valfritt s�tt. T.ex 
- L�t anv�ndaren skapa valfritt antal hissar
- Rita ett grafiskt gr�nsnitt (med textgrafik) d�r en kan ser hissar som �ker upp och ner
- Separera hiss-schakt fr�n hissar (olika klasser)
- L�gg till personer som �r p� olika v�ningar och vill ta en hiss �t olika h�ll. Flera hissar, flera personer. Simulering. AI.