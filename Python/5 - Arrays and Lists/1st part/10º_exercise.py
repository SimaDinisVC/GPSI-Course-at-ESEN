faltas = [] 
jogadores = []
jogadores5 = []
avisos7 = 7
loop = True

while loop:
    falta = int(input('Introduza o nº de jogador que realizou falta: '))
    if falta == 0: # Verfica sempre a saida do programa em 1º lugar.
        loop = False
    elif falta not in jogadores: # Aqui vai adicionar um novo jogador não conhecido no programa na lista jogadores e adiciona 1 falta por predefinição na lista faltas sempre com o index comum nas duas listas.
        jogadores.append(falta)
        faltas.append(1)
    else: # Aqui ele entra só quando o jogador já é conhecido na base de dados
        faltas[jogadores.index(falta)] += 1 # e vai somando falta ao index do jogador na lista faltas. (pois os index da lsita(jogadores e lista faltas são comuns.)
        for i in faltas: # Verifica uma vez por jogador se está com 5 faltas e avisa a mesa.
            indice = faltas.index(i)
            if i == 5 and jogadores[indice] not in jogadores5:
                print("O jogador {} atingiu as cinco faltas.".format(jogadores[indice]))
                jogadores5.append(jogadores[indice])
        if sum(faltas) == avisos7: # Verifica se a equipa somou 7 faltas.
            if avisos7 == 7:
                print("A equipa somou 7 faltas.")
                avisos7 *= 2 # Aqui faz o * 2 pois assim muda a variável para próxima vez que a equipa fizer mais 7 faltas e assim a mesa é notificada novamente.
            else: # Questões de português.
                print("A equipa somou mais 7 faltas.")
                avisos7 *= 2

if len(faltas) != 0: 
    for i in range(len(faltas)):
        print("O jogador {0} teve {1} faltas.".format(jogadores[i], faltas[i]))
    print('A equipa acumulou {} faltas.'.format(sum(faltas)))
else:
    print('O programa não encontrou nenhuma falta.')