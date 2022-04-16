from datetime import datetime # Livraria para a data e hora do sistema
# Zona das Funções

def menu():
    print('0 - Sair')
    print('1 - Nova Entrada')
    print('2 - Destritos mais concorridos')
    print('3 - Periodos do dia mais concorridos')

def inicializacao(sep, dado): 
    if sep not in dado: 
        da, do = sep, sep # Coloquei 'sep' para não dar erro na condição do while e apenas para não ser numérico.
    else:
        da, do = dado.split(sep)
    return da, do

# Zona Principal

lista_Dict = [
    {'postal':'3510-070', 'valorCompra':80, 'hora':'11:25', 'data':'04-04-2022'},
    {'postal':'1100-070', 'valorCompra':81, 'hora':'13:25', 'data':'04-04-2022'},
    {'postal':'3510-070', 'valorCompra':80, 'hora':'13:25', 'data':'04-04-2022'}
]

destritos = {
    (10,11,12,13,14,15,16,17,18,19,26,27):'Lisboa',
    (20,22,23):'Santarém',
    (24,25,31):'Leiria', 
    (28,29,75):'Setúbal', 
    (30,32,33,34):'Coimbra', 
    (35,36,51):'Viseu', 
    (37,38,45):'Aveiro', 
    (40,41,42,43,44,46):'Porto', 
    (47,48):'Braga', 
    (49,):'Viana do Castelo', 
    (0,54):'Vila Real', 
    (52,53):'Bragança', 
    (60,61,62):'Castelo Branco', 
    (63,64):'Guarda', 
    (70,71,72):'Évora', 
    (73,74):'Portalegre', 
    (76,77,78,79):'Beja', 
    (80,81,82,83,84,85,86,87,88,89):'Faro', 
    (90,91,92,93,94):'Madeira', 
    (95,96,97,98,99):'Açores'
}

periodos = {(6,11):'Manhã', (12,14):'Meio-Dia', (15,18):'Tarde', (19,23):'Noite', (0,5):'Madrugada'}

while True:
    print('---------------') # Apenas por questões de separação
    menu()
    acao = int(input('- '))
    print('---------------') # Apenas por questões de separação
    if acao == 0:
        exit()
    elif acao == 1:
        ########################## POSTAL ############################
        postal = input('Introduza o código-postal (0000-000): ')
        # Proteção e Validação de dados para o código-postal
        pos, tal = inicializacao('-', postal)
        while pos.isnumeric() == False or tal.isnumeric() == False or '-' not in postal or len(pos) != 4 or len(tal) != 3:
            print('Tem de introduzir o código-postal da seguinta forma 0000-000.')
            postal = input('Introduza o código-postal (0000-000): ')
            if '-' in postal:
                pos, tal = postal.split('-')

        ###################### Valor da Compra #######################
        valorCompra = int(input('Introduza o valor da compra: '))
        # Proteção para o valor da compra
        while valorCompra <= 0: 
            print('O valor da compra tem que ser maior do que 0.')
            valorCompra = int(input('Introduza o valor da compra: '))

        ########################### HORA #############################
        hora = input('Introduza a hora e os minutos (hh:mm): ')
        if hora == "": # Caso nada for colocada ele mete a hora do sistema
            hora = datetime.now().strftime('%H:%M')
        else:
            # Proteção e Validação de dados para a hora
            h, m = inicializacao(':', hora)
            while h.isnumeric() == False or m.isnumeric() == False or ':' not in hora or len(h) != 2 or len(m) != 2 :
                print('Tem de introduzir a hora da seguinta forma hh:mm.')
                hora = input('Introduza a hora e os minutos (hh:mm): ')
                if ':' in hora:
                    h, m = hora.split(':')
                    
        ########################### DATA #############################
        data = input('Introduza o dia o mês e o ano (dd-mm-aaaa): ')
        if data == "": # Caso nada for colocada ele mete a data do sistema
            data = datetime.now().strftime('%d-%m-%Y')
        else:
            # Proteção e Validação de dados para a data
            if '-' not in data: 
                d, m, a = '-', '-' # Coloquei 'sep' para não dar erro na condição do while e apenas para não ser numérico.
            else:
                d, m, a = data.split('-')
            while d.isnumeric() == False or m.isnumeric() == False or a.isnumeric() == False or '-' not in data or len(d) != 2 or len(m) != 2 or len(a) != 4:
                print('Tem de introduzir a data da seguinta forma dd-mm-aaa.')
                data = input('Introduza o dia o mês e o ano (dd-mm-aaaa): ')
                if '-' in data:
                    d, m, a = data.split('-')

        #################### Adicionar à LISTA #######################
        lista_Dict.append(dict([['postal',postal],['valorCompra',valorCompra],['hora',hora],['data',data]]))

    elif acao == 2:
        comprasDestritos = {} # Guarda os Destritos em função das compras

        for d in lista_Dict:
            postal = int(d['postal'][0] + d['postal'][1])
            for k in destritos.keys():
                if postal in k:
                    comprasDestritos[destritos[k]] = comprasDestritos.get(destritos[k], 0) + d['valorCompra']

        comprasDestritos = {v: k for k, v in comprasDestritos.items()} # Troca a chave pelo valor e vice versa.
        comprasOrder = sorted(comprasDestritos, key = lambda k:k, reverse=True) # Utilizei o reverse para ordenar do forma decrescente
        
        for i in range(len(comprasDestritos)):
            print('{}º - {} : {}€ faturados'.format(i+1, comprasDestritos[comprasOrder[i]], comprasOrder[i]))
        
        comprasDestritos.clear()

    elif acao == 3:
        comprasPeriodos = {} # Guarda os Periodos em função das compras

        for d in lista_Dict:
            hora = int(d['hora'][0] + d['hora'][1])
            for k in periodos.keys():
                if hora >= k[0] and hora <=k[1]:
                    comprasPeriodos[periodos[k]] = comprasPeriodos.get(periodos[k], 0) + d['valorCompra']

        comprasPeriodos = {v: k for k, v in comprasPeriodos.items()} # Troca a chave pelo valor e vice versa.
        comprasOrder = sorted(comprasPeriodos, key = lambda k:k, reverse=True) # Utilizei o reverse para ordenar do forma decrescente
        
        for i in range(len(comprasPeriodos)):
            print('{}º - {} : {}€ faturados'.format(i+1, comprasPeriodos[comprasOrder[i]], comprasOrder[i]))
        
        comprasPeriodos.clear()

    else:
        print('Tem de introduzir um nº compreendido entre 0a4.')