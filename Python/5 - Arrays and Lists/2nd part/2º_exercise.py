nome = input('Introduza o nome a converter: ')
print(nome[::-1])
if nome[::-1].lower() == nome.lower():
    print('É uma capicua.')