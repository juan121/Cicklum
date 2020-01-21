require('../../node_modules/angular/angular.min.js');
//import {DataController} from "../";
const { DataController } = require('./data');
//import DataController as dt from './data'
//const mock = jest.fn<DataController>();

test('Get data from the API', () => {
    debugger
    //console.log(DataCtrl);
    expect(new DataController().getDataAPI()).toHaveBeenCalled();
  //expect(true).toBe(true);
});