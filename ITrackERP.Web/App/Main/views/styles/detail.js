(function () {
    var controllerId = 'app.views.styles.detail';
    angular.module('app').controller(controllerId, [
        '$scope', '$state', '$stateParams', 'abp.services.app.style',
        function ($scope, $state, $stateParams, styleService) {
            var vm = this;

            function loadStyles() {
                styleService.getDetail({
                    id: $stateParams.id
                }).success(function (result) {
                    vm.style = result;
                });
            }

           
       vm.backToEventsPage = function () {
                $state.go('styles');
            };

       loadStyles();

           
        }
    ]);
})();