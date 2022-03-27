import string

email = input('Introduza o email: ')
while email == "":
    print('O email não pode ser vazio.')
    email = input('Introduza o email: ')

password = input('Introduza a password: ')

num = ['1', '2', '4', '5', '6', '7', '8', '9']
verificacao = []

if len(password) < 8:
    verificacao.append(0)
else:
    verificacao.append(1)

veri = 0
for c in password:
    if c.lower() in list(string.ascii_lowercase):
        veri = 1
        verificacao.append(1)
        break
if veri == 0:
    verificacao.append(0)

veri = 0
for c in password:
    if c in num:
        veri = 1
        verificacao.append(1)
        break
if veri == 0:
    verificacao.append(0)

if email[:email.index('@'):].lower() in password.lower():
    verificacao.append(0)
else:
    verificacao.append(1)

if 0 in verificacao:
    print('Não Segura')
    print(verificacao)
else:
    print('Segura')