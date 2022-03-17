nome1, nome2, nome3, nome4, nome5, nome6, nome7, nome8, nome9, nome10 = input("Introduza o nome do passageira para etiquetar:\n- ").split()
nomes = [nome1,nome2,nome3,nome4,nome5,nome6,nome7,nome8,nome9,nome10]
for i in range(len(nomes)):
    print(nomes[i], end=" ")
print("")
for i in range(1,len(nomes)+1):
    print(nomes[-i], end=" ")