declare var angular: any;
var ngApp = angular.module('myNgApp', []);
export interface Data {
    apiData: any;
    getDataAPI: () => void;
    submit: () => void;
}

 export class DataController implements Data {
    apiData: any;
    http: any;
    scope: any;
    constructor($http:any) {
        this.http = $http;
        this.getDataAPI();
    }

    getDataAPI() {
        let that = this;
        this.http.get('/api/Data').success((response: any) => {
            that.apiData = response;
        });
     }

     submit() {
         var req = {
             method: 'POST',
             url: '/api/Data',
             data: this.apiData,
             ContentType : "application/json",
             headers: {
                 'Content-Type': 'application/json',
                 'Accept': 'application/json',
             }
         }
         this.http(req).success((response: any) => {
             toastr.success("Data Saved!");
         }).error(function () { alert("error");});
     }
}
ngApp.controller("DataController", DataController);