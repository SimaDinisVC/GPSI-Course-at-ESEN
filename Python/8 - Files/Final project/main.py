# Projeto para uma loja/supermercado etc...
import random
import datetime
import openpyxl # importar 
import filemanagement as f # TRATAMENTO DE DADOS

def listar(l,w): # lista os dados list de forma sequencial
    if l != []:
        print('{}: '.format(w),end='')
        print(*l, sep=', ', end='.')
        print('')
    else:
        print('Sem dados de',w.lower())

def menu():
    print('0 - Sair')
    print('1 - Consultar Informação') 
    print('2 - Adicionar/Alterar Informação') 
    print('3 - Remover Informação')
    print('4 - Ler produtos (Realizar uma comprar)')
    print('5 - Gerar Relatórios')
    print('6 - Salvar dados')

produtos = {} # int(CódigoProduto) : list("NomeProduto", dict("Preço":int(preço), "Categoria":'categoria', "Q_Armazém": int(q_a), "Q_Exposto"): int(q_e), "Fornecedor":'NomeFornecedor')
categorias = {} # "Categoria" : list(int(CódigoProduto1), int(CódigoProduto2))
fornecedores = {} # "NomeFornecedor" : list(int(Tel), 'Email')
vendas_diarias = {} # int(CódigoProduto1): int(q_v)
caixaRegis = [[5432112351232, 2, 9.99]] # list(int(CódigoProduto1), Quant, Preço*Quant), list(int(CódigoProduto1), Quant, Preço*Quant) estrutura TEMP para caso a pessoa deixe a compra pendente

f.downloadProdutos(produtos)
f.downloadCategorias(categorias)
f.downloadFornecedores(fornecedores) # TRATA TODOS OS DADOS e BAIXA PARA A MEMÓRIA
f.downloadVendas(vendas_diarias)

