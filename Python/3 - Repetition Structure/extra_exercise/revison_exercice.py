manha = 0
tarde = 0
noite = 0
#
A = 0
B = 0
C = 0
#
periodom_com_elevadora = 0
periodom_com_elevadorb = 0
periodom_com_elevadorc = 0
periodot_com_elevadora = 0
periodot_com_elevadorb = 0
periodot_com_elevadorc = 0
periodon_com_elevadora = 0
periodon_com_elevadorb = 0
periodon_com_elevadorc = 0
#
for i in range(1,51):
    elevador = "L"
    while elevador != "A" and elevador != "B" and elevador != "C":
        elevador = str(input("Indique qual o elevador utiliza com mais frequência:\nA - Elevador A\nB - Elevador B\nC - Elevador C\n-")).upper()
    #
    if elevador == "A":
        A = A + 1
    elif elevador == "B":
        B = B + 1
    elif elevador == "C":
        C = C + 1
    #
    periodo = "L"
    while periodo != "m" and periodo != "t" and periodo != "n":
        periodo = input("Indique qual o período que utiliza com mais frequência:\nM - Manhã\nT - Tarde\nN - Noite\n-").lower()
    #
    if periodo == "m":
        manha = manha + 1
    elif periodo == "t":
        tarde = tarde + 1
    elif periodo == "n":
        noite = noite + 1
    #
    if elevador == "A" and periodo == "m":
        periodom_com_elevadora = periodom_com_elevadora + 1
    elif elevador == "B" and periodo == "m":
        periodom_com_elevadorb = periodom_com_elevadorb + 1
    elif elevador == "C" and periodo == "m":
        periodom_com_elevadorc = periodom_com_elevadorc + 1
    if elevador == "A" and periodo == "t":
        periodot_com_elevadora = periodot_com_elevadora + 1
    elif elevador == "B" and periodo == "t":
        periodot_com_elevadorb = periodot_com_elevadorb + 1
    elif elevador == "C" and periodo == "t":
        periodot_com_elevadorc = periodot_com_elevadorc + 1
    if elevador == "A" and periodo == "n":
        periodon_com_elevadora = periodon_com_elevadora + 1
    elif elevador == "B" and periodo == "n":
        periodon_com_elevadorb = periodon_com_elevadorb + 1
    elif elevador == "C" and periodo == "n":
        periodon_com_elevadorc = periodon_com_elevadorc + 1
#Pergunta 1
if A > B and A > C:
    elevadorMfreq = ("é o A,")
elif B > A and B > C:
    elevadorMfreq = ("é o B,")
elif C > A and C > B:
    elevadorMfreq = ("é o C,")
else:
    elevadorMfreq = ("Ocorreu um empate!")
#
if elevadorMfreq == "é o A,":
    if periodom_com_elevadora > periodot_com_elevadora and periodom_com_elevadora > periodon_com_elevadora:
        periodoMfreq_noelevadorMfreq = "A foi a manhã."
    elif periodot_com_elevadora > periodom_com_elevadora and periodot_com_elevadora > periodon_com_elevadora:
        periodoMfreq_noelevadorMfreq = "A foi a tarde."
    elif periodon_com_elevadora > periodot_com_elevadora and periodon_com_elevadora > periodom_com_elevadora:
        periodoMfreq_noelevadorMfreq = "A foi a noite."
    else:
        periodoMfreq_noelevadorMfreq = "A não foi nenhum pois ocorreu um empate nos elevadores."
elif elevadorMfreq == "é o B,":
    if periodom_com_elevadorb > periodot_com_elevadorb and periodom_com_elevadorb > periodon_com_elevadorb:
        periodoMfreq_noelevadorMfreq = "B foi a manhã."
    elif periodot_com_elevadorb > periodom_com_elevadorb and periodot_com_elevadorb > periodon_com_elevadorb:
        periodoMfreq_noelevadorMfreq = "B foi a tarde."
    elif periodon_com_elevadorb > periodot_com_elevadorb and periodon_com_elevadorb > periodom_com_elevadorb:
        periodoMfreq_noelevadorMfreq = "B foi a noite."
    else:
        periodoMfreq_noelevadorMfreq = "B não foi nenhum pois ocorreu um empate nos elevadores."
elif elevadorMfreq == "é o C,":
    if periodom_com_elevadorb > periodot_com_elevadorb and periodom_com_elevadorb > periodon_com_elevadorb:
        periodoMfreq_noelevadorMfreq = "C foi a manhã."
    elif periodot_com_elevadorb > periodom_com_elevadorb and periodot_com_elevadorb > periodon_com_elevadorb:
        periodoMfreq_noelevadorMfreq = "C foi a tarde."
    elif periodon_com_elevadorb > periodot_com_elevadorb and periodon_com_elevadorb > periodom_com_elevadorb:
        periodoMfreq_noelevadorMfreq = "C foi a noite."
    else:
        periodoMfreq_noelevadorMfreq = "C não foi nenhum pois ocorreu um empate nos elevadores."
else:
    periodoMfreq_noelevadorMfreq = "também não foi nenhum pois ocorreu o empate!"
