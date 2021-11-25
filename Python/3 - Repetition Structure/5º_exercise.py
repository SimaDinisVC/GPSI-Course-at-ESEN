#############################MENU#####################################
menu = ("Para votar para as listas da escola existem as seguintes condições,\nDigite:\n A- Lista A\n B- Lista B\n C- Lista C\n Branco- Voto em Branco\n")
######################################################################
urnas = "abertas"
ListaA = 0
ListaB = 0
ListaC = 0
Branco = 0
while urnas == "abertas":
    print(menu)
    votos = input("")
    votos.lower()
    if votos == "A":
        ListaA = ListaA + 1
    elif votos == "B":
        ListaB = ListaB + 1
    elif votos == "C":
        ListaC = ListaC + 1
    elif votos == "Branco":
        Branco = Branco + 1
    elif votos == "0":
        urnas = "fechadas"
######################################################################
print("Existe",ListaA,"votos para a lista A,",ListaB,"votos para a lista B,",ListaC,"votos para a lista C e",Branco,"votos em branco.")
######################################################################
if ListaA > ListaB and ListaA > ListaC:
    print("Lista A é a Vencedora!")
elif ListaB > ListaA and ListaB > ListaC:
    print("Lista B é a Vencedora!")
elif ListaC > ListaA and ListaC > ListaB:
    print("Lista C é a Vencedora!")
else:
    print("Empate!")
############################NºDEVOTOS#################################
n_de_votos = ListaA + ListaB + ListaC + Branco
print(n_de_votos,"votos no Total.")
###########################PERCENTAGEM################################
percentagemA = (ListaA * 100)/3
percentagemB = (ListaB * 100)/3
percentagemC = (ListaC * 100)/3
if ListaA > ListaB and ListaA > ListaC:
    print("Com",round(percentagemA,2),"% dos votos.")
elif ListaB > ListaA and ListaB > ListaC:
    print("Com",round(percentagemB,2),"% dos votos.")
elif ListaC > ListaA and ListaC > ListaB:
    print("Com",round(percentagemC,2),"% dos votos.")