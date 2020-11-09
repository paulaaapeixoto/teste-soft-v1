(function () {
	'use strict';

	angular
		.module('TesteSoft')
		.service('LivroService', LivroService);

	LivroService.$inject = ['$http'];
	function LivroService($http) {


		this.Listar = function () {

			return $http.post('https://localhost:44317/api/Livro/Listar');
		}

		this.Alugar = function (id) {
			return $http.post('https://localhost:44317/api/Livro/Alugar?idLivro=' + id);
		}

		this.Liberar = function (id) {
			return $http.post('https://localhost:44317/api/Livro/Liberar?idLivro=' + id);
		}

		this.Detalhar = function (id) {
			return $http.post('https://localhost:44317/api/Livro/Detalhar?idLivro=' + id);
		}



		var self = this;

	}

})();
