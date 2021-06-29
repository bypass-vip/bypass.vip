/*
  USING FETCH AND THEN.
*/
fetch('https://api.bypass.vip', {
    method: 'POST',
    body: new URLSearchParams({
        'url': `${url}` //THE URL THAT YOU WANT TO BYPASS : string
    })
}).then(response => response.json())
.then(data => {
  console.log(data); //LOG THE RESPONSE TO THE CONSOLE.
}).catch(err => {
  console.log(err)
});
/*
  IN A FUNCTION
*/
async function bypass() {
    try {
        const response = await fetch('https://api.bypass.vip', {
            method: 'POST',
            body: new URLSearchParams({
                'url': `${url}` //THE URL THAT YOU WANT TO BYPASS : string
            })
        });
        const result = await response.json()
        if(result.success == true) {
            console.log(result.destination)
        }
        else if (result.success == false) {
            console.log(result.response)
        }
    }
    catch {
        console.log('Error contacting API')
    }
}
