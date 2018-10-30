// Syfte: skillnad på "computed" och "methods". Lagom svårt exempel med variabler som är beroende av varandra

const app = new Vue({
    el: "#app",
    data: {
        names: ["Royal", "Etheline", "Henry", "Chas", "Richie", "Margot", "Ari", "Uzi" ],
        newname: null,
        charStart: "C",
        caseSensitive: true
    },
    computed: {
        startsWithR() {
            return this.startsWithChar("R");
        },
        startsWithM() {
            return this.startsWithChar("M");
        }
    },
    methods: {
        startsWithChar(c) {
            if (!c || c.length === 0)
                return [];

            if (this.caseSensitive)
                return this.names.filter(n => n.startsWith(c));
            else
                return this.names.filter(n => n.toLowerCase().startsWith(c.toLowerCase()));

        },
        addName() {
            this.names.push(this.newname);
        }
    }
});

/* Computed:
 - manipulera data som finns i din Vue. Ex filtrar och transformera data.
 - kan ej ta parametrar
 - getter och ibland setter
 - uppdateras automatiskt
*/
