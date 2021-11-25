n_melhor = 0
melhor = -1
n_alunos = int(input("Indique quantos alunos têm a turma:\n"))
for i in range(1,n_alunos+1):
    media = float(input("Indique a média do aluno nº{}:\n".format(i)))
    while media>20 or media<0:
        print("Dado invalido a média tem de ser de 0 a 20.")
        media = float(input("Indique a média do aluno nº{}:\n".format(i)))
        round(media)
    if media > melhor:
        melhor = media
        n_melhor = i
print("O melhor aluno/com melhor média é o nº{}.".format(n_melhor))