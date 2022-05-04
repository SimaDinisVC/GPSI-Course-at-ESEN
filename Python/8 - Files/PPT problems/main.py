def reader(path):
    try:
        f = open("path")
        r = f.read()
        f.close()
        return r
    except:
        f.close()
        return None

caminho = input("Introduza o caminho absoluto do ficheiro")

res = reader(caminho)    
while res == None:
    print("Tem que introduzir um caminho absoluto válido.")
    caminho = input("Introduza o caminho absoluto do ficheiro")

print(res)