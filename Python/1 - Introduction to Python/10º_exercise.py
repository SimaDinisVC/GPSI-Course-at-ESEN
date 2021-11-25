#variaveis
horas = int(input("Quantas horas normais trabalhou no mês passado?"))
horas_extra = int(input("Quantas horas extras trabalhou no mês passado?"))
dinh_hora = 25
dinh_horaextra = 35
#processamento
bruto = (horas * dinh_hora) + (horas_extra * dinh_horaextra)
liquido = bruto - (bruto * 0.11)
#saida de dados
print("O seu salário sem descontos é de",bruto,"€, e terá de descontar",liquido,"€")