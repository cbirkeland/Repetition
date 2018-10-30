# Checkpoint - �gg

## Intro

Du ska skriva en html-sida som visar och hanterar �gg. Anv�nd f�ljande tekniker:
- HTML
- CSS
- Javascript

Anv�nd inga f�rdiga ramverk (t.ex Bootstrap, jQuery, React....).

Utg� ifr�n dessa filer (bilder p� �gg + en CSS-fil)

https://github.com/happy-bits/itch/tree/master/Checkpoints/Checkpoint7/startkit

## Niv� 1

�gget kan ha tre tillst�nd:
- st�ngt
- �ppet
- �ppet med tv� �gg inuti

B�rja med att visa tre st�ngda �gg. 

![](img/three-closed-eggs.png)


N�r anv�ndaren klickar p� ett �gg ska det �ppnas. N�sta g�ng �gget klickas s� ska det dyka upp tv� �gg inuti. Klickar anv�ndaren igen s� sluts �gget.

I bilden nedan s� har anv�ndaren tryckt 
- En g�ng p� �gg 1
- Sex g�nger p� �gg 2
- Tv� g�nger p� �gg 3


![](img/level1-eggs.png)

## Niv� 2

B�rja med att visa tre st�ngda �gg. 

![](img/three-closed-eggs.png)

Detta h�nder n�r anv�ndaren klickar p� �ggen.

- Klick p� st�ngt �gg => �gget �ppnas
- Klick p� �ppet �gg => �gget �ppnas med tv� �gg inuti
- Klick p� "�ppet �gg med tv� inuti" => �gget f�rvinner och ers�tts av tv� nya st�ngda �gg p� **samma position**

I bilden nedan s� har anv�ndaren tryckt 
- En g�ng p� �gg 1
- Tv� g�nger p� �gg 3
- Tre g�nger p� �gg 2 (som har spruckit och blivit tv� nya st�ngda �gg)

![](img/level2-eggs.png)


De nya �ggen kan s�klart ocks� f�r�ka sig om anv�ndaren klickar p� dem.