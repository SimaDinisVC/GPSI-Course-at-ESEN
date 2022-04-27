#####Pilhas#####
def pilha_Pop(pilha):
    try:
        pilha.pop()
        return pilha
    except IndexError:
        print('Não existe mais valores na pilha')  
def pilha_Push(pilha, valor):
    return pilha.append(valor)
def pilha_Seek(pilha):
    try:
        u = pilha[-1]
        return u
    except IndexError:
        print('Não existe mais valores na pilha')
def pilha_Count(pilha):
    return len(pilha)
#####Filas#####
def fila_DeQueue(fila):
    try:
        fila.pop(0)
        return fila
    except IndexError:
        print('Não existe mais valores na fila') 
def fila_EnQueue(fila, valor):
    return fila.append(valor)
def fila_Seek(fila):
    try:
        u = fila[0]
        return u
    except IndexError:
        print('Não existe mais valores na pilha')
def fila_Count(fila):
    return len(fila)

def menu():
    print("----- PILHAS -----")
    print("1 - Remover um elemento da pilha")
    print("2 - Insere um elemento na pilha.")
    print("3 - Devolve o último elemento da pilha sem o retirar")
    print("4 - Devolve o total de elementos na pilha")
    print("-----  FILA  -----")
    print("5 - Remover um elemento da fila")
    print("6 - Insere um elemento na fila.")
    print("7 - Devolve o último elemento da fila sem o retirar")
    print("8 - Devolve o total de elementos na fila")

while True:
    menu()
    acao = int(input("- "))
    print("------------------")
