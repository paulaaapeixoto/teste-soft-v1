(function () {
    'use strict';

    angular
        .module('TesteSoft')
        .service('LoginService', LoginService);

    LoginService.$inject = ['$http'];
    function LoginService($http) {


        this.Logar = function (credenciais) {       

            return $http.post('https://localhost:44317/api/Login/Logar', credenciais);
        }

        var self = this;

    }

})();
