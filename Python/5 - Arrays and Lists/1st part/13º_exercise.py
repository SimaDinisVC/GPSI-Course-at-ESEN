vetor = input('Introduza as notas separadas entre espaços: ').split()
adjacentes = []
for i in range(len(vetor)): 
    vetor[i] = int(vetor[i]) # Transforma os elementos em inteiro devido ao .split() cortar apenas strings
for i in range(len(vetor)-1):
    if i != 0 and i != len(vetor): # Verifica se não está nas extremidades
        if vetor[i-1] < vetor[i] and vetor[i] > vetor[i+1]: # Verifica se é adjacente.
            adjacentes.append(vetor[i]) # Adiciona à lista adjacentes caso seja adjacente.

for i in range(len(vetor)): # Imprime A[0] A[1] A[2] A[3] A[4].
    print('A[{}]'.format(i), end="  ")
print('') # retira o end="" final

for i in range(len(vetor)): # Imprime os valores por baixo.
    print('{}'.format(vetor[i]), end="    ")
print('') # retira o end="" final

print('Valores maiores que os valores adjacentes:',*adjacentes, sep=" ")