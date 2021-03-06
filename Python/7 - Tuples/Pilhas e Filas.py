def menu():
    print("----- PILHA -----")
    print("1 - Remover um elemento da pilha")
    print("2 - Insere um elemento na pilha")
    print("3 - Devolve o último elemento da pilha sem o retirar")
    print("4 - Devolve o total de elementos na pilha")
    print("----- FILA  -----")
    print("5 - Remover um elemento da fila")
    print("6 - Insere um elemento na fila.")
    print("7 - Devolve o primeiro elemento da fila sem o retirar")
    print("8 - Devolve o total de elementos na fila")

            #####Pilhas#####
def pilha_Pop(pilha):
    try:
        r = pilha.pop()
        return r
    except IndexError:
        print('Não existe mais valores na pilha.')

def pilha_Push(pilha, valor):
    pilha.append(valor)

def pilha_Seek(pilha):
    try:
        u = pilha[-1]
        return u 
    except IndexError:
        print('Não existe mais valores na pilha.')

def pilha_Count(pilha):
    return len(pilha)

            #####Filas#####
def fila_DeQueue(fila):
    try:
        r = fila.pop(0)
        return r
    except IndexError:
        print('Não existe mais valores na pilha.')

def fila_EnQueue(fila, valor):
    fila.append(valor)

def fila_Seek(fila):
    try:
        u = fila[0]
        return u
    except IndexError:
        print('Não existe mais valores na pilha.')

def fila_Count(fila):
    return len(fila)

#Zona Principal

pilha = ['1º','2º','3º','4º','5º','6º','7º','8º','9º','10º']
fila = ['primeiro','segundo','terceiro','quarto','quinto','sexto','sétimo','oitavo','nono','decimo']

while True:
    menu()
    acao = int(input("- "))
    print("------------------")
    if acao == 1:
        r = pilha_Pop(pilha)
        if r != None:
            print("O valor removido da fila foi {}.".format(r))
    elif acao == 2:
        v = input("Introduza o elemento a adicionar: ")
        pilha_Push(pilha, v)
    elif acao == 3:
        u = pilha_Seek(pilha)
        if u != None:
            print("O ultimo valor da pilha é",u)
    elif acao == 4:
        l = pilha_Count(pilha)
        print("A pilha tem {} elementos.".format(l))
    elif acao == 5:
        r = fila_DeQueue(fila)
        if r != None:
            print("O valor removido da fila foi {}.".format(fila.pop(0)))
    elif acao == 6:
        v = input("Introduza o elemento a adicionar: ")
        fila_EnQueue(fila, v)
    elif acao == 7:
        u = fila_Seek(fila)
        if u != None:
            print("O ultimo valor da fila é",u)
    elif acao == 8:
        l = fila_Count(fila)
        print("A pilha tem {} elementos.".format(l))
    else:
        print('Tem de introduzir um nº compreendido entre 0a8.')