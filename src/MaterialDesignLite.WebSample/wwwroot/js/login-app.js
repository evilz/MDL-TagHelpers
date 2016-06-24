// app.js

var vm = new Vue({
    // We want to target the div with an id of 'events'
    el: '#app',

    // Here we can register any values or collections that hold data
    // for the application
    data: {
        email: '',
        password: '',
        isUsingGoogle: false,
        isUsingWindows: false,
        isUsingDefault: true,
        avatarurl: 'https://lh3.googleusercontent.com/yBmRedPXbPfJB69IK_CKnucFfcsZGT5gBt1OpzcJebNTDDvB2QT2KqDN6iRE7G6hGk4'
    },


    // Anything within the ready function will run when the application loads
    ready: function () {  },

    // Methods we want to use in our application are registered here
    methods: {
        login: function () {
            alert(this.email + " " + this.password);
        },

        useGoogle: function () {
            this.isUsingGoogle = true;
            this.isUsingWindows = false;
            this.isUsingDefault = false;
        },
        useWindows: function () {
            this.isUsingGoogle = false;
            this.isUsingWindows = true;
            this.isUsingDefault = false;
        }
    }
});

vm.$watch('email', function (val) {
    val = val.toLowerCase();
    var hash = md5(val);
    this.avatarurl = 'https://www.gravatar.com/avatar/' + hash + '?d=https://lh3.googleusercontent.com/yBmRedPXbPfJB69IK_CKnucFfcsZGT5gBt1OpzcJebNTDDvB2QT2KqDN6iRE7G6hGk4';
});