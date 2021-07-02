import requests


def bypass(url):
  payload = {
    "url": url,
  }

  r = requests.post("https://api.bypass.vip/", data=payload)
  return r.json()


if __name__ == '__main__':
  result = bypass("https://...")  # include url to bypass
  print(result)
