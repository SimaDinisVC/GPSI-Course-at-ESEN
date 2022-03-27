##############COM LIVRARÍA##############
from datetime import date

dias_semana = {1:'Segunda-Feira', 2:'Terça-feira', 3:'Quarta-feira', 4:'Quinta-feira', 5:'Sexta-feira', 6:'Sábado', 7:'Domingo'}
meses_anos = {1:'Janeiro', 2:'Fevereiro', 3:'Março', 4:'Abril', 5:'Maio', 6:'Junho', 7:'Julho', 8:'Agosto', 9:'Setembro', 10:'Outubro', 11:'Novembro', 12:'Dezembro'}

DM, M, A = map(int,input("Introduza o DM/M/A:").split("/")) # Agora este input já não recebe DS (dia da semana)

temp = date(year=A, month=M, day=DM)

print("{0}, {1} de {2} de {3}".format(dias_semana[temp.weekday()+1], DM, meses_anos[M], A))

##############SEM LIVRARÍA##############