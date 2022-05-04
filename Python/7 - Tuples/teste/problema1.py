lista_tupla = []
loop = True
contador = 0
while loop:
    tempos = tuple(map(int, input("Tempos: ").split()))
    contador += 1
    if tempos != (0,): ##### Parte Normal do Problema #####
        print("{}º piloto:".format(contador))
        volta_mr = min(tempos)
        nvolta_mr = tempos.index(volta_mr)+1 
        soma = 0
        # Media #
        for i in tempos:
            soma += i
        media = soma/len(tempos)
        # lista ordenada # 
        lo = sorted(tempos)
        print(" A volta mais rápida foi a nº{0} com {1} ms.".format(nvolta_mr, volta_mr))
        print(" Total de voltas:",len(tempos))
        print(" A média de tempo do piloto foi:",media)
        print(" Lista ordenada de mais rápida para menos rápida:", lo)
        lista_tupla.append(tempos)
    else:
        loop = False 
##### AVANÇADO #####
print("AVANÇADO:")
lista_dictORDtempMin = [] # Guarda os min tempos de cada piloto, e o seu nº
for t in lista_tupla:
    lista_dictORDtempMin.append({"p":(lista_tupla.index(t)+1, min(t))}) # P é apenas para identificação no lambda e no print
lista_dictORDpiloto = sorted(lista_dictORDtempMin, key = lambda x:x["p"]) #Ordena pelo tempos
for i in lista_dictORDpiloto:
    print(" {0}ºpiloto - ({1}ms)".format(i["p"][0], i["p"][1]))