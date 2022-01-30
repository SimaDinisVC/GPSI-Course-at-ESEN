#Zona das Funções
def conv_F(F):
    C = 5 * (F-32)/9
    return(C)
def conv_C(C):
    F = (9 * C/5) + 32
    return(F)
#Zona Principal
conversao = int(input('Indique qual das conversões deseja fazer:\n1º: Cº --> Fº\n2º: Fº --> Cº\n- '))
while conversao != 1 and conversao != 2:
        print('Tem que introduzir valores compreendidos entre 1 e 2!')
        conversao = int(input('Indique qual das conversões deseja fazer:\n1º: Cº --> Fº\n2º: Fº --> Cº\n- '))
if conversao == 1:
    C = float(input('Introduza o valor de conversão em Cº:\n- '))
    print('A sua conversão de',C,'Cº é de',conv_C(C),'Fº.')
else:
    F = float(input('Introduza o valor de conversão em Fº:\n- '))
    print('A sua conversão de',F,'Fº é de',conv_F(F),'Cº.')