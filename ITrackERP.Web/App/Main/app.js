(function () {
    'use strict';
    
    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');

            if (abp.auth.hasPermission('Pages.Users')) {
                $stateProvider
                    .state('users', {
                        url: '/users',
                        templateUrl: '/App/Main/views/users/index.cshtml',
                        menu: 'Users' //Matches to name of 'Users' menu in ITrackERPNavigationProvider
                    });
                $urlRouterProvider.otherwise('/users');
            }

            if (abp.auth.hasPermission('Pages.Tenants')) {
                $stateProvider
                    .state('tenants', {
                        url: '/tenants',
                        templateUrl: '/App/Main/views/tenants/index.cshtml',
                        menu: 'Tenants' //Matches to name of 'Tenants' menu in ITrackERPNavigationProvider
                    });
                $urlRouterProvider.otherwise('/tenants');
            }

            if (abp.auth.hasPermission('Pages.Styles')) {
                $stateProvider
                    .state('styles', {
                        url: '/styles',
                        templateUrl: '/App/Main/views/styles/index.cshtml',
                        menu: 'Styles' //Matches to name of 'Tenants' menu in ITrackERPNavigationProvider
                    });
                $urlRouterProvider.otherwise('/styles');
            }

            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in ITrackERPNavigationProvider
                })

                  .state('styleDetail', {
                      url: '/styles/:id',
                      templateUrl: '/App/Main/views/styles/detail.cshtml',
                      menu: 'Events' //Matches to name of 'Events' menu in ITRACKNavigationProvider
                  })

                .state('styles', {
                    url: '/styles',
                    templateUrl: '/App/Main/views/styles/index.cshtml',
                    menu: 'Style' //Matches to name of 'About' menu in ITrackERPNavigationProvider
                });



        }
    ]);
})();