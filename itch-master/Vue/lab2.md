# Lab 2
En knapp och en text som håller koll på hur många gånger knappen trycks ner:

![](lab2a-räknare.PNG)

Efter att knappen tryckts ner 10 eller fler gånger:

![](lab2b-räknare.PNG)

Efter att knappen tryckts ner 20 eller fler gånger:

![](lab2c-räknare.PNG)

## Tips

Kolla på 

    <div v-if="xxxx"></div>


Metoder läggs in såhär

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