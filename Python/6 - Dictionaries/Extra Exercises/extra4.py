produtos = {1273961531:{'Preço':0.78, 'IVA':13, 'Descrição':'Leite magro da marca Bio.'}} #####Estilo do Dicio#####

# Menú #
while True:
    print('|Menú|\n0 - Sair\n1 - Inserir Produto\n2 - Alterar o Preço do produto dado o código\n3 - Aumentar ou diminuir o Preço de todos os Produtos com igual %\n4 - Listar Produtos')
    acao = int(input(': '))

    if acao == 0:
        exit()
    elif acao == 1:
        codigo = int(input('Introduza o Código do produto\n: '))
        preco = float(input('Introduza o Preço do produto\n: '))
        iva = int(input('Introduza o IVA do produto\n: '))
        descricao = input('Introduza a Descrição do produto\n: ')
        produtos.setdefault(codigo,{'Preço':preco, 'IVA':iva, 'Descrição':descricao})
    elif acao == 2:
        codigo = int(input('Introduza o Código do produto a alterar\n: '))
        preco = float(input('Introduza o Preço do produto a alterar\n: '))
        produtos[codigo]['Preço'] = preco
    elif acao == 3:
        percentagem = float(input('Introduza a percentagem do produto a alterar\n: '))
        for k in produtos:
            produtos[k]['Preço'] = round(produtos[k]['Preço']+produtos[k]['Preço']*(percentagem/100), 2)
    elif acao == 4:
        for p in produtos:
            print('************')
            print('Código {0}:\n   Preço - {1}\n   IVA - {2}%\n   Descrição - {3}'.format(p,produtos[p]['Preço'],produtos[p]['IVA'], produtos[p]['Descrição']))
            print('************')
    else:
        print('Tem que introduzir um nº que esteja entre 0e4.')