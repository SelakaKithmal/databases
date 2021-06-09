const fs = require('fs');
const faker = require('faker');

const path = 'tasks.csv';
const header = 'TaskName,ProjectName\n';
let lim = 100000;

fs.appendFile(path, header, 'utf8', err => {
    err ? console.log(err.message) : null
});

while(lim >= 0) {
    faker.seed(lim);

    let data = `${faker.random.words(2)},${faker.commerce.department()}\n`

    fs.appendFileSync(path, data, 'utf-8', err => {
        err ? console.log(err.message) : null
    })

    lim--;
}