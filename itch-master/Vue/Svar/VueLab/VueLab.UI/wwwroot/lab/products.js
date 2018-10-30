// Syfte: visa hur hämta info från controllern

const app = new Vue({
    el: "#app",
    data: {
        products: [
            { name: "Banan", quantity: 4 },
            { name: "Äpple", quantity: 9 }
        ]
    },
    computed: {
        totalProducts() {
            let sum = 0;
            for (let p of this.products) {
                if (p.quantity !=="")
                    sum += p.quantity;
            }
            return sum;

        }
    },
    watch: {
        products: {
            handler: function(val, oldVal) {
                console.log("watch");
                for (let p of this.products) {
                    if (p.quantity <0 )
                        p.quantity=0;
                }
            },
            deep: true
        }
    },

    methods: {
        increase: (p) => {
            p.quantity++;
        },
        decrease: (p) => {
            p.quantity--;
            if (p.quantity < 0)
                p.quantity = 0;
        },
        assertPositive: (p) => {
            if (p.quantity === "")
                p.quantity = 0;

            if (p.quantity < 0)
                p.quantity = 0;
        }
    },

    async created() {
        let response = await fetch("/products");
        this.products = await response.json();
    }
});
