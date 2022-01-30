#Zona das Funções
def fatorial(n):
    nI = n
    for i in range(1,n):
        nI = i * nI
    return(nI)
#Zona Principal
n = int(input('Indique o nº para o fatorial:\n'))
while n < 1:
    print('Introduza um nº inteiro positivo!')
    n = int(input('Indique o nº para o fatorial:\n'))
nI = fatorial(n)
print('O fatorial de',n,'é de {}.'.format(nI))