sep = '----------'
print(produtos)
print(categorias)
print(fornecedores) # mudar para baixo do while TRABALHO UPLOUD
print(vendas_diarias)
print(sep)
while True:
    menu()
    acao = int(input('- '))
    print(sep)
    if acao == 0:
        while acao < 1 or acao > 3:
            print('Pretende salvar os dados?\n1 - Sim\n2 - Não\n3 - Cancelar')
            acao = int(input('- '))
        if acao == 1:
            f.uploudProdutos(produtos)
            f.uploudCategorias(categorias)
            f.uploudFornecedores(fornecedores)
            f.uploudVendas(vendas_diarias)
            exit()
        elif acao == 2:
            exit()
        else:
            continue
    elif acao == 1:
        acao = -1
        while acao < 0 or acao > 4:
            print('0 - Voltar')
            print('1 - Consultar Produtos')
            print('2 - Consultar Categorias')
            print('3 - Consultar Fornecedores')
            print('4 - Nº de vendas e saldo total diário')
            acao = int(input('- '))
            print(sep)
        if acao == 0:
            continue
        if acao == 1:
            acao = -1
            while acao < 0 or acao > 2:
                print('0 - Voltar')
                print('1 - Por categorias')
                print('2 - Por código EAN-13')
                acao = int(input('- '))
                print(sep)
            if acao == 0:
                continue
            elif acao == 1:
                listar(list(categorias), 'Categorias')
                cat = input('Escolha uma categoria: ')
                if cat in categorias and categorias[cat] != [None]:
                    produtosCAT = categorias[cat] # Todos os códigos de produtos na categoria
                    for code in produtosCAT:
                        dadosProduto = produtos[code] # list("NomeProduto", dict("Preço":int(preço), "Categoria":'categoria', "Q_Armazém": int(q_a), "Q_Exposto"): int(q_e), "DEFReposição": list(Q_MINrepor, Q_Encomenda), "Fornecedor":'NomeFornecedor')
                        print('Código EAN-13: {0} | {1} | Preço: {2}€ | Armazém: {3} uni. | Exposto: {4} uni. \nRepor q. houver: {5} uni. | Encomenda Pred.: {6} uni. | Fornecedor: {7}'.format(code, dadosProduto[0], dadosProduto[1]['Preço'], dadosProduto[1]['Q_Armazém'], dadosProduto[1]['Q_Exposto'], dadosProduto[1]['DEFReposição'][0], dadosProduto[1]['DEFReposição'][1], dadosProduto[1]['Fornecedor']))
                else:
                    print('A categoria inserida não consta na base de dados.')
            else:
                code = int(input('Introduza o código EAN-13 do produto: '))
                while len(str(code)) != 13:
                    print('O código EAN-13 tem de ter 13 digitos')
                    code = int(input('Introduza o código EAN-13 do produto: '))
                if code in produtos:
                    dadosProduto = produtos[code] # list("NomeProduto", dict("Preço":int(preço), "Categoria":'categoria', "Q_Armazém": int(q_a), "Q_Exposto"): int(q_e), "DEFReposição":list(Q_MINrepor, Q_Encomenda), "Fornecedor":'NomeFornecedor')
                    print('{0} | Preço: {1}€ | Categoria: {2} | Armazém: {3} uni. | Exposto: {4} uni. \nRepor q. houver: {5} uni. | Encomenda Pred.: {6} uni. | Fornecedor: {7}'.format(dadosProduto[0], dadosProduto[1]['Preço'], dadosProduto[1]['Categoria'], dadosProduto[1]['Q_Armazém'], dadosProduto[1]['Q_Exposto'], dadosProduto[1]['DEFReposição'][0], dadosProduto[1]['DEFReposição'][1], dadosProduto[1]['Fornecedor']))
                else:
                    print('A código EAN-13 inserido não consta na base de dados.')
        elif acao == 2:
            listar(list(categorias), 'Categorias')
        elif acao == 3:
            listar(list(fornecedores), 'Fornecedores')
            fornecedor = input('Introduza o nome do fornecedor:')
            print(fornecedor,'não se encontra na base de dados.')
            fornecedor = input('Introduza o nome do fornecedor novamente: ')
            print('Tel: {0} | Email: {1}'.format(fornecedores[fornecedor][0],fornecedores[fornecedor][1]))
        else:
            vendas = 0
            saldo = 0
            for code in vendas_diarias:
                vendas+= vendas_diarias[code]
                saldo+= produtos[code][1]['Preço']*vendas_diarias[code]
            print('Totais de vendas (Hoje):',vendas)
            print('Saldo Total (Hoje): {}€'.format(round(saldo,2)))
        acao == -1
    elif acao == 2:
        acao = -1
        while acao < 0 or acao > 3:
            print('0 - Voltar')
            print('1 - Adicionar/Alterar Produtos')
            print('2 - Adicionar/Alterar Categorias')
            print('3 - Adicionar/Alterar Fornecedores')
            acao = int(input('- '))
        if acao == 0:
            continue
        elif acao == 1:
            code = 1
            while len(str(code)) != 13 and code != 0:
                print('0 - Gerar código aleatório')
                code = int(input('Introduza o código do produto (EAN-13 dígitos): '))
            if code == 0:
                code = random.randint(1000000000000, 9999999999999)
                while code in produtos:
                    code = random.randint(1000000000000, 9999999999999)
            if code in produtos:  ########################ATUALIZAÇÃO########################
                print('O código EAN 13 - {} já existe.'.format(code))
                acao = -1
                while acao < 0 or acao > 7:
                    print('O que pretende alterar:')
                    print(' 0 - Voltar')
                    print(' 1 - Nome do Produto')
                    print(' 2 - Preço')
                    print(' 3 - Categoria')
                    print(' 4 - Quantidade em Armazém')
                    print(' 5 - Quantidade em Exposto')
                    print(' 6 - Definições de Reposição/Encomenda')
                    print(' 7 - Fornecedor')
                    acao = int(input('- '))
                if acao == 0:
                    continue
                elif acao == 1:
                    nome = input('Introduza o novo nome do produto: ')
                    Nexiste = True
                    while Nexiste:
                        for codigo in produtos:
                            if nome == produtos[codigo][0]:
                                Nexiste = False
                        if Nexiste == False:
                            Nexiste = True
                            print('O nome já é conhecido na base de dados tente usar outro.')
                            nome = input('Introduza o novo nome do produto: ')
                        else:
                            Nexiste = False
                    produtos[code][0] = nome
                    print('Produto atualizado com sucesso.')
                elif acao == 2:
                    preço = round(float(input('Introduza o novo preço do produto ex."9.99": ')),2)
                    produtos[code][1]['Preço'] = preço
                    print('Produto atualizado com sucesso.')
                elif acao == 3:
                    listar(list(categorias), 'Categorias')
                    categoria = input('Introduza o nome da categoria em que o produto se insere: ')
                    while categoria not in categorias: # Proteção de categoria
                        print(categoria,'não se encontra na base de dados.')
                        categoria = input('Introduza o nome da categoria em que o produto se insere: ')
                    categoriaANT = produtos[code][1]['Categoria']
                    categorias[categoriaANT].pop(categorias[categoriaANT].index(code))
                    produtos[code][1]['Categoria'] = categoria
                    if code not in categorias[categoria]:
                        categorias[categoria].append(code)
                    print('Produto atualizado com sucesso.')
                elif acao == 4:
                    q_armazém = int(input('Introduza as unidades existentes em armazém: '))
                    while q_armazém < 0:
                        print('O valor das unidades existentes em armazém tem de ser positivas ou nulas.')
                        q_armazém = int(input('Introduza as unidades existentes em armazém: '))
                    produtos[code][1]['Q_Armazém'] = q_armazém
                    print('Produto atualizado com sucesso.')
                elif acao == 5:
                    q_exposto = int(input('Introduza as unidades já expostas em loja: '))
                    while q_exposto < 0:
                        print('O valor das unidades já expostas em loja tem de ser positivas ou nulas.')
                        q_exposto = int(input('Introduza as unidades existentes em armazém: '))
                    q_MINrepor = int(input('Introduza as unidades mínimas em loja&armazém para acionar a encomenda: '))
                    produtos[code][1]['Q_Exposto'] = q_armazém
                elif acao == 6:
                    q_MINrepor = int(input('Introduza as unidades existentes em armazém: '))
                    while q_MINrepor < 1:
                        print('O valor das unidades mínimas em loja&armazém tem de ser positivas.')
                        q_MINrepor = int(input('Introduza as unidades existentes em armazém: '))
                    produtos[code][1]['DEFReposição'][0] = q_MINrepor
                    q_Encomenda = int(input('Introduza as unidades a encomendar predefinidas: '))
                    while q_Encomenda < 1:
                        print('O valor das unidades a encomendar tem de ser positivas.')
                        q_Encomenda = int(input('Introduza as unidades existentes em armazém: '))
                    produtos[code][1]['DEFReposição'][1] = q_Encomenda
                    print('Produto atualizado com sucesso.')
                else:
                    listar(list(fornecedores), 'Fornecedores')
                    fornecedor = input('Introduza o nome do fornecedor:')
                    produtos[code][1]['Fornecedor'] = fornecedor
                    print('Produto atualizado com sucesso.')
            else:   ########################ADIÇÃO########################
                print('---NOVO PRODUTO---')
                nome = input('Introduza o nome do novo produto: ')
                Nexiste = True
                while Nexiste:
                    for codigo in produtos:
                        if nome == produtos[codigo][0]:
                            Nexiste = False
                    if Nexiste == False:
                        Nexiste = True
                        print('O nome já é conhecido na base de dados tente usar outro.')
                        nome = input('Introduza o nome do novo produto: ')
                    else:
                        Nexiste = False
                preço = round(float(input('Introduza o preço do novo produto ex."9.99": ')),2)
                listar(list(categorias), 'Categorias')
                categoria = input('Introduza o nome da categoria em que o produto se insere: ')
                while categoria not in categorias: # Proteção de categoria
                    print(categoria,'não se encontra na base de dados.')
                    categoria = input('Introduza o nome da categoria em que o produto se insere: ')
                q_armazém = int(input('Introduza as unidades existentes em armazém: '))
                while q_armazém < 0:
                    print('O valor das unidades existentes em armazém tem de ser positivas ou nulas.')
                    q_armazém = int(input('Introduza as unidades existentes em armazém: '))
                q_exposto = int(input('Introduza as unidades já expostas em loja: '))
                while q_exposto < 0:
                    print('O valor das unidades já expostas em loja tem de ser positivas ou nulas.')
                    q_exposto = int(input('Introduza as unidades existentes em armazém: '))
                q_MINrepor = int(input('Introduza as unidades mínimas em loja&armazém para acionar a encomenda: '))
                while q_MINrepor < 1:
                    print('O valor das unidades mínimas em loja&armazém tem de ser positivas.')
                    q_MINrepor = int(input('Introduza as unidades existentes em armazém: '))
                q_Encomenda = int(input('Introduza as unidades a encomendar predefinidas: '))
                while q_Encomenda < 1:
                    print('O valor das unidades a encomendar tem de ser positivas.')
                    q_Encomenda = int(input('Introduza as unidades existentes em armazém: '))
                fornecedor = input('Introduza o nome do fornecedor:')
                while fornecedor not in fornecedores:
                    print(fornecedor,'não se encontra na base de dados.')
                    fornecedor = input('Introduza o nome do fornecedor novamente: ')
                produtos[code] = [nome]
                produtos[code].append({"Preço":preço})
                produtos[code][1]['Categoria'] = categoria
                categorias[categoria].append(code)
                produtos[code][1]['Q_Armazém'] = q_armazém
                produtos[code][1]['Q_Exposto'] = q_exposto
                produtos[code][1]['DEFReposição'] = [q_MINrepor]
                produtos[code][1]['DEFReposição'].append(q_Encomenda)
                produtos[code][1]['Fornecedor'] = fornecedor
                print('Produto adicionado com sucesso.')
        elif acao == 2:
            listar(list(categorias),'Categorias')
            categoria = input('Introduza o nome da categoria: ')
            categoriacop = categoria 
            if categoria in categorias:
                print('A categoria - {} já existe.'.format(categoria))
                info = categorias[categoria]
                categoria = input('Introduza o nome a alterar para a categoria: ')
                while categoria in categorias: # Proteção de categoria
                    print(categoria,'encontra se na base de dados.')
                    categoria = input('Introduza o nome a alterar para a categoria: ')
                categorias.pop(categoriacop)
                categorias[categoria] = info
                for code in info:
                    produtos[code][1]['Categorias'] = categoria
                print('Categoria renomeada com sucesso.')
            else:
                categorias[categoria] = []
                print('Nova categoria criada com sucesso.')
        else:
            listar(list(fornecedores),'Fornecedores')
            fornecedor = input('Introduza o fornecedor a alterar: ')
            if fornecedor in fornecedores:
                Nfornecedor = input('Introduza o novo fornecedor a alterar: ')
                tel = int(input('Introduza o novo telefone do fornecedor: '))
                email = input('Introduza o novo email do fornecedor: ')
                fornecedores.pop(fornecedor)
                fornecedores[Nfornecedor] = [tel,email]
                for code in produtos:
                    if produtos[code][1]['Fornecedor'] == fornecedor:
                        produtos[code][1]['Fornecedor'] = Nfornecedor
                print('Fornecedor atualizada com sucesso.')
            else:
                tel = int(input('Introduza o novo telefone do fornecedor: '))
                email = input('Introduza o novo email do fornecedor: ')
                fornecedores[fornecedor] = [tel,email]
                print('Fornecedor criado com sucesso.')
    elif acao == 3:
        acao = -1
        while acao < 0 or acao > 3:
            print('0 - Voltar')
            print('1 - Remover Produtos')
            print('2 - Remover Categorias')
            print('3 - Remover Fornecedores')
            acao = int(input('- '))
        if acao == 0:
            continue
        elif acao == 1:
            code = int(input('Introduza o código do produto a remover: '))
            while len(str(code)) != 13:
                print('O código EAN-13 tem de ter 13 digitos')
                code = int(input('Introduza o código do produto a remover: '))
            if code in produtos:
                caixaRegis.clear()
                if code in vendas_diarias:
                    vendas_diarias.pop(code)
                for cat in categorias:
                    if code in categorias[cat]:
                        categorias[cat].pop(categorias[cat].index(code))
                produtos.pop(code)
                print('Produto removido com sucesso.')
            else:
                print('Código introduzido não consta na base de dados.')
        elif acao == 2:
            listar(list(categorias),'Categorias')
            categoria = input('Introduza a categoria a remover: ')
            if categoria in categorias:
                for code in produtos:
                    if produtos[code][1]['Categoria'] == categoria:
                        listar(list(categorias),'Categorias')
                        print('O produto {} está sem categoria.'.format(produtos[code][0]))
                        cat = input('Introduza o nome da categoria em que o produto se insere: ')
                        while cat not in categorias: # Proteção de categoria
                            print(cat,'não se encontra na base de dados.')
                            cat = input('Introduza o nome da categoria em que o produto se insere: ')
                        categorias[cat].append(code)
                        produtos[code][1]['Categoria'] = cat
                categorias.pop(categoria)
                print('Categoria removida com sucesso.')
            else:
                print('Categoria introduzida não consta na base de dados.')
        elif acao == 3:
            listar(list(fornecedores),'Fornecedores')
            fornecedor = input('Introduza o fornecedor a remover: ')
            if fornecedor in fornecedores:
                for code in produtos:
                    if produtos[code][1]['Fornecedor'] == fornecedor:
                        listar(list(fornecedores),'Fornecedores')
                        print('O produto {} está sem Fornecedor.'.format(produtos[code][0]))
                        forn = input('Introduza o nome do Fornecedor do produto: ')
                        while forn not in fornecedores: # Proteção de categoria
                            print(forn,'não se encontra na base de dados.')
                            forn = input('Introduza o nome do Fornecedor do produto: ')
                        produtos[code][1]['Fornecedor'] = forn
                fornecedores.pop(fornecedor)
                print('Fornecedor removido com sucesso.')
            else:
                print('Forncedor introduzido não consta na base de dados.')
    elif acao == 4:
        while True:
            acao = -1
            while acao < 0 or acao > 2:
                listar(caixaRegis,'Itens') # A melhorar
                print('0 - Voltar')
                print('1 - Passar Produto')
                print('2 - Confirmar Pagamento')
                print('3 - Limpar Compra')
                acao = int(input('- '))
            if acao == 0:
                break
            elif acao == 1:
                code = int(input('Introduza o código EAN-13 do item: '))
                while len(str(code)) != 13:
                    print('O código EAN-13 tem de ter 13 digitos')
                    code = int(input('Introduza o código EAN-13 do item: '))
                if code in produtos:
                    v = False
                    for i in range(len(caixaRegis)):
                        if code in caixaRegis[i]:  ############################RETIRAR EXPOSTOS
                            caixaRegis[i][1] += 1 # Dá mais 1 à quantidade
                            caixaRegis[i][2] += produtos[code][1]['Preço'] # Dá mais um preço
                            v = True
                    if v == False:
                        caixaRegis.append([code, 1, produtos[code][1]['Preço']])
                else:
                    print('Código introduzido não consta na base de dados.')
            elif acao == 2:
                total = 0
                for i in caixaRegis:
                    total += i[2]
                    if total != 0:
                        vendas_diarias[i[0]] = i[1]
                caixaRegis.clear()
                break
            else:
                caixaRegis.clear()
    elif acao == 5:
        # Relatório Encomendas a Fornecederes
        book = openpyxl.Workbook()
        book.create_sheet('Encomendas')
        book.remove(book['Sheet'])
        book['Encomendas'].column_dimensions['A'].width = 20
        book['Encomendas'].column_dimensions['B'].width = 15
        book['Encomendas'].column_dimensions['C'].width = 35
        book['Encomendas'].column_dimensions['D'].width = 20
        book['Encomendas'].column_dimensions['E'].width = 30
        book['Encomendas'].column_dimensions['F'].width = 12
        book['Encomendas'].append(['Fornecedor', 'Tel.', 'Email', 'Código EAN-13', 'Nome do Produto', 'Quantidade'])
        for code in produtos:
            dadosProduto = produtos[code]
            if produtos[code][1]['Q_Armazém'] + produtos[code][1]['Q_Exposto'] < dadosProduto[1]['DEFReposição'][0]:
                book['Encomendas'].append([produtos[code][1]['Fornecedor'], fornecedores[produtos[code][1]['Fornecedor']][0], fornecedores[produtos[code][1]['Fornecedor']][1], str(code), produtos[code][0],  dadosProduto[1]['DEFReposição'][0]])
        book.save('Encomendas.xlsx')
        # Relatório Vendas Diárias
    elif acao == 6:
        f.uploudProdutos(produtos)
        f.uploudCategorias(categorias)
        f.uploudFornecedores(fornecedores)
        f.uploudVendas(vendas_diarias)
    # VERIFICAR SISTEMA DE COMPRAS E SISTEMAS DE UPLOUDS