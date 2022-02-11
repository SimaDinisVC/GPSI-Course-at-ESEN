import random
#Zona das Funções
def lista1e2(comida):
    lista = []
    for i in range(1,6):
        pratos = input("Introduza o {0}º prato escolhido de {1}: ".format(i,comida))
        lista.append(pratos)
    return lista
def baralhador(padrao): # Baralha o conteúdo dentro das listas de carne e peixe.
    baralhada = []
    baralho = list(range(0,len(padrao)))
    for i in range(0,len(padrao)):
        o = random.choice(baralho)
        baralhada.append(padrao[o]) # Adiciona o valor com o nº escolhido pelo random do baralho
        baralho.pop(baralho.index(o)) # Remove o valor com o nº escolhido pelo random do baralho, para que o pc não escolha nos proximos loop's o mesmo nº
    return baralhada
#Zona Principal
booleanos = [True, False]
carne = lista1e2("carne")
peixe = lista1e2("peixe")
carne = baralhador(carne)
peixe = baralhador(peixe)
ementa = []
for i in range(5):
    if random.choice(booleanos) == True: # Faz com que o programa decida se a semana começa com carne ou peixe.
        ementa.append(carne[i]) # Vai alternando os pratos -
        ementa.append(peixe[i]) # - de carne e peixe.
    else:
        ementa.append(peixe[i])
        ementa.append(carne[i])
print("-------.-------")
print('A ementaque o programa fez para dez dias é a seguinte:')
for i in range(1,len(ementa)+1):
    print("{0}º dia - {1}".format(i,ementa[i-1]))
print("-------.-------")