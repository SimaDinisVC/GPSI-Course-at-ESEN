# Problema: Criar uma lista de dicionários ;
# Restrições no 1: Sempre que alguem faz uma compra na loja regista: código-postal("0000-000"), valor total da compra > 0, hora(hh:mm), dia(DD-MM-AAAA) validar de dados, assumir dia/hora do sistema caso nada for introduzido nesses inputs ;
# Restrições no 2: Criar um dicionário em que a chave c seja os 4 primeiros nºs[0000] do código postal e o valor é o nome da localidade referente ao código 4 nºs ;
# Restrições no 3: A data é dada pelo user tendo em conta uma estrura de periodos determinado pelo programador ;
from datetime import datetime 

# Zona das Funções

def menu():
    print('0 - Sair')
    print('1 - Nova Entrada')
    print('2 - Destritos mais concorridos')
    print('3 - Periodo do dia mais concorrido')

# Zona Principal

lista_Dict = [
    {'postal':'3510-070', 'valorCompra':80, 'hora':'11:25', 'data':'04-04-2022'}
]

destritos = {
    (10,11,12,13,14,15,16,17,18,19,26,27):['Lisboa'],
    (20,22,23):['Santarém'],
    (24,25,31):['Leiria'], 
    (28,29,75):['Setúbal'], 
    (30,32,33,34):['Coimbra'], 
    (35,36,51):['Viseu'], 
    (37,38,45):['Aveiro'], 
    (40,41,42,43,44,46):['Porto'], 
    (47,48):['Braga'], 
    (49,):['Viana do Castelo'], 
    (0,54):['Vila Real'], 
    (52,53):['Bragança'], 
    (60,61,62):['Castelo Branco'], 
    (63,64):['Guarda'], 
    (70,71,72):['Évora'], 
    (73,74):['Portalegre'], 
    (76,77,78,79):['Beja'], 
    (80,81,82,83,84,85,86,87,88,89):['Faro'], 
    (90,91,92,93,94):['Madeira'], 
    (95,96,97,98,99):['Açores']
}

periodos = {(6,11):'Manhã', (12,14):'Meio-Dia', (15,18):'Tarde', (19,23):'Noite', (0,5):'Madrugada'}

while True:
    menu()
    acao = int(input('- '))
    if acao == 0:
        exit()
    elif acao == 1:
        postal = input('Introduza o código postal (0000-000): ')
        while len(postal) != 8: # Proteção Código Postal
            print('Tem de introduzir o - hifen e tudo pegado no código postal.')
            postal = input('Introduza o código postal (0000-000): ')
        valorCompra = int(input('Introduza o valor da compra: '))
        while valorCompra <= 0: # Proteção para o valor de compra
            print('O valor da compra tem que ser maior do que 0.')
            valorCompra = int(input('Introduza o valor da compra: '))
        hora = input('Introduza a hora e os minutos (hh:mm): ')
        if hora == "": # Caso nada for colocada ele mete a hora do sistema
            hora = datetime.now().strftime('%H:%M')
        else:
            while len(hora) != 5: # Proteção para a hora
                print('Tem de introduzir os : e tudo pegado nas horas.')
                hora = input('Introduza a hora e os minutos (hh:mm): ')
        data = input('Introduza o dia o mês e o ano (DD-MM-AAAA): ')
        if data == "": # Caso nada for colocada ele mete a data do sistema
            data = datetime.now().strftime('%d-%m-%Y')
        else:
            while len(data) != 10: # Proteção para a data
                print('Tem de introduzir o - hifen e tudo pegado na data.')
                data = input('Introduza o dia o mês e o ano (DD-MM-AAAA): ')
        lista_Dict.append(dict([['postal',postal],['valorCompra',valorCompra],['hora',hora],['data',data]]))
    elif acao == 2:
        for d in lista_Dict:
            postal = int(d['postal'][0]+d['postal'][1])
            valorCompra
        for i in destritos.keys():
            if postal in i:
                destritos[i].append(destritos.get(i[1], 0) + 1)
        lista_ordenada_localVC = sorted(destritos, key = lambda x: x[1])
        print(lista_ordenada_localVC)
    elif acao == 3:
        continue
    else:
        print('Tem de introduzir um nº compreendido entre 0a4.')