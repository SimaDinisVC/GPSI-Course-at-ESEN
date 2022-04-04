# Problema: Criar uma lista de dicionários ;
# Restrições no 1: Sempre que alguem faz uma compra na loja regista: código-postal("0000-000"), valor total da compra > 0, hora(hh:mm), dia(DD-MM-AAAA) validar de dados, assumir dia/hora do sistema caso nada for introduzido nesses inputs ;
# Restrições no 2: Criar um dicionário em que a chave de código postal dos 4 primeiros nºs[0000] e o valor é o nome da localidade referente ao código 4 nºs ;
# Restrições no 3: A data é dada pelo user tendo em conta uma estrura de periodos determinado pelo programador ;
from datetime import datetime 

def menu():
    print('0 - Sair')
    print('1 - Nova Entrada')
    print('2 - Lista ordenada das nome das localidades por total de compras')
    print('3 - Mostrar o periodo do dia com mais volume de compras')

while True:
    menu()
    acao = int(input('- '))
    if acao == 0:
        exit()
    elif acao == 1:
        postal = input('Introduza o código postal (0000-000): ')
        while len(postal) != 8:
            print('Tem de introduzir o - hifen e tudo pegado no código postal.')
            postal = input('Introduza o código postal (0000-000): ')
        valorCompra = int(input('Introduza o valor da compra: '))
        while valorCompra <= 0:
            print('O valor da compra tem que ser maior do que 0.')
            valorCompra = int(input('Introduza o valor da compra: '))
        hora = input('Introduza a hora e os minutos (hh:mm) : ')
        if hora == "":
            hora = datetime.now().strftime('%H:%M')
        elif len(hora) != 5:
            print('Tem de introduzir o : hifen e tudo pegado nas horas.')
            hora = input('Introduza a hora e os minutos (hh:mm) : ')
        data = input('Introduza o dia o mês e o ano (DD-MM-AAAA)')
        if data == "":
            data = datetime.now().strftime('%d:%M:%Y')
        elif len(data) != 10:
            print('Tem de introduzir o : hifen e tudo pegado na data.')
            data = input('Introduza o dia o mês e o ano (DD-MM-AAAA)')
        print(postal,valorCompra,hora,data)