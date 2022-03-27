local = list(input('Introduza os nomes das equipas da casa separados entre espaços: ').split())
golos = list(map(int, input('Introduza os golos marcados em cada jornada separados entre espaços: ').split()))

while 0 in golos:
    print('Os golos marcados devem ser números positivos maiores ou iguais a 0.')
    golos.clear()
    golos = list(map(int, input('Introduza os golos marcados em cada jornada separados entre espaços: ').split()))

percentagem = (local.count('Viseu')*100)/len(local)

print('O record de golos num jogo foi de {0} golos, obtido na {1}ª jornada. {2}% dos jogos da temporada foram em casa. A equipa marcou {3} golos na totalidade.'.format(max(golos), golos.index(max(golos))+1, round(percentagem), sum(golos)))