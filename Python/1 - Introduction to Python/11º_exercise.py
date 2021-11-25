#variaveis
Quant_latas = int(input("Quantas latas o comerciante comprou?\n"))
Quant_garrafas = int(input("Quantas garrafas de 600ml o comerciante comprou?\n"))
Quant_garrafa_2l = int(input("Quantas garrafas de 2l o comerciante comprou?\n"))
lata = 0.35
garrafa = 0.60
garrafa_2l = 2
#processamento
litros = (lata * Quant_latas) + (garrafa * Quant_garrafas) + (garrafa_2l * Quant_garrafa_2l)
#saida de dados
print("O comerciante comprou",litros,"litros de refrigerante")