tempt = []
for h in range(0,24):
    if h == 1:
        temperatura = float(input('Introduza a temperatura à {} hora: '.format(h)))
    else:
        temperatura = float(input('Introduza a temperatura às {} horas: '.format(h)))
    tempt.append(temperatura)
print('O máximo de temperatura registada é {}ºC'.format(max(tempt)))
print('O minimo de temperatura registada é {}ºC'.format(min(tempt)))