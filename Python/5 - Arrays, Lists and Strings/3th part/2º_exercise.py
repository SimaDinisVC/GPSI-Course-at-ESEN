lista = list(map(int, input().split()))

contador = 0

for i in lista:
    if lista.count(i) == 1:
        contador += 1

print(contador)