# Problema: Criar uma lista de dicionários ;
# Restrições no 1: Sempre que alguem faz uma compra na loja regista: código-postal("0000-000"), valor total da compra > 0, hora(hh:mm), dia(DD-MM-AAAA) validar de dados, assumir dia/hora do sistema caso nada for introduzido nesses inputs ;
# Restrições no 2: Criar um dicionário em que a chave c seja os 4 primeiros nºs[0000] do código postal e o valor é o nome da localidade referente ao código 4 nºs ;
# Restrições no 3: A data é dada pelo user tendo em conta uma estrura de periodos determinado pelo programador ;
from datetime import datetime 

# Zona das Funções

def menu():
    print('0 - Sair')
    print('1 - Nova Entrada')
    print('2 - Lista ordenada dos nome das localidades por total de compras')
    print('3 - Mostrar o periodo do dia com mais volume de compras')

# Zona Principal

lista_Dict = [
    {'postal':'3510-070', 'valorCompra':80, 'hora':'11:25', 'data':'04-04-2022'}
]

localidades = {[1000,1999]:'Lisboa', [2000,2399]:'Santarém', [2400,2599]:'Leiria', [2600,2699]:'Vila Franca de Xira', [2700,2799]:'Amadora', [2800,2899]:'Almada', [2900,2999]:'Setúbal', [3000,3099]:'Coimbra', [3100,3199]:'Pombal', [3200,3299]:'Lousã', [3300,3399]:'Arganil', [3400,3499]:'Oliveira do Hospital', [3500,3599]:'Viseu', [3600,3699]:'Castro Daire', [3700,3799]:'São João da Madeira', [3800,3899]:'Aveiro', [4000,4399]:'Porto', [4400,4499]:'Vila Nova de Gaia', [4500,4599]:'Espinho', [4600,4699]:'Amarante', [4700,4799]:'Braga', [4800,4899]:'Guimarães', [4900,4999]:'Viana do Castelo', [5000,5099]:'Vila Real', [5100,5199]:'Lamego', [5200,5299]:'Mogadouro', [5300,5399]:'Bragança', [5400,5499]:'Chaves', [6000,6099]:'Castelo Branco', [6000,6099]:'Castelo Branco', [6100,6199]:'Sertã', [6200,6299]:'Covilhã', [6300,6399]:'Guarda', [6400,6499]:'Pinhel', [7000,7099]:'Évora', [7100,7199]:'Estremoz', [7200,7299]:'Reguengos de Monsaraz', [7300,7399]:'Portalegre', [7400,7499]:'Ponte de Sôr', [7500,7599]:'Vila Nova de Santo André', [7600,7699]:'Aljustrel', [7700,7799]:'Almodôvar', [7800,7899]:'Beja', [7900,7999]:'Ferreira do Alentejo', [8000,8099]:'Faro', [8100,8199]:'Loulé', [8200,8299]:'Albufeira', [8300,8399]:'Silves', [8400,8499]:'Lagoa', [8500,8599]:'Portimão', [8600,8699]:'Lagos', [8700,8799]:'Olhão', [8800,8899]:'Tavira', 
[8900,8999]:'Vila Real de Santo António',[9000,9099]:'Funchal',[9100,9199]:'Santa Cruz',[9200,9299]:'Machico',[9300,9399]:'Câmara de Lobos',[9400,9499]:'Porto Santo',[9500,9599]:'Ponta Delgada',[9600,9699]:'Ribeira Grande',[9700,9799]:'Angra do Heroísmo',[9800,9899]:'Velas',[9900,9999]:'Horta'}

periodos = {[6,11]:'Manhã', [12,14]:'Meio-Dia', [15,18]:'Tarde', [19,23]:'Noite', [0,5]:'Madrugada'}

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
        data = input('Introduza o dia o mês e o ano (DD-MM-AAAA): ')
        if data == "":
            data = datetime.now().strftime('%d-%m-%Y')
        elif len(data) != 10:
            print('Tem de introduzir o : hifen e tudo pegado na data.')
            data = input('Introduza o dia o mês e o ano (DD-MM-AAAA): ')
        print(postal,valorCompra,hora,data)
    elif acao == 2:
        continue
    elif acao == 3:
        continue
    else:
        print('Tem de introduzir um nº compreendido entre 0a4.')