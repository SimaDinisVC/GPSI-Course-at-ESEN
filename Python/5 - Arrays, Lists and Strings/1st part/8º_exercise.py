vetor_x = list(input('Introduza os numeros separados por espaços da string_x: ').split())
vetor_y = list(input('Introduza os numeros separados por espaços da string_y: ').split())
vetor_y.reverse()
vetor_final = []
for i in range(len(vetor_x)):
    vetor_final.append(vetor_x[i])
    vetor_final.append(vetor_y[i])
print(vetor_final)