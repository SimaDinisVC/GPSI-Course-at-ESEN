# Developing
import os
def search(path): # verifica se o ficheiro existe e retorna boll para ciclos
    if os.path.isfile(path):
        return False
    else:
        return True

def menu():
    print("0 - Sair")
    print("1 - Inserir novo aluno")
    print("2 - Consultar notas do aluno")

print("- Programa de acesso de notas -")

print('Formato do ficherio: "Nº - Nome"')
path_turmas = input('Introduza o caminho absuluto do ficheiro da turma:')
while search(path_turmas):
    print('Ficheiro não encontrado!')
    path_turmas = input('Introduza o caminho absuluto do ficheiro da turma: ')

print('Formato do ficherio: "Nº - Nota"')
path_notas = input('Introduza o caminho absuluto do ficheiro da turma:')
while search(path_notas):
    print('Ficheiro não encontrado!')
    path_notas = input('Introduza o caminho absuluto do ficheiro da turma: ')

while True:
    print('----------')
    menu()
    acao = int(input('- '))    
    if acao == 0:
        print('----------')
        exit()
    elif acao == 1:
        nome, num, nota = input('Introduza o "nome numero nota": ')
        f_turmas = open(path_turmas, "a+") # a+ = ler e acrescentar
        notinfile = True
        for l in f_turmas:
            n, name = l.split(" - ")
            if n == num:
                notinfile = False
                print('Nº já existente.')
                break
        if notinfile: # se não estiver no ficheiro adiciona em turmas.txt
            f_turmas.write("{0} - {1}".format(num, nome))
        f_turmas.close()
        if notinfile: # se não estiver no ficheiro adiciona em notas.txt
            f_notas =  open(path_turmas, "a")
            f_notas.write("{0} - {1}".format(num, nota))
    elif acao == 2:
        n = input("Introduza o nº ou o nome do aluno: ")
        if n.isnumeric():
            f_turmas = open(path_turmas)
            for l in f_turmas:
                num, name = l.split(" - ")
                if n == num:
                    n = nome
            if n.isnumeric():
                print("Nome não encontrado")
        f_notas = open(path_notas)
        for l in f_turmas:
            n, name = l.split(" - ")
            if n == num: