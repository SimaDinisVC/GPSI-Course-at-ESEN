#variaveis
pequenas = int(input("Quantidade de camisolas pequenas que vendeu:\n"))
medias = int(input("Quantidade de camisolas médias que vendeu:\n"))
grandes = int(input("Quantidade de camisolas grandes que vendeu:\n"))
#processamento
res_pequenas = pequenas * 10
res_medias = pequenas * 12
res_grandes = grandes * 15
#saida de dado
print("Vendeu no total",res_pequenas+res_medias+res_grandes,"€")