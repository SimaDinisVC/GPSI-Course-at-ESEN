import os
def menu():
    print('0 - Sair')
    print('1 - Listar os alunos ou as disciplinas')
    print('2 - Listar as disciplinas inscritas por um determinado aluno')
    print('3 - Acrescentar disciplinas')
    print('4 - Acrescentar alunos')
    print('5 - Retirar um aluno do dicionário')
    print('6 - Eliminar uma disciplina')
    print('7 - Ler o ficheiro')

def listar(l,n): # lista os dados de forma sequencial
    if l != []:
        print('{}: '.format(n),end='')
        print(*l, sep=', ', end='.')
        print('')
    else:
        print('Sem dados de',n.lower())

def search(path): # verifica se o ficheiro existe
    if os.path.isfile(path):
        return False
    else:
        return True
      
def initials(word): # devolve as iniciais da disciplina
        p = list(word.split())
        ini = ''
        for w in p:
            if w.isnumeric():
                ini = w
            elif len(p) == 1:
                ini = w[:3:].upper()
            elif w[0].lower() != 'd' and w[0].lower() != 'e':
                ini += w[0].upper()
        return ini

dict = {23605:['SO']} # dicionário
subj = ['PSI','SO'] # disciplinas
students = [23605] # nºs de processos

while True:
    print('----------')
    menu()
    acao = int(input('- '))
    if acao == 0:
        print('----------')
        exit()
    elif acao == 1:
        loop = True
        while loop: # proteção de IO
            print('----------')
            print('0 - Sair\n1 - Listar alunos\n2 - Listar disciplinas')
            acao = int(input('- '))
            if acao >= 0 and acao <= 2:
                loop = False
            else:
                print('Tem de introduzir um nº compreendido entre 0a2.')
        if acao == 1:
            listar(students,'Alunos')
        if acao == 2:
            listar(subj,'Disciplinas')
    elif acao == 2:
        n = int(input('Introduza o nº de processo a verificar: '))
        if n in dict.keys(): # verifica se o aluno está no dicionário
            listar(dict[n],'Disciplinas')
        else:
            print('Tem de introduzir um nº de processo válido.')
    elif acao == 3:
        s = input('Introduza os nomes completos das disciplinas separados por um "; ": ').split("; ")
        for d in s:
            ini = initials(d)
            if ini not in subj: # verifica se a disciplina não é conhecida
                subj.append(ini)
            else:
                print('A disciplina {0} já existe com as iniciais {1}.'.format(d,ini))
        print('Apenas as novas disciplinas acrescentadas com sucesso!')
    elif acao == 4:
        n = list(map(int, input('Introduza o nºs dos processos separados por espacos: ').split()))
        for a in n:
            if len(str(a)) != 5: # verifica se o nº de processo tem 5 algarismo 
                print('O a{} não tem 5 algarismos.'.format(a))
            elif a in students: # e não está em students
                print('O a{} já foi acrescentado.'.format(a)) 
            else:
                students.append(a) # mas adiciona sempre os nºs de processos válidos
            print('Apenas os novos alunos acrescentados com sucesso!')
    elif acao == 5:
        n = int(input('Introduza o nº do processo do aluno: '))
        if len(str(n)) != 5: # verifica se o nº de processo tem 5 algarismo 
                print('O a{} não tem 5 algarismos.'.format(a))
        elif n not in dict: # e não está no dicionário
            print('O a{} não é valido.'.format(n)) 
        else:
            dict.pop(n)
            print('a{} removido com sucesso!'.format(n))
    elif acao == 6:
        s = input('Introduza o nome da disciplina: ')
        s = initials(s) # vai buscar as iniciais por exemplo(Sistemas Operativos retorna SO)
        while s not in subj: # Verifica se não existe nas subj se n ele faz loop
            print('Disciplina não existente.')
            s = input('Introduza o nome da disciplina: ')
            s = initials(s)
        subj.pop(subj.index(s))
        rm = []
        for k in dict: # itera as chaves do dict
            if s in dict[k]: 
                dict[k].pop(dict[k].index(s)) # retira a disciplina caso ela exista em nos nºs de processos do dict
                if dict[k] == []: # se ficar uma lista vazia adiciona numa lista a chave para depois ser removida visto que não podemos remover elementos enquanto estiver em iteração
                    rm.append(k)
        for i in rm:
            dict.pop(i) # remove os nºs de processos com lista vazia
        print('Disciplina de {} removido com sucesso!'.format(s))
    elif acao == 7:
        print('Formato do Ficheiro: "Nºprocesso : Disci1; Disci2"') # modelo do ficheiro
        c = input('Introduza o caminho absoluto do ficheiro: ')
        while search(c): # proteção caso n seja encontrado o ficheiro
            print('Ficheiro não encontrado!')
            c = input('Introduza o caminho absoluto do ficheiro: ')
        # LEITURA DO FICHEIRO
        f = open(c)
        lines = []
        for l in f.readlines():
            lines.append(l)
        f.close()
        ##################
        for l in lines:
            n,s = l.split(' : ') # separa o nº de processo e as disciplinas
            n = int(n) # passa o nº de processo para inteiro
            s = list(s.split('; ')) # separa as disciplinas e coloca numa lista
            if len(str(n)) == 5: # os nºs de processo tem de ter 5 algarismos
                if n not in dict: # cria a chave do nº de processo com uma lista vazia caso n exista
                    dict[n] = [] 
                if n not in students: # caso o nº de processo não seja conhecido ele adiciona
                    students.append(n)
            else:
                print('Todos os nºs de processos necessitam de ter 5 algarismos') # caso não tenham faz um brake
                break
            for i in s: # itera as disciplinas
                if initials(i) not in dict[n]: # vai ao dicionário ao nº de processo e adiciona as suas disciplinas caso não estiverem lá
                    dict[n].append(initials(i))
                if initials(i) not in subj: # caso as disciplinas não sejam conhecidas ele adiciona
                    subj.append(initials(i))
    else:
        print('Tem de introduzir um nº compreendido entre 0a7.')