#variaveis
tamanhoMBs = float(input("Indique o tamanho do ficheiro do download em MB's:\n"))
net = float(input("Indique a velocidade de internet em mbps:\n"))
#processamento
tempo = tamanhoMBs/net
min = tempo/60
#saida de dados
print("O seu ficheiro vai demorar",min,"min.")