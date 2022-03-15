frase = input('Introduza a frase: ')

frasediv = []

for c in frase:
    frasediv.append(c)

print("A frase introduzida tem {0} espaços, {1} e's, {2} i's, {3} o's e {4} u's".format(frasediv.count(' '), frasediv.count('e'), frasediv.count('i'), frasediv.count('o'), frasediv.count('u')))