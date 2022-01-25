import math
def pitagoras(cateto1, cateto2):
    quadrado_hipotenusa = (cateto1  * cateto1) + (cateto2 * cateto2)
    hipotenusa = math.sqrt(quadrado_hipotenusa)
    hipotenusa = "{0:.2f}".format(hipotenusa)
    return(hipotenusa)
    hipotenusa = float(hipotenusa)
    perimetro = cateto1 + cateto2 + hipotenusa
    return(perimetro)
lado1 = float(input("Introduza a medida do primeiro cateto: "))
lado2 = float(input("Introduza a medida do segundo cateto: "))
pitagoras(lado1, lado2)