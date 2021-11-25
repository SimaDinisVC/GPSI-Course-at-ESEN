#variáveis
preco = float(input("Introduza o preço do livro:\n"))
pais = input("Introduza a origem do livro:\n")
#processamento
imposto5 = (preco * 5)/100
imposto10 = (preco * 10)/100
if pais == "Portugal":
 print("O livro custa",preco,"€.")
elif pais == "Moçambique":
 print("O livro custa",round(preco + imposto5,2),"€.")
elif pais == "Angola":
 print("O livro custa",round(preco + imposto5,2),"€.")
elif pais == "Cabo Verde":
 print("O livro custa",round(preco + imposto5,2),"€.")
elif pais == "Brasil":
 print("O livro custa",round(preco + imposto5,2),"€.")
else:
 print("O livro custa",round(preco + imposto10,2),"€.")