autor = {"php":"Rasmus Lerdorf","perl":"Larry Wall","tcl":"John Ousterhout", "awk":"Brian Kernighan","java":"James osling","parrot":"Simon Cozens", "python":"Guido van Rossum"}

linguagem = input('Introduza o nome da linguagem para ver o autor: ')

print(autor.get(linguagem, 'O autor não existe!'))