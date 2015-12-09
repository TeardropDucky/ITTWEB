angular.module('proteinNeed', [])
    .controller('pNeedController', function ($scope, $http) {

        $scope.product = {
            potato: ''
        };
        $scope.showProduct = function () {
            return $scope.product.potato;
        };
        $scope.consumed = 0;
        $scope.weight = 0;
        $scope.psycalState = 0.8;
        $scope.showProteinNeed = function () {
            return $scope.weight * $scope.psycalState;
        };
        $scope.Math = window.Math;
        $scope.pNeed = function () {
            return $scope.weight + $scope.consumed;
        };
    });