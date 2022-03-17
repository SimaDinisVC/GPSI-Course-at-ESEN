#Zona das Funções
def transformador(lista): # transforma os valores str da lista para int.
    for i in range(len(lista)):
        lista[i] = int(lista[i])
#Zona Principal
m = input('Introduza a sequência de inteiros de N entre espaços: ').split()
transformador(m)
n = input('Introduza a sequência de inteiros de M entre espaços: ').split()
transformador(n)
p = input('Introduza a sequência de inteiros de P entre espaços: ').split()
transformador(p)

resultado = []
for i in range(len(m)):
    resultado.append(m[i]*n[i]*p[i])

print('Os produtos são:',*resultado, sep=" ", end=".")