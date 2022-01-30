#Zona das Funções
def multiplo(valor1,valor2):
    ve_multiplo1 = valor1 % valor2
    ve_multiplo2 = valor2 % valor1
    if ve_multiplo1 == 0:
        multiplo1 = True  
    else:
        multiplo1 = False
    if ve_multiplo2 == 0:
        multiplo2 = True
    else:
        multiplo2 = False
    return(multiplo1, multiplo2)
#Zona Principal
int1 = int(input('Introduza o primeiro valor:\n- '))
int2 = int(input('Introduza o segundo valor:\n- '))
multiplo1, multiplo2 = multiplo(int1, int2)
if multiplo1 == True:
    check1 = 'é'
else:
    check1 = 'não é'
if multiplo2 == True:
    check2 = 'é'
else:
    check2 = 'não é'
print('O',int1, check1,'multiplo de',int2,'e',int2, check2,'multiplo de {}.'.format(int1))