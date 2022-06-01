def downloadProdutos(produtos):
    f = open('data/dataProdutos.txt')
    for l in f.readlines():
        code, rest = l.split(' - ')
        code = int(code)
        name, preço, categoria, q_armazém, q_exposto, q_MINrepor, q_Encomenda, fornecedor = rest.split('; ')
        preço = float(preço)
        q_armazém = int(q_armazém)
        q_exposto = int(q_exposto)
        q_MINrepor = int(q_MINrepor)
        q_Encomenda = int(q_Encomenda)
        if fornecedor[-1::] == "\n":
            fornecedor = fornecedor[:-1:]
        produtos[code] = [name, {'Preço':preço, 'Categoria':categoria, 'Q_Armazém':q_armazém, 'Q_Exposto':q_exposto, "DEFReposição": [q_MINrepor, q_Encomenda], 'Fornecedor':fornecedor}]
    f.close()

def downloadCategorias(categorias):
    f = open('data/dataCategorias.txt')
    for l in f.readlines():
        categoria, rest = l.split(' - ')
        code = rest.split('; ')
        for i in range(len(code)):
            try:
                if code[i][-1::] == "\n":
                    code[i] = code[i][:-1:]
                if code[i].isdigit():
                    code[i] = int(code[i])
            except:
                continue
        if code == [""] or code == ["\n"]:
            code = []
        categorias[categoria] = code
    f.close()

def downloadFornecedores(fornecedores):
    f = open('data/dataFornecedores.txt')
    for l in f.readlines():
        nome, rest = l.split(' - ')
        info = rest.split('; ')
        info[0] = int(info[0])
        if info[1][-1::] == "\n":
            info[1] = info[1][:-1:]
        fornecedores[nome] = info
    f.close()

def downloadVendas(vendas_diarias):
    f = open('data/dataVendas.txt')
    for l in f.readlines():
        if l.count('-') == 2:
            data = l[:-1:]
            vendas_diarias[data] = {}
        else:
            code, rest = l.split(' - ')
            code = int(code)
            quantidade, preço_t = rest.split('; ')
            quantidade = int(quantidade)
            if preço_t[-1::] == "\n":
                preço_t = preço_t[:-1:]
            preço_t = int(preço_t)
            vendas_diarias[data][code] = [quantidade,preço_t]
    f.close()

def uploudProdutos(produtos):
    f = open('data/dataProdutos.txt', 'w')
    for code in produtos:
        dadosProduto = produtos[code]
        f.write('{0} - {1}; {2}; {3}; {4}; {5}; {6}; {7}; {8}\n'.format(code, dadosProduto[0], dadosProduto[1]['Preço'], dadosProduto[1]['Categoria'], dadosProduto[1]['Q_Armazém'], dadosProduto[1]['Q_Exposto'], dadosProduto[1]['DEFReposição'][0], dadosProduto[1]['DEFReposição'][1], dadosProduto[1]['Fornecedor']))
    f.close()

def uploudCategorias(categorias):
    f = open('data/dataCategorias.txt', 'w')
    for cat in categorias:
        f.write('{0} - '.format(cat))
        f.write("; ".join(map(str, categorias[cat])))
        f.write('\n')
    f.close()

def uploudFornecedores(fornecedores):
    f = open('data/dataFornecedores.txt', 'w')
    for forn in fornecedores:
        f.write('{0} - '.format(forn))
        f.write("; ".join(map(str, fornecedores[forn])))
        f.write('\n')
    f.close()

def uploudVendas(vendas_diarias):
    f = open('data/dataVendas.txt', 'w')
    data = list(vendas_diarias.keys())
    data = data[0]
    dadosVendas = vendas_diarias[data]
    f.write(data+'\n')
    for v in dadosVendas:
        f.write('{0} - {1}; {2}\n'.format(v, dadosVendas[v][0], dadosVendas[v][1]))
    f.close()