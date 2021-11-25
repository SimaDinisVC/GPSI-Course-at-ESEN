#variaveis
comp_sala = int(input("Indique o comprimento da sala/divisão:\n"))
larg_sala = int(input("Indique a largura da sala/divisão:\n"))
comp_tijoleira = int(input("Indique o comprimento da tijoleira:\n"))
larg_tijoleira = int(input("Indique a largura da tijuleira:\n"))
#processamento
largura = larg_sala/larg_tijoleira
comprimento = comp_sala/comp_tijoleira
resultado = largura * comprimento
#saida de dados
print("Você vai precisar de",resultado,"tiojoleira(s)")