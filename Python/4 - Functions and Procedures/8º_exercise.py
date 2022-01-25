#Zona das Funções
def quadrado(n):
    nq = n**2
    return(nq)
#FIM Zona das Funções
#Zona Principal
n = int(input("Introduza o número para calcular o seu quadrado: "))
q = quadrado(n)
print("O quadrado de",n,"é",q)