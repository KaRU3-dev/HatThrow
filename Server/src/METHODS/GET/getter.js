const http = require('http');

// Responser
const responser = require('./responcer.js');

// Get method
module.exports = (req, res) => {
    if (req.method === 'GET') {
        console.log(req.url);

        responser(req, res);
    }
};
