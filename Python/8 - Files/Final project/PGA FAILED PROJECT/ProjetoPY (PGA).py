# developing
from datetime import date
import os

def search(path): # verifica se o ficheiro existe
    if os.path.isfile(path):
        return False
    else:
        return True

def validar_data(data):
    # (DD/MM/AAAA)
    data_digitada = str(data[6:]+'-'+data[3:5]+'-'+data[0:2])
    while True:
        try:
            verif = date.fromisoformat(data_digitada)
            return True
        except ValueError:
            return False

print(validar_data("31/05/2022"))
      
def menu():
    print("o")
    
def listar(l,w): # lista os dados list de forma sequencial
    if l != []:
        print('{}: '.format(w),end='')
        print(*l, sep=', ', end='.')
        print('')
    else:
        print('Sem dados de',w.lower())

programação = {"31/05/2022" : {234:{"C2":[[11,12, "José Mendes"]]}}} # {int(Nº do autocarro) : {"Nome da linha de trajeto" :  HORARIO DE CADA TRAJETO - list[[inicio, fim, "Nome do Motorista"], ]}
motoristas = {"José Mendes" : [(11,12,234,"C2")]} # "Nome do Motorista" : Horário do Motorista [(11,13,"Nome da linha de trajeto")]
paragens = {12:["Liceu 2", ["C2"]], 13:["Liceu 1", ["C2"]]} # int(Nº da Paragem) : "Nome da Paragem"
trajetos = {"C2": [(12,13),1]} # "Nome da linha de trajeto" : [tuple(Conjunto de Nºs das paragens), tempo de demora do trajeto a ser percorrido int()]

print('---Programa de Gestão de Autocarros---')
sep = "----------"
while True:
    print('0 - Sair')
    print('1 - Consultar Informação')
    print("2 - Adicionar/Atualizar Informação")
    print('3 - Remover Informação')
    print('4 - Salvar Dados')
    acao = int(input("- "))
    if acao == 0:
        exit()
    elif acao == 1:
        print('---CONSULTAR---')
        print('0 - Voltar')
        print('1 - Programações de autocarros')
        print('2 - Programações de motoristas')
        print('3 - Programações de trajetos')
        print('4 - Programação personalizada')
        acao = int(input("- "))
        if acao == 0:
            continue
        elif acao == 1:
            print('0 - Listar todas as programações')
            autocarro = int(input("Introduza o nº de série do autocarro: "))
            if autocarro == 0:
                for n_auto in programação: # Percorre os nºs de autocarros
                    dataDici = programação[n_auto]
                    for linha in dataDici: # Percorre as linhas de trajetos
                        dadosPROG = dataDici[linha]
                        for info in dadosPROG: # Percorre os resto da informação
                            print("Linha {0} | Autocarro: {1} | Horário: {2}h - {3}h | Motorista: {4}".format(linha, n_auto, info[0], info[1], info[2]))
            else:
                dataDici = programação.get(autocarro, False) # Verifica se o autocarro é conhecido
                if dataDici == False:
                    print('Nº de autocarro não consta na base de dados.')
                else:
                    for linha in dataDici:
                        dadosPROG = dataDici[linha]
                        for info in dadosPROG:
                            print("Linha {0} | Autocarro: {1} | Horário: {2}h - {3}h | Motorista: {4}".format(linha, autocarro, info[0], info[1], info[2]))      
        elif acao == 2:
            print('0 - Listar todas as programações')
            nome = input("Introduza o Primeiro & Último nome do motorista: ").title()
            if nome == '0':
                for nomes in motoristas:
                    horario = motoristas[nomes]
                    for info in horario:
                        print("Motorista: {4} | Horário: {0}h - {1}h | Linha {3} | Autocarro: {2}".format(info[0], info[1], info[2], info[3], nomes))
            else:
                horario = motoristas.get(nome, False) # Verifica se o motorista é conhecido
                if horario == False:
                    print('O nome inserido não consta na base de dados.')
                else:
                    for info in horario:
                        print("Motorista: {4} | Horário: {0}h - {1}h | Linha {3} | Autocarro: {2}".format(info[0], info[1], info[2], info[3], nome))
        elif acao == 3:
            print(sep)
            print('0 - Voltar')
            print('1 - Trajeto/Paragens de uma linha de transporte')
            print('2 - Tempo de uma linha de transporte')
            print('3 - Verificar as linhas de transporte de uma paragem')
            acao = int(input("- "))
            if acao == 0:
                continue
            elif acao == 1:
                linha = input("Introduza a linha de transporte: ").upper()
                dadosLinha = trajetos.get(linha, False)
                if dadosLinha == False:
                    print('A linha inserida não consta na base de dados.')
                else:
                    print('Trajeto ', end="")
                    for paragem in dadosLinha[0]:
                        print('-> {0}: {1} '.format(paragem, paragens[paragem][0]), end="")
                    print("")
            elif acao == 2:
                print('0 - Listar todas as programações')
                linha = input("Introduza a linha de transporte: ").upper()
                if linha == '0':
                    for linhas in trajetos:
                        dadosLinha = trajetos[linhas]
                        print("Linha {0} | Tempo: {1}h".format(linhas,dadosLinha[1]))
                else:
                    dadosLinha = trajetos.get(linha, False)
                    if dadosLinha == False:
                        print('A linha inserida não consta na base de dados.')
                    else:
                        print("Linha {0} | Tempo: {1}h".format(linha,dadosLinha[1]))
            elif acao == 3:
                paragem = input('Introduza o nº ou nome de uma paragem: ').title()
                if paragem.isdigit():
                    paragem = int(paragem)
                    dadosParagem = paragens.get(paragem, False)
                    if dadosParagem == False:
                        print('A paragem inserida não consta na base de dados.')
                    else:
                        print('Paragem {0}-{1} - Linhas de Transporte: '.format(paragem,dadosParagem[0]), end="")
                        print(*dadosParagem[1], sep=", ", end=".")
                        print("")
                else:
                    v = False
                    for n in paragens:
                        if paragens[n][0] == paragem:
                            v = True
                            print('Paragem {0}-{1} - Linhas de Transporte: '.format(n,paragens[n][0]), end="")
                            print(*paragens[n][1], sep=", ", end=".")
                            print("")
                    if v == False:
                        print('A paragem inserida não consta na base de dados.')
            elif acao == 4:
                a = 0 # TAREFA: Apresentar Filtros de dados que a pessoa possa ter e colocar em hipotesses
    elif acao == 2:
        print('0 - Voltar')
        print('1 - Adicionar/Atualizar programação ')
        print('2 - Adicionar motorista')
        print('3 - Atualizar horário ou turno de um motorista')
        print('4 - Adicionar nova paragem')
        print('5 - Adicionar/Atualizar trajeto')
        acao = int(input("- "))
        if acao == 0:
            continue
        #elif acao == 1:
            
