import aiohttp
import asyncio

async def bypass(s, url):
  payload = {
    "url": url,
  }

  async with s.post("https://api.bypass.vip/", data=payload) as r:
    return await r.json()

async def main():
  async with aiohttp.ClientSession() as s:
    result = await bypass(s, "https://...")  # include url to bypass
    print(result)

loop = asyncio.get_event_loop()
loop.run_until_complete(main())
