frase = input('Escreva uma frase: ')
contador = frase.count('a')
contador += frase.count('e')
contador += frase.count('i')
contador += frase.count('o')
contador += frase.count('u')
print("Número de vogais:",contador)
print("Número de outros carateres:",len(frase)-contador)