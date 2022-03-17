dados = {
    'Pedro': ['php', 'html', 'JavaScript'],
    'Carlos': ['C#', 'Python', 'Java']
}
###Menú###
while True:
    print('|Menú|\n0 - Sair\n1 - Ver dados\n2 - Add linguagem de programação')
    menu = int(input('- '))
    if menu == 0:
        exit()
    elif menu == 1:
        print(dados)
    elif menu == 2:
        nomeProg = input('Introduza o nome do programador a escolher:')
        dados.setdefault(nomeProg,[])
        lingua = input('Introduza os nomes das linguagems a escolher separados por espaços:').split()
        dados[nomeProg] = dados[nomeProg] + lingua
    else:
        while menu < 0 or menu > 2:
            print('O número introduzido tem de estar compreendido entre 0 e 2')
            print('|Menú|\n0 - Sair\n1 - Ver dados\n2 - Add linguagem de programação')
            menu = int(input('- '))