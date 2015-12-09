angular.module('proteinNeed', [])
    .controller('pNeedController', function ($scope, $http) {

        $scope.product = {
            potato: ''
        };
        $scope.showProduct = function () {
            return $scope.product.potato;
        };
        $scope.consumed = 0;
        $scope.weight = 1;
        $scope.Math = window.Math;
        $scope.pNeed = function () {
            return $scope.weight + $scope.consumed;
        };
    });