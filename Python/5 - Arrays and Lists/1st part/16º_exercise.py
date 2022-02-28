#Zona das Funções
def transformador(lista): # transforma os valores str da lista para int.
    for i in range(len(lista)):
        lista[i] = int(lista[i])
#Zona Principal
n = input('Introduza a sequência de inteiros de N entre espaços: ').split()
transformador(n)
m = input('Introduza a sequência de inteiros de M entre espaços: ').split()
transformador(m)
auxilio_Copy = n

n = m[::-1]
m = auxilio_Copy[::-1]

print("Lista N:",n,"\nLista M:",m)