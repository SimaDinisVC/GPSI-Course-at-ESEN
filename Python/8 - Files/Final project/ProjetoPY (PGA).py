# developing
import os

def search(path): # verifica se o ficheiro existe
    if os.path.isfile(path):
        return False
    else:
        return True
      
def menu():
    print("---Programa de Gestão de Autocarros---")
    print('0 - Sair')

def conversorHoras(h,mode):
    if mode == 0 and type(h) is float():
        a=0 #HERE


def listar(l,w): # lista os dados list de forma sequencial
    if l != []:
        print('{}: '.format(w),end='')
        print(*l, sep=', ', end='.')
        print('')
    else:
        print('Sem dados de',w.lower())
    
autocarros = {} # int(Nº do autocarro) : {Trajeto tuple(Conjunto de Nºs das paragens) : list[Horas - [inicio,fim], "Nome do Motorista"]}
motoristas = {} # "Nome do Motorista" : Horário do Motorista list[11:[tuple(Conjunto de Nºs das paragens)]]
paragens = {} # int(Nº da Paragem) : "Nome da Paragem"
trajetos = {} # tuple(Conjunto de Nºs das paragens) : ["Nome da linha do autocarro", tempo de demora do trajeto a ser percorrido int()]