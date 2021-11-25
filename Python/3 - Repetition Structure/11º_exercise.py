n_conv = int(input("Introduza o nº que pertende contar para binário:\n"))
n = n_conv
paridade = 0
while n_conv != 0:
    resto = n_conv % 2
    n_conv = n_conv // 2
    if resto == 1:
        paridade = paridade + 1
print("A paridade do nº{}".format(n),"é de {}.".format(paridade))