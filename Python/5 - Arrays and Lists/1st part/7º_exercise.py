#Zona das Funções
def repeticao(inscricao, lotes): # Esta função foi criada para fazer um loop enquanto o lote escolhido estiver ocupado.
    while lotes[inscricao-1] == True:
        inscricao = int(input('Introduza o nº do lote prentendido: '))
        while inscricao < 1 or inscricao > 20: # Proteção do input
            print('Têm que introduzir um nº compreendido entre 1 e 20.')
            inscricao = int(input('Introduza o nº do lote prentendido: '))
        if lotes[inscricao-1] == False: # Aqui é quando volta para o programa principal
            print('Inscrição com sucesso!')
            lotes[inscricao-1] = True
            lugares(lotes)
            break # Tive que usar o break pois estou a defenir na linha 10 que o loot escolhido vai ser ocupado e o loop assume isso como verdade na proxima rodada o que faz com que seja um cíclo infinito.
        else:
            print('O nº do lote escolhido já está ocupado. Introduza outro lote.')
            lugares(lotes) # Dá a info dos lotes disponíveis ao utilizador
    return lotes # Retorna ao programa principal o lote novo ocupado
def lugares(lotes):
    lotesDis = []
    cont = lotes.count(False)
    if cont > 1: # Foi criado este if por questões de português no caso de ser > 1 a frase fica no plural
        for i in range(len(lotes)):
            if lotes[i] == False: # Verifica em toda a lista
                lotesDis.append(i+1) # Retira o lote que está disponível
        print('Têm ainda Disponivel',cont,'lotes sendo eles o lote ',end="") # Informa quantos lotes estão disponíveis no total
        print(*lotesDis, sep = ', o lote ', end = '.\n') # Informa ao utilizador quais são os lotes disponíveis
    elif cont == 1: # Foi criado este elif apenas por questões de português no caso de ser 1 a frase fica no singular
        for i in range(20):
            if lotes[i] == False:
                lotesDis.append(i+1)
        print('Têm ainda Disponivel',cont,'lote sendo ele o lote ',end="")
        print(*lotesDis, sep = ', o lote ', end = '.\n')
#Zona Principal
lotes = []
for v in range(20): # Vai adicionar à lista os lotes livres
    lotes.append(False)
for i in range(20):
    inscricao = int(input('Introduza o nº do lote prentendido: '))
    while inscricao < 1 or inscricao > 20: # Proteção do input
        print('Têm que introduzir um nº compreendido entre 1 e 20.')
        inscricao = int(input('Introduza o nº do lote prentendido: '))
    if lotes[inscricao-1] == False: # Quando entra aqui o loot escolhido vai ser ocupado na lista.
        print('Inscrição com sucesso!')
        lotes[inscricao-1] = True
        lugares(lotes) # Dá a info dos lotes disponíveis ao utilizador
    else:
        print('O nº do lote escolhido já está ocupado. Introduza outro lote.')
        lugares(lotes) # Dá a info dos lotes disponíveis ao utilizador
        lotes = repeticao(inscricao, lotes)  #  Um loop enquanto o lote escolhido estiver ocupado.
print('Inscrições concluidas!\nNão se esqueça de no final pagar os 10 créditos ao programador!;)')