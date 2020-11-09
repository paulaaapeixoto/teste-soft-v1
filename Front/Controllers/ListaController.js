(function () {
	'use strict';

	angular
		.module('TesteSoft')
		.controller('ListaController', ListaController);

	ListaController.$inject = ['$scope', 'LivroService', '$location'];
	function ListaController($scope, LivroService, $location) {



		$scope.Listar = function () {

			LivroService.Listar().then(function (responseSucess) {

				$scope.listaLivros = responseSucess.data;

			}).catch(function (error) {
				alert(error.data.Message);
			});
		}

		$scope.Alugar = function (id) {

			LivroService.Alugar(id).then(function (responseSucess) {

				if (responseSucess.data == false)
					alert("Este livro já está alugado");
				else {
					alert("Livro alugado");
					$scope.Listar();
				}

			}).catch(function (error) {
				alert(error.data.Message);
			});
		}

		$scope.Liberar = function (id) {

			LivroService.Liberar(id).then(function (responseSucess) {
				$scope.Listar();

			}).catch(function (error) {
				alert(error.data.Message);
			});
		}

		$scope.Detalhar = function (id) {
			$location.url('/detalhes?idLivro=' + id);
		}

		$scope.Listar();
	}

})();

