(function () {
	'use strict';

	angular
		.module('TesteSoft')
		.controller('LoginController', LoginController);

	LoginController.$inject = ['$scope', 'LoginService', '$location'];
	function LoginController($scope, LoginService, $location) {

		$scope.Logar = function () {

			var credenciais = {
				NomeUsuario: $scope.Usuario,
				Senha: $scope.Senha,
			};

			LoginService.Logar(credenciais).then(function (responseSucess) {

				$scope.Usuario = responseSucess.data;
				$location.url('/lista');

			}).catch(function (error) {
				SweetAlert.swal("Ocorreu um erro ao exportar a DANFE.", error.data.Message, "error");
			});
		}
	}

})();

