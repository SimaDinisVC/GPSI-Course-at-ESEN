#variaveis
idade = int(input("Indique a idade do jogador:\n"))
#processamento
if idade <= 10:
    print("Infantis")
elif idade > 10 and idade <= 14:
    print("Inicidos")
elif idade > 14 and idade <= 18:
    print("Juniores")
elif idade > 18:
    print("Seniores")