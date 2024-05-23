import requests

url = "https://api.bypass.vip/bypass?url=https://linkvertise.com/514008/hydrogen-gateway-1"

payload = {}
headers = {}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)
