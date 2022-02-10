pares = []
impares = []
diasimpares = []
diaspares = []
for o in range(2,8):
    if o % 2 == 1:
        if o == 7:
            n_carrosImpares = int(input("Introduza o nº de carros que entraram na cidade no sábado:"))
        else:
            n_carrosImpares = int(input("Introduza o nº de carros que entraram na cidade na {}ª-feira:".format(o)))
        impares.append(n_carrosImpares)
        diasimpares.append(o)
    elif o % 2 == 0:
        n_carrosPares = int(input("Introduza o nº de carros que entraram na cidade na {}ª-feira:".format(o)))
        pares.append(n_carrosPares)
        diaspares.append(o)
print('O programa fez a leitura de {} carros nos dias pares.'.format(sum(pares)))
print('O programa fez a leitura de {} carros nos dias impares.'.format(sum(impares)))
if sum(pares) > sum(impares):
    print("Deverá fechar na {0}ª-feira, na {1}ª-feira e na {2}ª-feira.".format(diaspares[0],diaspares[1],diaspares[2]))
elif sum(impares) > sum(pares):
    if diasimpares[2] == 7:
        print("Deverá fechar na {0}ª-feira, na {1}ª-feira e no sábado.".format(diasimpares[0],diasimpares[1]))
    else:
        print("Deverá fechar na {0}ª-feira, na {1}ª-feira e na {2}ª-feira.".format(diasimpares[0],diasimpares[1],diasimpares[2]))