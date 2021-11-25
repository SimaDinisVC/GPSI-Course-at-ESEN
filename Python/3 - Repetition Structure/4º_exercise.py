print("INFO PARA MODERADORES: Para parar a contagem e mostrar o valores digite 0.\nCaso exeda os 1000 kg de referência o programa pára a contagem automaticamente.\n\n")
kg = 0
peso = 0
taxas = 0
while kg <= 1000:
    print("Aviso: Por cada mala são cobrados 20€. Expresse o valor do peso em Kg.")
    peso = int(input("Indique o peso da sua mala:\n"))
    kg = kg + peso 
    taxas = taxas + 20
    if kg >= 1000:
        print("Limite de 1000 Kg atingido. Contabilizados no total",kg,"kg.\nSendo que a ultima mala registada pesa",peso,"kg.")
        break
    if peso == 0:
        print("Contabilizados no total",kg,"kg.")
        taxas = taxas - 20
    if kg == 0:
        taxas = 0
        break
print("O valor apurado em taxas é de {}€.".format(taxas))