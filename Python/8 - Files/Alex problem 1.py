# Developing
import os
def search(path): # verifica se o ficheiro existe
    if os.path.isfile(path):
        return False
    else:
        return True
def menu():
    print("0 - Sair")
    print("1 - Inserir novo aluno")
    print("2 - Consultar notas do aluno")

print('Formato do ficherio: "Nome - Nº"')
path_names = input('Introduza o caminho absuluto do ficheiro da turma:')
while search(path_names):
    print('Ficheiro não encontrado!')
    path_names = input('Introduza o caminho absuluto do ficheiro da turma: ')

print('Formato do ficherio: "Nº - Nota"')
path_notes = input('Introduza o caminho absuluto do ficheiro da turma:')
while search(path_notes):
    print('Ficheiro não encontrado!')
    path_notes = input('Introduza o caminho absuluto do ficheiro da turma: ')

n = {}
with open(path_names) as f:
    r = open(path_notes)
    for l in f:
        name, num = l.split(" - ")
        num = int(num)
        for ll in r:
            num1, note = ll.split(" - ")
            if num1 == num:
                n[num] = list(name, note)
                break


while True:
    print('----------')
    menu()
    acao = int(input('- '))    
    if acao == 0:
        print('----------')
        exit()
    elif acao == 1:
