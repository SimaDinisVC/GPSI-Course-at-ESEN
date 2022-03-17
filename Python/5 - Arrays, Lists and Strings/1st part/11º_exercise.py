notas = input('Introduza as notas separadas entre espaços: ').split()
restart = True
while restart: # Caso na lista existam valores negativos o programa torna a fazer o cíclo.
    for i in range(len(notas)): 
        notas[i] = int(notas[i]) # Transforma os elementos em inteiro devido ao .split() cortar apenas strings
        if notas[i] < 0: # Verifica se existem valor negativos a medida que o loop for avança.
            print('Introduza valores de 0 a 20.')
            notas.clear() # Se existir ele avisa e limpa a lista toda,              ⇣
            notas = input('Introduza as notas separadas entre espaços: ').split() # E volta a pedir as notas
            restart = True # e ativa o restart para verificar tudo de novo.
            break # quebra o loop for.
        else:
            restart = False # se tudo verificado como positivo ele desativa o restart para que este não aconteça.

for i in range(len(notas)): # Imprime os alunos A[0] A[1] A[2] A[3] A[4].
    print('A[{}] '.format(i), end="")
print('') # retira o end="" final
for i in range(len(notas)): # Imprime as notas dos alunos por baixo.
    if notas[i]> 9: # Serve para manter a formatação da impressão pois em nº com 2 algarismo tem de se retirar um espaço no end=""
        print('{}'.format(notas[i]), end="   ")
    else:
        print('{}'.format(notas[i]), end="    ")
print('') # retira o end="" final

print('Maior diferença = {}'.format(max(notas)-min(notas))) # Imprime a Maior diferença entre notas.

if max(notas)-min(notas) > 10: # Imprime o tipo de turma
    print('Turma Heterogénea')
else:
    print('Turma Homogénea')