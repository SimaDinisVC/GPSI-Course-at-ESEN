#variaveis
numero = int(input("Introduza um nº até 3 digitos:\n"))
#processamento
unidades = numero % 10
quociente = numero // 10
dezenas = quociente % 10
centenas = quociente // 10
#saida de dado
print("UNIDADES:",unidades)
print("DEZENAS:",dezenas)
print("CENTENAS:",centenas)