A = int(input("Indique o valor de A:\n"))
B = int(input("Indique o valor de B:\n"))
exponeciacao = A
for i in range(1,B):
 exponeciacao = exponeciacao * A
print(A,"^",B,"=",exponeciacao)