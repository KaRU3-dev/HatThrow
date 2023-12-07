const fs = require('fs');
const path = require('path');
const http = require('http');

// Data folder path
const dataFolder = path.join(__dirname, '../../../data');
const userDataFolder = path.join(dataFolder, 'Users');

module.exports = (req, res, userId) => {
    // Find user file
    const userFile = path.join(userDataFolder, `${userId}.json`);

    // Check if file exists
    if (fs.existsSync(userFile)) {
        // Read file
        fs.readFile(userFile, (err, data) => {
            // Check for errors
            if (err) throw err;

            // Convert to object
            const userObject = JSON.parse(data);

            // Response header
            res.writeHeader(200, { 'Content-type': 'application/json' });

            // Response body
            const userCharacter = {
                id: userObject.id,
                name: userObject.name,
                hat: userObject.hat,
            };

            // Console log request url and status
            console.log(req.url, res.statusCode);

            // Convert to string and send response
            res.end(JSON.stringify(userCharacter));
        });
    } else {
        // Response header
        res.writeHead(404, { 'Content-Type': 'text/plain' });

        // Console log where this file
        console.log(__filename);

        // Response
        res.end('Not Found');
    }
};
