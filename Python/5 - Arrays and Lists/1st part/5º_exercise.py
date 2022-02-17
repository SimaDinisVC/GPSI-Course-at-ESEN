#Zona das funções
def protecao(var):
    while var <= 0:
        var = int(input('Introduza o número de ações que deseja efetuar:\n'))
    return var
#Zona Principal
montateF = []
Defice = []
Lucro = []
lucro0 = []
acoes = int(input('Introduza o número de ações que deseja efetuar:\n'))
acoes = protecao(acoes)
for i in range(1,acoes+1): # Aqui vai buscar os valores de compra e vende de cada ação.
    compra = float(input('Introduza o valor da {}ª compra: '.format(i)))
    venda = float(input('Introduza o valor da {}ª venda: '.format(i)))
    lucro = venda - compra # Aqui verifica se houve lucro
    if lucro > 0: # Aqui depois envia para a lista pretendida o indice da ação para depois dar conhecimento ao utilizador.
        Lucro.append(i)
    elif lucro < 0:
        Defice.append(i)
    else:
        lucro0.append(i)
    montateF.append(lucro) 
print("-------.-------")
# Apartir daqui imprime a informação das ações em que houve defice, lucro ou nada e no caso de haver apenas 1 caso em cada um deles ele tem de ser diferente dos outros pois envés de sep = "" que separa ele tem que terminar end = "" se não causa a desformatação da frase.
if len(Defice) == 1:
    print('O programa verificou que existiu defice no valor da ', end = "")
    print(*Defice, end = 'ª ação.\n')
elif len(Defice) > 1:
    print('O programa verificou que existiu defice no valor da ', end="")
    print(*Defice, sep = 'ª ação, ', end = 'ª ação.\n')
else:
    print('O programa não encontrou nenhum defice no valor das ações.')
if len(Lucro) == 1:
    print('O programa verificou que existiu lucro no valor da ', end = "")
    print(*Lucro, end = 'ª ação.\n')
elif len(Lucro) > 1:
    print('O programa verificou que existiu lucro no valor da ', end = "")
    print(*Lucro, sep = 'ª ação, ', end = 'ª ação.\n')
else:
    print('O programa não encontrou nenhum lucro no valor das ações.')
if len(lucro0) == 1:
    print('O programa verificou que não existiu lucro nem defice no valor da ', end = "")
    print(*lucro0, end = 'ª ação.\n')
elif len(lucro0) > 1:
    print('O programa verificou que não existiu lucro nem defice no valor da ', end = "")
    print(*lucro0, sep = 'ª ação, ', end = 'ª ação.\n')
print('O montante acumulado com as suas ações é de {}€.'.format(sum(montateF))) # Montate Acumulado
print("-------.-------")
# FIM das infos