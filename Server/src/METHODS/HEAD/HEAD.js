const http = require('http');

// Head method
module.exports = (req, res) => {
    if (req.method === 'HEAD') {
        console.log(req.url);

        // Responser
    }
};
