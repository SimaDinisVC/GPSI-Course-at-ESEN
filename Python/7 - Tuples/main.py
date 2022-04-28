import qrcode

url = input()

img = qrcode.make(url)

img.save("myQR.jpeg")