#variáveis
n1 = int(input("Introduza um número qualquer:\n"))
n2 = int(input("Introduza outro número:\n"))
valor = int(input("Introduza a o nº da operação que desaja fazer:\n 1-somar 2-subtrair 3-multiplicar 4-dividir\n"))
#processamento
v1 = n1 + n2
v2 = n1 - n2
v3 = n1 * n2
v4 = n1 / n2
if valor == 1:
    print("A soma dos números é",v1)
elif valor == 2:
    print("A subtração dos números é",v2)
elif valor == 3:
    print("A multiplicação dos números é",v3)
elif valor == 4:
    print("A divisão dos números é",v4)