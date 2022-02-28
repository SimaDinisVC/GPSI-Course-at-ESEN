nome = input("Introduza o nome completo: ").split()
Proprio = nome[0][0].upper() + nome[0][1::]
Apelido = nome[len(nome)-1][0].upper() + nome[len(nome)-1][1::]
print(Proprio, Apelido)