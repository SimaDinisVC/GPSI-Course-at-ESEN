#Nota: Quis fazer com segundos também!
horas = 0
minu = 0
seg = 0
for i in range(1,6):
    tempo = input("Indique o tempo no formato min:seg (00:00):\n")
    split = tempo.split(":")
    minutos = int(split[0])
    segundos = int(split[1])
    minu = minu + minutos
    seg = seg + segundos
descseg = seg//60
minu = minu + descseg
seg = seg - (descseg*60)
descmin = minu//60
horas = horas + descmin
minu = minu - (descmin*60)
print("A corrida demorou:\n",horas,":",minu,":",seg)