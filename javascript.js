const axios = require('axios');


axios({
  method: 'post',
  url: 'https://api.bypass.vip/',
  data: new URLSearchParams({
    url: 'https://...' //URL to be bypassed
  })
}).then(response => {
  let { data } = response;
  console.log(data)
}).catch(error => console.log(error))
