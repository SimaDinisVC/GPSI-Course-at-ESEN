#Zona de Definição de Funções
def pares(n, m):
    contador = n
    for i in range(n,m-1):
        contador = contador + 1
        if contador % 2 == 0:
            print(contador, end=';')
#Zona Principal
print('Programa que apresenta todos os números pares entre dois números inteiros')
n = int(input('Introduza o 1º número de entrada:\n'))
m = int(input('Introduza o 2º número de entrada:\n'))
while n >= m:
    print('Valores Inválidos!')
    n = int(input('Introduza o 1º número de entrada:\n'))
    m = int(input('Introduza o 2º número de entrada:\n'))
print('O(s) número(s) pare(s) que existe(m) entre {0} e {1} é/são o '.format(n,m),end='')
pares(n,m)