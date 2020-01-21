"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var ngApp = angular.module('myNgApp', []);
var DataController = /** @class */ (function () {
    function DataController($http) {
        this.http = $http;
        this.getDataAPI();
    }
    DataController.prototype.getDataAPI = function () {
        var that = this;
        this.http.get('/api/Data').success(function (response) {
            that.apiData = response;
        });
    };
    DataController.prototype.submit = function () {
        var req = {
            method: 'POST',
            url: '/api/Data',
            data: this.apiData,
            ContentType: "application/json",
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json',
            }
        };
        this.http(req).success(function (response) {
            toastr.success("Data Saved!");
        }).error(function () { alert("error"); });
    };
    return DataController;
}());
exports.DataController = DataController;
ngApp.controller("DataController", DataController);
//# sourceMappingURL=data.js.map