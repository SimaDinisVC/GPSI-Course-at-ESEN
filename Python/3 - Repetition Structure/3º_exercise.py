print("Introduza a temperatura em ºC.")
maior = -40
menor = 100
for i in range(9,18):
    print("Hora",i,"h -",i,"h : 59 min")
    temp = int(input("Indique a temperatura:\n"))
    if temp > maior:
        maior = temp
    if temp < menor:
        menor = temp
amplitude = maior - menor
print("A maior temperatura registada é de,",maior,"ºC e a menor temperatura registada é de,",menor,"ºC e a amplitude termica é de",amplitude,"ºC.")