/*
Write a TestCafe javascript file that tests the following:
- The count of forecasts in the forecast table is equal to the number of forecasts in the database
*/
import { Selector } from 'testcafe';
import { ClientFunction } from 'testcafe';

fixture `Count Forecasts`
    .page `http://localhost:5001/`;

test('Count Forecasts', async t => {
    // Connects to the API and gets the count of forecasts
    const getCount = ClientFunction(() => {
        return fetch("http://localhost:5002/weatherforecast")
            .then(response => response.json())
            .then(data => data.length);
    });

    let forecastCount = (await t.request("http://localhost:5002/weatherforecast")).body.length;

    // Counts the number of table rows in the forecast table.
    let tableRowCount = Selector("table#forecasts tbody tr").count;

    // Asserts that the count of forecasts in the forecast table is equal to the number of forecasts in the database from the API.
    await t.expect(tableRowCount).eql(forecastCount);
});