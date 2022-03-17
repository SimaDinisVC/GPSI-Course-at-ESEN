lista_n = input('Introduza os nº da sequência: ').split()
lista_f = []
for i in range(len(lista_n)):
    lista_n[i] = int(lista_n[i])
    if lista_n[i] not in lista_f:
        lista_f.append(lista_n[i])

for i in range(len(lista_n)): # Imprime A[0] A[1] A[2] A[3] A[4].
    print('A[{}]'.format(i), end="  ")
print('') # retira o end="" final
for i in range(len(lista_n)): # Imprime os valores por baixo.
    print('{}'.format(lista_n[i]), end="    ")
print('') # retira o end="" final

print('O vetor resultante seria:')
for i in range(len(lista_f)): # Imprime os valores por baixo.
    print('{}'.format(lista_f[i]), end="    ")
print('') # retira o end="" final

print("M = {}".format(len(lista_f)))