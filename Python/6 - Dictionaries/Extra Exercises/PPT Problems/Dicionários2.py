dias_semana = {1:'Domingo', 2:'Segunda-Feira', 3:'Terça-feira', 4:'Quarta-feira', 5:'Quinta-feira', 6:'Sexta-feira', 7:'Sábado'}
meses_anos = {1:'Janeiro', 2:'Fevereiro', 3:'Março', 4:'Abril', 5:'Maio', 6:'Junho', 7:'Julho', 8:'Agosto', 9:'Setembro', 10:'Outubro', 11:'Novembro', 12:'Dezembro'}

DS, DM, M, A = map(int,input("Introduza o DS/DM/M/A:").split("/"))

print("{0}, {1} de {2} de {3}".format(dias_semana[DS], DM, meses_anos[M], A))