quantia = int(input("Introduza a quantia que inicial:\n"))
anos = int(input("Introduza o nº de anos::\n"))
taxa = int(input("Introduza a taxa em percentagem:\n"))
taxa = taxa / 100
juros = 0
for i in range(1,anos+1):
    rendimento = quantia * taxa
    juros = juros + rendimento
    quantia = quantia + rendimento
    print("No {}º Ano:".format(i),quantia)
print("Juros Ganhos:",juros)