primo = int(input("Indique o nº natural que deseja:\n"))
n = 0
for i in range(1,primo+1):
    if primo % i == 0:
        n = n + 1
    if n == 2:
        print("Nº primo.")
    else:
        print("O não é primo.")