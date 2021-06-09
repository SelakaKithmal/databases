const fs = require('fs');
const faker = require('faker');

const path = 'provisions.csv';
const header = 'ClientName,LocationName,LocationTypeName,TimezoneName,Lat,Long\n';
let locationTypes = ["Holding Company","Organization","Region","Area","Branch","Department"];
let lim = 5000;

fs.appendFile(path, header, 'utf8', err => {
    err ? console.log(err.message) : null
});

while(lim >= 0) {
    faker.seed(lim);

    let data = `"${faker.company.companyName()}","${faker.address.cityName()}","${locationTypes[Math.round((Math.random() * locationTypes.length - 1))]}","${faker.address.timeZone()}","${faker.address.latitude()}","${faker.address.longitude()}"\n`

    fs.appendFile(path, data, 'utf-8', err => {
        err ? console.log(err.message) : null
    })

    lim--;
}