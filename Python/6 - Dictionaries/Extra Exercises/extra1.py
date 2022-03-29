#SimaDinisVC on GitHub
dicionario = {2:['Inglês', 'Física-Química', 'Progr. e Sist.', 'Ed. Física'], 3:['Área de Integração', 'TIC', 'Português', 'Física-Química', 'Matemática'], 4:['Matemática', 'Progr. e Sist.'], 5:['Progr. e Sist.', 'Física-Química', 'Português', 'SEMat'], 6:['Inglês', 'Área de Integração', 'Sistemas Operativos', 'TIC']}
Dsemana = int(input('Introduza o numero do dia de semana de 2a6: '))

print(dicionario.get(Dsemana, "O dia de semana introduzido não existe."))

subject = input('Introduza a disciplina que deseja verificar repetição semanal: ') 
contador = 0 
for i in range(2,7):
    if subject in dicionario[i]:
        contador += 1

print('Existe {0} vezes {1} por semana.'.format(contador, subject))

dados = {}
dadosI = list(input('Introduza o nome, data de nascimento e código postal separados entre espaços: ').split()) # List to organize the data.
for i in range(len(dadosI)): # It checks the entire list and checks if it can transform the "int" data in the program using try and except for the errors.
    try:
        dadosI[i] = int(dadosI[i])
    except:
        dadosI[i] = str(dadosI[i])

for i in range(0, len(dadosI), 3): # Here it goes 3 in 3 index to get only the Names.
    if dadosI[i+1] > 18: # Here it checks if is > 18 to add to the final dictionary.
        dados[dadosI[i]] = [dadosI[i+1], dadosI[i+2]]

print(dados)