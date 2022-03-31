# Zona das Funções
def menu():
    print('|Menú|')
    print('0 - Sair')
    print('1 - Mostrar o nº de visitas dado o código')
    print('2 - Adicionar 1 visita dado o código')
    print('3 - Mostrar as cidades mais visitadas')
    print('4 - Registar contacto')
# Zona Principal
dict = {123:['Carlos','Viseu',22], 245:['Paula','Viseu',44], 678:['Filipa','Porto',67], 804:['Rui','Lisboa',35], 1007:['Fernando','Porto',165]}

while True:
    menu() # Chama o menu
    acao = int(input('- '))
    if acao == 0:
        exit()
    elif acao == 1:
        codigo = int(input('Introduza o código do cliente:'))
        print('O cliente visitou {} vezes a nossa loja.'.format(dict[codigo][2])) # Verifica as visitas
    elif acao == 2:
        codigo = int(input('Introduza o código do cliente: '))
        dict[codigo][2] += 1 # Adiciona mais um às visitas
    elif acao == 3:
        cidades = {}
        max_values =[]
        max_keys = []
        empate = []
        for c in dict.values():
            cidades[c[1]] = cidades.get(c[1], 0) + c[2]
        for v in cidades.values():
            max_values.append(v)
        for k in cidades.keys():
            max_keys.append(k)
        max_valueI = max_values.index(max(max_values))
        if max_values.count(max(max_values)) > 1:
            for i in max_values:
                if max(max_values) == i:
                    empate.append(max_values.index(i))
            print('Ocorreu um empate entre ',)
            print()
        else:
            print('A cidade mais visitada foi {}.'.format(max_keys[max_valueI])) # Verifica a moda da lista com as cidades
    elif acao == 4:
        codigo = int(input('Introduza o codigo do cliente: '))
        if codigo not in dict.keys():
            nome = input('Introduza o nome do cliente: ')
            localidade = input('Introduza a localidade do cliente: ')
            nvezes = int(input('Introduza o nº de vezes que o cliente visitou a loja (tendo em conta a visita de registo): '))
            dict[codigo] = [nome, localidade, nvezes]
            print('Contacto Registado')
        else:
            print('Tem que introduzir um código ainda não exitente.')
            acao = int(input('0 - Sair do Programa\n1 - Verificar os códigos existentes\n2 - Adicionar novamente\n- '))
            if acao == 0:
                exit()
            elif acao == 1: 
                print('Códigos de Clientes: ',end="")
                print(*dict.keys(), sep=", ", end=".") # Mostra os códigos separados por , 
                print()
            elif acao == 2:
                continue
            else:
                print('Tem de introduzir um nº de 0a2.')
    else:
        print('Tem de introduzir um nº de 0a4.')