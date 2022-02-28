alfabeto = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"]
contador = []
frase = input("Introduza a frase: ").upper()
for i in alfabeto:
    if i in frase:
        contador.append("{0} - {1}".format(i,frase.count(i)))
print(*contador, sep = " vezes, ", end=" vezes.")