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

    // Check request url
    // if (req.url === '/get/character' && req.method === 'GET'){
    //     // Response header
    //     res.writeHeader(200, { 'Content-type': 'application/json' });

    //     // Response body
    //     const userCharacter = {
    //         name: 'Hat Game',
    //     };

    //     // Console log request url and status
    //     console.log(req.url, res.statusCode);

    //     // Convert to string and send response
    //     res.end(JSON.stringify(userCharacter));
    // }else{
    //     // Response header
    //     res.writeHead(404, { 'Content-Type': 'text/plain' });
    //     // Response
    //     res.end('Not Found');
    // }
});

// Server start
server.listen(port, hostname, () => {
    console.log(`Server running at http://${hostname}:${port}/`);
});
