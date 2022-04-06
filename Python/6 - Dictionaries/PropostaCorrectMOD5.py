# Zona das Funções
def menu():
    print('|Menú|')
    print('0 - Sair')
    print('1 - Mostrar o nº de visitas dado o código')
    print('2 - Adicionar 1 visita dado o código')
    print('3 - Mostrar as cidades mais visitadas')
    print('4 - Registar contacto')

def verificacao():
    codigo = int(input('Introduza o código do cliente: '))
    while codigo not in contactos.keys(): # Verifica se ele não está nos contactos
        print('Tem que introduzir um código exitente.')
        acao = int(input('0 - Sair do Programa\n1 - Verificar os códigos existentes\n2 - Adicionar novamente\n- '))
        if acao == 0:
            exit()
        elif acao == 1: 
            print('Códigos de Clientes: ',end="")
            print(*contactos.keys(), sep=", ", end=".") # Mostra os códigos separados por , 
            print()
        elif acao == 2:
            codigo = int(input('Introduza o código do cliente: '))
        else:
            print('Tem de introduzir um nº de 0a2.')
    return codigo
# Zona Principal

contactos = {123:['Carlos','Viseu',22], 245:['Paula','Viseu',44], 678:['Filipa','Porto',67], 804:['Rui','Lisboa',35], 1007:['Fernando','Porto',165]}

while True:
    menu() # Chama o menu
    acao = int(input('- '))
    if acao == 0:
        exit()
    elif acao == 1:
        codigo = verificacao() # Pede o código verificado
        print('O cliente visitou {} vezes a nossa loja.'.format(contactos[codigo][2])) # Verifica as visitas  
    elif acao == 2:
        codigo = verificacao() # Pede o código verificado
        contactos[codigo][2] += 1 # Adiciona mais um às visitas
    elif acao == 3:
        visitas = {} # Guarda o nome das cidades segundo as suas visitas.
        for v in contactos.values():
            visitas[v[1]] = visitas.get(v[1],0) + v[2] # Adiciona as Cidades com as Visitas sumadas
        if list(visitas.values()).count(max(visitas.values())) == 1: # Verifica se existe apenas um valor máximo.
            visitas = {v: k for k, v in visitas.items()} # Reverte o dicionário visitas para que possa chamar a cidades perante a chave ser o valor máximo
            print('A cidade mais visitada foi {}.'.format(visitas[max(visitas.keys())]))
        else:
            cidadesEmpatadas = [] # Guarda as Cidades que tem o valor máximo igual.
            for k in visitas.keys():
                if visitas[k] == max(visitas.values()): # Compara todos os valores das chaves e guarda as chaves(cidades) que tem valor igual ao máximo.
                    cidadesEmpatadas.append(k)
            print('Ocorreu um empate entre ',end="")
            print(*cidadesEmpatadas, sep=", ", end=".") # Mostra as cidades separados por ,
            print()
            cidadesEmpatadas.clear() # Limpa para a próxima verificação
        visitas.clear() # Limpa para a próxima verificação
    elif acao == 4:
        codigo = int(input('Introduza o codigo do cliente: '))
        while codigo in contactos.keys(): # Verifica o código (não usei a outra função pois aqui quero verificar se ele está nos contactos)
            print('Tem que introduzir um código ainda não exitente.')
            acao = int(input('0 - Sair do Programa\n1 - Verificar os códigos existentes\n2 - Adicionar novamente\n- '))
            if acao == 0:
                exit()
            elif acao == 1: 
                print('Códigos de Clientes: ',end="")
                print(*contactos.keys(), sep=", ", end=".") # Mostra os códigos separados por , 
                print()
            elif acao == 2:
                codigo = int(input('Introduza o codigo do cliente: '))
            else:
                print('Tem de introduzir um nº de 0a2.')
        nome = input('Introduza o nome do cliente: ')
        localidade = input('Introduza a localidade do cliente: ')
        nvezes = int(input('Introduza o nº de vezes que o cliente visitou a loja (tendo em conta a visita de registo): '))
        while nvezes < 1:
            print('O numero de vezes tem de ser positivo.')
            nvezes = int(input('Introduza o nº de vezes que o cliente visitou a loja (tendo em conta a visita de registo): '))
        contactos[codigo] = [nome, localidade, nvezes]
        print('Contacto Registado')
    else:
        print('Tem de introduzir um nº de 0a4.')