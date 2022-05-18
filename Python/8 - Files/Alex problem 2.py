import os
def search(path): # verifica se o ficheiro existe
    if os.path.isfile(path):
        return False
    else:
        return True

space = int(input('Introduza o espaço total do disco: '))
path = input('Introduza o caminho absuluto do ficheiro: ')
while search(path):
    print('Ficheiro não encontrado!')
    path = input('Introduza o caminho absuluto do ficheiro: ')

d = {}
with open(path) as f:
    for l in f:
        n,b = l.split()
        b = int(b)
        d[n] = b

l = []
l.append("Relatório:\n")
for n in d:
    mb = d[n] * 10**-6
    perc = ((d[n] * 10**-9)*100)/space
    l.append("   {0} / {1} MB/ {2} %\n".format(n,round(mb),round(perc,3)))

with open("relatório.txt","w") as r:
    r.writelines(l)

print("O diretório do relatório é: {}".format(os.getcwd()))

with open("relatório.txt") as f:
    print(f.read())