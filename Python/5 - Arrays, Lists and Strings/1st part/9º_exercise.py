from statistics import mode
pilotos = list(input("Introduza os pilotos vencedores das etapas separados entre espaços: ").split())
winner = mode(pilotos) # Vê a moda da lista
etapasWins = []
for i in range(len(pilotos)):
    if pilotos[i] == winner:
        etapasWins.append(i+1)
print('O piloto vencedor foi',winner,'tendo vencido a ',end="")
print(*etapasWins, sep ="ª,", end="ª etapas.")