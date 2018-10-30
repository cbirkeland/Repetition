// Syfte: första exempel som visar styrkan med Vue

const app = new Vue({
    el: "#app",
    data: {
        firstname: ""
    },
    computed: {
        doubleword() {
            return this.firstname + this.firstname;
        },
        loud () {
            if (this.firstname.length > 0)
                return "**" + this.firstname.toUpperCase() + "**";
            else
                return "";
        },

        // Extrauppgift
        reverse() {
            return this.firstname.split('').reverse().join('');
        }
    }
});
