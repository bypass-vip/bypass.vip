const fetch = require('node-fetch')

fetch('https://api.bypass.vip/', {
    method: 'POST',
    body: new URLSearchParams({
        url: 'https://...' //URL to be bypassed
    })
})
.then(response => response.json())
.then(data => console.log(data))