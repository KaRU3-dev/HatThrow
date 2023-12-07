const http = require('http');

// Get method
const character = require('./character.js');


module.exports = (req, res) => {
    // url parser
    const url = req.url.split('/');

    // if url[1] is get
    if (url[1] !== 'get') return;

    // if url[2] is character
    if (url[2] == 'character') {
        // Call GET: character
        character(req, res, url[3]);
        return;
    }
};
