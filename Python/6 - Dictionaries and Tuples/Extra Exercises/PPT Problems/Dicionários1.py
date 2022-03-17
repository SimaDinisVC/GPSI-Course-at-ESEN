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
        add = []
        nomeProg = input('Introduza o nome do programador a escolher:')
        if nomeProg not in dados.keys():
            print('É necessário o nome de um programador existente.')
            nomeProg = input('Introduza o nome do programador a escolher:')
        else:
            Lingua = input('Introduza o nome da linguagem a escolher:')
            dados[nomeProg].append(Lingua)