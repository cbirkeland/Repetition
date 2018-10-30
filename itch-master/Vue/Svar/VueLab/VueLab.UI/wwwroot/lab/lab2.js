// Syfte: sätt olika booleans beroende på hur många gånger användaren tryckt + uppdatera gui
const app = new Vue({
    el: "#app",
    data: {
        counter: 0,
        manytimes: false,
        morethan20: false
    },
    methods: {
        buttonClick: function () {
            this.counter++;
            if (this.counter >= 20) {
                this.manytimes = false;
                this.morethan20 = true;

            } else if (this.counter >= 10) {
                this.manytimes = true;
                this.morethan20 = false;
            }
        }
    }
});
