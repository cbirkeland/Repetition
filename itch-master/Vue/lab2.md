# Lab 2
En knapp och en text som h�ller koll p� hur m�nga g�nger knappen trycks ner:

![](lab2a-r�knare.PNG)

Efter att knappen tryckts ner 10 eller fler g�nger:

![](lab2b-r�knare.PNG)

Efter att knappen tryckts ner 20 eller fler g�nger:

![](lab2c-r�knare.PNG)

## Tips

Kolla p� 

    <div v-if="xxxx"></div>


Metoder l�ggs in s�h�r

    const app = new Vue({
        el: "#app",
        data: {
            ...
        },
        methods: {
            myMethod: function() {
                ...
            }
    })