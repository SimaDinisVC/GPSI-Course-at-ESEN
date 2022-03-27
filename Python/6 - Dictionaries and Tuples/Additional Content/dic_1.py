
# dicionário vazio
tel={}

tel={'Carlos':964567567,'Sergio':912345345}

#imprimir tamanho do dicionário
print(len(tel))

#adicinar um elemento ao fim do dicionário
tel['Joaquim']=923457896
print(tel)

#modificar o valor da chave "Sergio"
tel['Sergio']=9278954367

print(tel)

print(tel.keys())
print(tel.values())
print(tel.items())
#verifica se a chave Joaquim se encontra no dicionário tel
print('Joaquim' in tel)
#devolve true caso exista e false caso contrário.
#limpa o conteúdo do dicionário
#tel.clear()
#print(tel)
tel2=tel.copy()
#eliminar o item Joaquim
tel2.pop('Joaquim')
print(tel2)