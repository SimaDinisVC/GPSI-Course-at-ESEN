def search(path, word):
    try:
        with open(path) as f:
            for l in f.readlines():
                if word in l.split():
                    print(l, end="")
    except:
        return 0
  
loop = True

while loop:
    caminho = input("Introduza o caminho absoluto do ficheiro: ")
    palavra = input("Introduza a palavra a procurar: ")
    res = search(caminho, palavra)
    if res != 0:
        loop = False