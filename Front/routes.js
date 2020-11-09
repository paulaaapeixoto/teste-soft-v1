(function () {
	'use strict';

	angular
		.module('TesteSoft', ['ngRoute'])
		.config(InicializaRotas);

	InicializaRotas.$inject = ['$routeProvider']


	function InicializaRotas($routeProvider) {

		$routeProvider
			.when("/", {
				templateUrl: 'Views/login.html',
			})
			.when('/lista', {
				templateUrl: 'Views/lista.html',
			})
			.when('/detalhes', {
				templateUrl: 'Views/detalhes.html',
			})
			.otherwise({ redirectTo: '/' });
	}

})();