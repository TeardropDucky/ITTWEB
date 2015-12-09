angular.module('proteinNeed', [])
    .controller('pNeedController', function ($scope, $http) {
        $scope.Math = window.Math;

        $scope.product = {
            picked: ''
        };
        $scope.showProduct = function () {
            return $scope.product.potato;
        };

        $scope.consumed = 0;
        $scope.pEaten = function () {
            return $scope.weight + $scope.consumed;
        };

        $scope.weight = 0;
        //hurra for copy pasta
        $scope.addresses = [
        { 'state': 'Normal' },
        { 'state': 'Svækket' },
        { 'state': 'Trænning' }
        ];
        $scope.lov_state = [
            { 'lookupCode': 0.8, 'description': 'Normal' },
            { 'lookupCode': 1.5, 'description': 'Svækket' },
            { 'lookupCode': 2.0, 'description': 'Trænning' }
        ];

        $scope.pNeed = function(){
            return $scope.weight + $scope.addresses.state;
        };
    });