angular.module('proteinNeed', [])
    .controller('pNeedController', function ($scope, $http) {

        $scope.Weight = 1;
        $scope.Math = window.Math;
        $scope.pNeed = function () {
            return $scope.Weight + 2;
        };
    });