#
print("O elevador mais frequentado",elevadorMfreq,"o periodo com mais fluxo no elevador",periodoMfreq_noelevadorMfreq)
#Pergunta 1 Fim
#Pergunta 2
if manha > tarde and manha > noite:
    periodoMfreq = "é a manhã,"
elif tarde > manha and tarde > noite:
    periodoMfreq = "é a tarde,"
elif noite > manha and noite > tarde:
    periodoMfreq = "é a noite,"
else:
    periodoMfreq = "não foi nenhum pois ocorreu um empate, assim como"
#
if periodoMfreq == "é a manhã,":
    if periodom_com_elevadora > periodom_com_elevadorb and periodom_com_elevadora > periodom_com_elevadorc:
        elevadorMfreq_noperiodoMfreq = "da manhã é o Elevador A."
    elif periodom_com_elevadorb > periodom_com_elevadora and periodom_com_elevadorb > periodom_com_elevadorc:
        elevadorMfreq_noperiodoMfreq = "da manhã é o Elevador B."
    elif periodom_com_elevadorc > periodom_com_elevadora and periodom_com_elevadorc > periodom_com_elevadorb:
        elevadorMfreq_noperiodoMfreq = "da manhã é o Elevador C."
    else:
        elevadorMfreq_noperiodoMfreq = "da manhã não foi nenhum pois ocorreu um empate no periodo."
elif periodoMfreq == "é a tarde,":
    if periodot_com_elevadora > periodot_com_elevadorb and periodot_com_elevadora > periodot_com_elevadorc:
        elevadorMfreq_noperiodoMfreq = "da tarde é o Elevador A."
    elif periodot_com_elevadorb > periodot_com_elevadora and periodot_com_elevadorb > periodot_com_elevadorc:
        elevadorMfreq_noperiodoMfreq = "da tarde é o Elevador B."
    elif periodot_com_elevadorc > periodot_com_elevadora and periodot_com_elevadorc > periodot_com_elevadorb:
        elevadorMfreq_noperiodoMfreq = "da tarde é o Elevador C."
    else:
        elevadorMfreq_noperiodoMfreq = "da tarde não foi nenhum pois ocorreu um empate no periodo."
elif periodoMfreq == "é a noite,":
    if periodon_com_elevadora > periodon_com_elevadorb and periodon_com_elevadora > periodon_com_elevadorc:
        elevadorMfreq_noperiodoMfreq = "da noite é o Elevador A."
    elif periodon_com_elevadorb > periodon_com_elevadora and periodon_com_elevadorb > periodon_com_elevadorc:
        elevadorMfreq_noperiodoMfreq = "da noite é o Elevador B."
    elif periodon_com_elevadorc > periodon_com_elevadora and periodon_com_elevadorc > periodon_com_elevadorb:
        elevadorMfreq_noperiodoMfreq = "da noite é o Elevador C."
    else:
        elevadorMfreq_noperiodoMfreq = "da noite não foi nenhum pois ocorreu um empate no periodo."
else:
    elevadorMfreq_noperiodoMfreq = "também não foi nenhum pois ocorreu o empate!"
#
print("O perido mais frequentado",periodoMfreq,"o elevador mais utilizado no periodo",elevadorMfreq_noperiodoMfreq)
#Pergunta 2 Fim
#Pergunta 3 - Percentagem
if manha >= tarde and manha >= noite:
    periodoMfreq = manha
elif tarde >= manha and tarde >= noite:
    periodoMfreq = tarde
elif noite >= manha and noite >= tarde:
    periodoMfreq = noite
else:
    periodoMfreq = -1
if manha <= tarde and manha <= noite:
    periodomfreq = manha
elif tarde <= manha and tarde <= noite:
    periodomfreq = tarde
elif noite <= manha and noite <= tarde:
    periodomfreq = noite
else:
    periodomfreq = -1
#
UtilizacoesPeriodos = manha + tarde + noite
if periodoMfreq != -1 and periodomfreq != -1:
    percent_M_usado = (periodoMfreq * 100) / UtilizacoesPeriodos
    percent_m_usado = (periodomfreq * 100) / UtilizacoesPeriodos
    diferenca_percentual = percent_M_usado - percent_m_usado
    print("A diferença percentual de periodos é de {}%.".format(round(diferenca_percentual,2)))
else:
    print("Não exite dados com amplitude entre si.")
#Pergunta 3 - Percentagem Fim
#Pergunta 4
if A > B and A < C:
    elevadormediafreq = A
elif A < B and A > C:
    elevadormediafreq = A
elif B > A and B < C:
    elevadormediafreq = B
elif B < A and B > C:
    elevadormediafreq = B
elif C > A and C < B:
    elevadormediafreq = C
elif C < A and C > B:
    elevadormediafreq = C
else:
    elevadormediafreq = -1
#
UtilizacoesElevadores = A + B + C
if elevadormediafreq != -1:
    percent_elevador_medio = (elevadormediafreq * 100) / UtilizacoesElevadores
    print("A percentagem sobre o total de serviços prestados do elevador de média utilização é de {}%".format(round(percent_elevador_medio,2)))
else:
    print("Não exite dados de elevadores com posição intermédia.")
#Pergunta 4 Fim