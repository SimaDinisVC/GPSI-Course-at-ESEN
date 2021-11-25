fatorial = int(input("Indique o nº para o fatorial:\n"))
n = fatorial
if n != 0:
    for i in range(1,fatorial):
        n = i * n
else:
    n = 1
print("O fatorial de",fatorial,"é de",n)