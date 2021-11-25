#variaveis
Quant = int(input("Introduza a quantidade de litros que quer usar:\n"))
#processamento
garrf_5l = int(Quant/5)
garrf_1_5l = int(Quant/1.5)
garrf_0_5l = int(Quant/0.5)
garrf_0_25l = int(Quant/0.25)
#saida de dados
print("No mínimo é necessário:\n",garrf_5l,"garrafas de 5 Litros\n",garrf_1_5l,"garrafas de 1.5 Litros\n",garrf_0_5l,"garrafa de 0.5 Litros\n",garrf_0_25l,"garrafas de 0.25 Litros.")