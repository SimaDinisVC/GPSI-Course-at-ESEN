#Zona das Funções
def desmanchador(frase):
    nomelist = []
    for c in frase:
        nomelist.append(c)
    return nomelist
#Zona Principal
Normal = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"]
Codificacao = ["E", "X", "W", "R", "O", "T", "P", "S", "U", "D", "Q", "G", "H", "J", "I", "K", "L", "Z", "M", "C", "Y", "B", "N", "F", "A", "V"]

frase = input("Introduza a frase a codificar: ")
frasedes = desmanchador(frase)
codificado = ""

for i in range(len(frasedes)):
    if frasedes[i].upper() in Normal:
        codificado = codificado + Codificacao[Normal.index(frasedes[i].upper())]
    else:
        codificado = codificado + frasedes[i]
print(codificado)