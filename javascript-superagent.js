const superagent = require('superagent');

superagent
.post('https://api.bypass.vip/')
.send({
    url: 'https://...' //URL to be bypassed
})
.then(res => {
    console.log(res.body);
});