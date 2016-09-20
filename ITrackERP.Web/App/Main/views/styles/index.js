(function () {
    angular.module('app').controller('app.views.styles.index', [
        '$scope', '$modal', 'abp.services.app.style',
        function ($scope, $modal, styleService) {
            var vm = this;

            vm.styles = [];

            function getStyles() {
                styleService.getStyles({}).success(function (result) {
                    vm.styles = result.items;
                });
            }

           

            getStyles();
        }
    ]);
})();