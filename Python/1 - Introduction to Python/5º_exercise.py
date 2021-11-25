#variaveis
meses = int(input("Em que nº do mês quer converter?\n"))
dias = int(input("Em que dia do mês quer converter?\n"))
#processamento
dias_res = 30 - dias
resultado = (meses * 30) - dias_res
#saida de dados
print("A conversão é",round(resultado),"dias")