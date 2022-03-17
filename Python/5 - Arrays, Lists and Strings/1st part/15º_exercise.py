from statistics import mean as média
#Zona das Funções
def passador(lista):
    for i in range(len(lista)):
        lista[i] = int(lista[i])
def Vmédio(lista): # Esta parte do código não é minha, fui buscar a net.
    avg = sum(lista) / len(lista)
    diffs = {value: abs(value - avg) for value in lista}
    return min(diffs, key=diffs.get) ## Fim ##
#Zona Principal
n = input('Introduza a sequência de inteiros de N entre espaços: ').split()
passador(n)
m = input('Introduza a sequência de inteiros de M entre espaços: ').split()
passador(m)

médioN = Vmédio(n)
médioM = Vmédio(m)
print('Lista N:')
print(' - Valor Máximo: {}\n - Valor Mínimo: {}\n - Valor Média: {}'.format(max(n), min(n), médioN))
print('Lista M:')
print(' - Valor Máximo: {}\n - Valor Mínimo: {}\n - Valor Média: {}'.format(max(m), min(m), médioM))