#variaveis
idade = int(input("Indique a idade da pessoa:\n"))
#processamento
if idade < 14:
    print("Criança")
elif idade >= 14 and idade < 18:
    print("Adolescente")
elif idade >= 18:
    print("Adulto")