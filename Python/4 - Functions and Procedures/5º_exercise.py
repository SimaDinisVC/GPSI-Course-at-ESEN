valor1 = input("Introduza o valor 1: ")
valor2 = input("Introduza o valor 2: ")
def troca(var1, var2):
    var1_inicial = var1
    var1 = var2
    var2 = var1_inicial
    print("O primeiro valor passou a ser: {}".format(var1))
    print("O segundo valor passou a ser: {}".format(var2))
troca(valor1, valor2)