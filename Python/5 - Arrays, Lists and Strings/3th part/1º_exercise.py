lista = list(map(int, input().split()))

for x in range(min(lista), max(lista)+1):
    if x in lista:
        print(lista.index(x))
    else:
        print(-1)