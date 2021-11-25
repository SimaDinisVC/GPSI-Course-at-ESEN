bact = int(input("Introduza o nº de bactérias que a experiência terminou:\n"))
dias = 0
while bact > 1:
    bact = bact // 2
    dias = dias + 1
print("A experiencia começou com {} bactéria".format(bact),"e a experiencia demorou {} dias.".format(dias))