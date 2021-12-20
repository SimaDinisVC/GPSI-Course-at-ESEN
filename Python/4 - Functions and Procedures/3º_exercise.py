numero1 = int(input("Introduza o número: "))
nmultiplos1 = 100
def multiplos(numero, nmultiplos):
  multiplo = 0
  for i in range(1, nmultiplos + 1):
    multiplo = numero * i
    print(multiplo)
multiplos(numero1, nmultiplos1)