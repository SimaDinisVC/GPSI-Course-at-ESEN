def soma_quadrados(n):
    valor = 0
    for i in range(1,n+1):
        valor = valor + (i*i)
    return(valor)
#Zona principal
n = int(input("Indique o nº inteiro positivo:\n"))
while n < 0:
    n = int(input("Indique o nº inteiro positivo:\n"))
valorf=soma_quadrados(n)
print(valorf)