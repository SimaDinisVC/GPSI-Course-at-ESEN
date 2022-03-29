import string

email = input('Introduza o email: ')
while email == "":
    print('O email não pode ser vazio.')
    email = input('Introduza o email: ')

password = input('Introduza a password: ')

numeros = '1234567890'
letras = str(string.ascii_lowercase)
veri = 0
veri2 = 0

for c in password:
    if c.lower() in letras:
        veri = 1
    if c in numeros:
        veri2 = 1
if veri == 0:
    print('Não segura')
    exit()
if veri2 == 0:
    print('Não segura')
    exit()
        
if len(password) < 8:
    print('Não segura')
    exit()

if email[:email.index('@'):].lower() in password.lower():
    print('Não segura')
    exit()

print('Segura')