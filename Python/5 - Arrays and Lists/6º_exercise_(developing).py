import random
#Zona das Funções
def lista1e2(comida):
    lista = []
    for i in range(1,6):
        pratos = input("Introduza o {0}º prato escolhido de {1}: ".format(i,comida))
        lista.append(pratos)
    return lista
def baralhador(padrao):
    baralhada = []
    baralho = list(range(0,len(padrao)+1))
    print(baralho)
    for i in range(0,len(padrao)):
        o = random.choice(baralho)
        print(o)
        baralhada.append(padrao[o]) # Adiciona o valor com o nº escolhido pelo random do baralho
        baralho.pop(o) # Remove o valor com o nº escolhido pelo random do baralho, para que o pc não escolha nos proximos loops o mesmo nº
    print(baralho)
    return baralhada
#Zona Principal
booleanos = [True, False]
boolCarne = random.choice(booleanos) # Faz com que o programa decida com qual tema de pratos quer começar a semana.
carne = lista1e2("carne")
peixe = lista1e2("peixe")
carne = baralhador(carne)
peixe = baralhador(peixe)
ementa = []
for i in range(5):
    if boolCarne == True:
        ementa.append(carne[i])
        ementa.append(peixe[i])
        print(ementa)
    else:
        ementa.append(peixe[i])
        ementa.append(carne[i])
        print(ementa)