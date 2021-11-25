#variáveis
horas = float(input("Indique a hora do dia:\n"))
#processamento
if horas >= 8 and horas <= 12:
    print("É manhã.")
elif horas >= 13 and horas <= 19:
    print("É tarde.")
elif horas >= 20 and horas <= 24 and horas >= 0 and horas <= 4:
    print("É noite.")
elif horas >= 5 and horas <= 7:
    print("É madrugada.")
elif horas > 24:
    print("Inválido.")