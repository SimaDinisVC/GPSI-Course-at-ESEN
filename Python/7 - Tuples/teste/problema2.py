def menu():
    print("0 - Sair")
    print("1 - Nova reserva")
    print("2 - Chamar o cliente")

fila_espera = []

while True:
    print("----------------")
    print("Nº de Clientes em fila de espera:",len(fila_espera))
    menu()
    acao = int(input("- "))
    print("----------------")
    if acao == 0:
        if len(fila_espera) != 0:
            print("Ainda tem clientes na fila de espera.\nQuer mesmo fechar?\n0 - Sim\n1 - Não")
            acao1 = int(input("- "))
            if acao1 == 0:
                exit()
            elif acao1 == 1:
                continue
            else:
                print('Tem de introduzir um nº compreendido entre 0a1.')
        else:
            exit()
    elif acao == 1:
        nome = input("Introduza o nome do cliente: ")
        fila_espera.append(nome)
        print(nome,"foi adicionado à lista de espera.")
    elif acao == 2:
        try:
            print("Pode entrar:",fila_espera[0])
            fila_espera.pop(0)
        except:
            print('Não existe pessoas em lista de espera.')
    else:
        print('Tem de introduzir um nº compreendido entre 0a2.')