# Hissapp - intro

Skapa en klass **Elevator**. Det ska g� att ange
- namn
- l�gsta v�ning
- h�gsta v�ning
- startv�ning
- tid till underh�ll
- om hissen �r ig�ng eller ej (hissen st�ngs av n�r tid till underh�ll �r 0)

Metoden **GoUp** ska skicka upp hissen och metoden **GoDown** ska skicka upp hissen

**Report** ska ge info om hissen.

Om denna kod k�rs:

        // Test av Kalle

        Header("SKAPAR HISSEN KALLE");
        var e1 = new Elevator("Kalle", -2, 10, 5, 2);
        Console.WriteLine("     " + e1.Report());
        Info("Signal till Kalle att �ka upp en v�ning");
        e1.GoUp();
        Console.WriteLine("     " + e1.Report());

        Info("Signal till Kalle att �ka upp en v�ning");
        e1.GoUp();
        Console.WriteLine("     " + e1.Report());

        Info("Signal till Kalle att �ka upp en v�ning");
        e1.GoUp();
        Console.WriteLine("     " + e1.Report());

        // Test av Lisa (hissen �r redan p� l�gsta niv� s� kommer inte �ka n�nstans)

        Header("SKAPAR HISSEN LISA");
        var e2 = new Elevator("Lisa", 5, 8);
        Console.WriteLine("     " + e2.Report());
        Info("Signal till Lisa att �ka ner en v�ning");
        e2.GoDown();
        Console.WriteLine("     " + e2.Report());

... s� ska detta skrivas ut:

(Header och Info �r bara tv� hj�lpmetoder och h�r inte till Elevator-klassen)

![Elevator Intro](elevator-intro.png)