import math
def pitagoras(cateto1, cateto2):
    while cateto1 < 0:
        cateto1 = float(input("Cateto 1 negativo! Reintroduza o valor: "))
    while cateto2 < 0:
        cateto2 = float(input("Cateto 2 negativo! Reintroduza o valor: "))
    quadrado_hipotenusa = (cateto1  * cateto1) + (cateto2 * cateto2)
    hipotenusa = math.sqrt(quadrado_hipotenusa)
    hipotenusa = "{0:.2f}".format(hipotenusa)
    print("No caso do triângulo ser retângulo, a hipotenusa é {}!".format(hipotenusa))
    hipotenusa = float(hipotenusa)
    perimetro = cateto1 + cateto2 + hipotenusa
    print("O perímetro é {}.".format(perimetro))
lado1 = float(input("Introduza a medida do primeiro cateto: "))
lado2 = float(input("Introduza a medida do segundo cateto: "))
pitagoras(lado1, lado2)