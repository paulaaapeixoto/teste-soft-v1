(function () {
	'use strict';

	angular
		.module('TesteSoft')
		.controller('DetalhesController', DetalhesController);

	DetalhesController.$inject = ['$scope', '$routeParams', 'LivroService'];
	function DetalhesController($scope, $routeParams, LivroService) {

		if ($routeParams.idLivro > 0) {
			
			LivroService.Detalhar($routeParams.idLivro).then(function (responseSucess) {

				$scope.LivroDetalhe = responseSucess.data;

			}).catch(function (error) {
				alert(error.data.Message);
			});

	
		}

	}

})();

