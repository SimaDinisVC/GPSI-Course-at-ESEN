kms = []
km_percorridos = 0
for i in range(1,8):
    km1 = float(input("Introduza os kilometros que percorreu no dia {}:".format(i)))
    kms.append(km1)
print('O programa fez a leitura de {}.'.format(sum(kms)))