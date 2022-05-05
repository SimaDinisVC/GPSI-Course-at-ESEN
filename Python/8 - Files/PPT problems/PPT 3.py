import os
def menu():
    print("0 - Sair")
    print("1 - Listar os alunos ou as disciplinas")
    print("2 - Listar as disciplinas inscritas por um determinado aluno")
    print("3 - Acrescentar disciplinas")
    print("4 - Acrescentar alunos")
    print("5 - Retirar um aluno do dicionário")
    print("6 - Eliminar uma disciplina")
    print("7 - Ler o ficheiro")

def search(path):
    if os.path.exists(path):
        return True
    else:
        return False
    
def reader(path,dict,subj,students):
    if search(path):
        with open(path) as f:
            for l in f.readlines():
                n,s = l.split(";")
                students.append(n)
                subj.append(s)
                dict[n] = dict.get(n,[]).append(s)
    else:
        print("O ficheiro não existe!")

dict = {}
subj = []
students = []

while True:
    print("----------")
    menu()
    acao = int(input("- "))
    if acao == 0:
        exit()
    elif acao == 1:
        print("0 - Sair\n1 - Listar alunos\n2 - Listar disciplinas")
        if acao == 0:
            exit()
        elif acao == 1:
            print("Disciplinas: ",end="")
            print(*students, sep=", ", end=".")