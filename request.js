var request = require('request');
var options = {
    'method': 'GET',
    'url': 'https://api.bypass.vip/bypass?url=https://linkvertise.com/514008/hydrogen-gateway-1',
    'headers': {
    }
};
request(options, function (error, response) {
    if (error) throw new Error(error);
    console.log(response.body);
});
