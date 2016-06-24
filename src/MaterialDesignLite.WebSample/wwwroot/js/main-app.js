// app.js

Vue.directive('slider',
{
    twoWay: true,
    bind: function() {
        this.handler = function () {
            this.set(this.el.value);
        }.bind(this);
        this.el.addEventListener('input', this.handler);
        if (!this.el.MaterialProgress)
            componentHandler.upgradeElement(this.el);
    },
    update: function (newValue, oldValue) {
       
        this.el.MaterialSlider.change(newValue);
    },
    unbind: function() {
        this.el.removeEventListener('input', this.handler);
    }
});

    // The directive may be called before the element have been upgraded
    //if (!this.el.MaterialProgress)
    //    componentHandler.upgradeElement(this.el);
    //this.el.MaterialSlider.change(val);


// register the grid component
Vue.component('demo-grid',
{
    template: '#grid-template',
    props: {
        data: Array,
        columns: Array,
        filterKey: String
    },
    data: function () {
        var sortOrders = {}
        this.columns.forEach(function (key) {
            sortOrders[key] = 1
        })
        return {
            sortKey: '',
            sortOrders: sortOrders
        }
    },
    methods: {
        sortBy: function (key) {
            this.sortKey = key
            this.sortOrders[key] = this.sortOrders[key] * -1
        }
    }
});


var vm = new Vue({
    // We want to target the div with an id of 'events'
    el: '#app',

    // Here we can register any values or collections that hold data
    // for the application
    data: {
        sliderValue: 0,
        searchQuery: '',
        gridColumns: ['name', 'power'],
        gridData: [
            { name: 'Chuck Norris', power: Infinity },
            { name: 'Bruce Lee', power: 9000 },
            { name: 'Jackie Chan', power: 7000 },
            { name: 'Jet Li', power: 8000 }
        ]
    },


    // Anything within the ready function will run when the application loads
    ready: function() {},

    // Methods we want to use in our application are registered here
    methods: {
        toggle: function(event) {
            $(event.currentTarget).toggleClass("expended");
        },

        sliderUpdate: function (event) {
            componentHandler.upgradeElement(event.target);
            //$(event.currentTarget).MaterialSlider.change(event.currentTarget.value);
            this.sliderValue = event.currentTarget.value;

        }
    }
});
