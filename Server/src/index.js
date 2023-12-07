// Module import
const http = require('http');

// Server settings
const hostname = '127.0.0.1';
const port = 8000;

// Methods
// GET: tester
const getter = require('./METHODS/GET/getter.js');

// Server creation
const server = http.createServer((req, res) => {

    // Call GET: tester
    getter(req, res);

});

// Server start
server.listen(port, hostname, () => {
    console.log(`Server running at http://${hostname}:${port}/`);
});
