# Function Zone
def converNominal(mes):
    meses = ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro']
    return meses[mes-1]
# Main Zone

data = list(map(int, input('Data de Nascimento (dd/mm/aaaa): ').split('/')))

print('Você nasceu a {0} de {1} de {2}.'.format(data[0], converNominal(data[1]), data[2]))