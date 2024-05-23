const axios = require('axios');

let config = {
    method: 'get',
    url: 'https://api.bypass.vip/bypass?url=https://linkvertise.com/514008/hydrogen-gateway-1'
};

const response = await axios.request(config);
console.log(JSON.stringify(response.data));

makeRequest();
