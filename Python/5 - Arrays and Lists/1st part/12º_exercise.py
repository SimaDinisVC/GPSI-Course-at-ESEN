altura = input('Introduza as notas separadas entre espaços: ').split()
restart = True
while restart: # Caso na lista existam valores negativos o programa torna a fazer o cíclo.
    for i in range(len(altura)): 
        altura[i] = float(altura[i]) # Transforma os elementos em reais devido ao .split() cortar apenas strings
        if altura[i] < 0: # Verifica se existem valor negativos a medida que o loop for avança.
            print('Introduza valores de 0 a 20.')
            altura.clear() # Se existir ele avisa e limpa a lista toda,              ⇣
            altura = input('Introduza as notas separadas entre espaços: ').split() # E volta a pedir as notas
            restart = True # e ativa o restart para verificar tudo de novo.
            break # quebra o loop for.
        else:
            restart = False # se tudo verificado como positivo ele desativa o restart para que este não aconteça.

for i in range(len(altura)): # Imprime os voluntários A[0] A[1] A[2] A[3] A[4].
    print('A[{}]'.format(i), end="  ")
print('') # retira o end="" final
for i in range(len(altura)): # Imprime as altura dos alunos por baixo.
    print('{0:.2f}'.format(altura[i]), end="  ")
print('') # retira o end="" final

voluntario = [0, 0]
menor_dif = 2000000000
conto = -1
for o in altura:
    conto += 1
    conti = -1
    for i in altura:
        conti += 1
        if abs(i-o) != 0:
            if abs(i-o) < menor_dif:
                menor_dif = abs(i-o)
                if i < o:
                    voluntario[0] = conti
                    voluntario[1] = conto
                else:
                    voluntario[0] = conto
                    voluntario[1] = conti
menor_dif *= 100 # Transforma metro para cm.
menor_dif = int(menor_dif)
print("menor diferença = {}cm.".format(menor_dif))
print("Voluntários {0} e {1}".format(voluntario[0],voluntario[1]))