import string

email = input('Introduza o email: ')
while email == "":
    print('O email não pode ser vazio.')
    email = input('Introduza o email: ')

password = input('Introduza a password: ')

num = ['1', '2', '4', '5', '6', '7', '8', '9']

if len(password) < 8:
    print('Não segura')
    exit()

veri = 0
veri2 = 0
for c in password:
    if c.lower() in list(string.ascii_lowercase):
        veri = 1
    if c in num:
        veri = 1
if veri == 0:
    print('Não segura')
    exit()
if veri2 == 0:
    print('Não segura')
    exit()

if email[:email.index('@'):].lower() in password.lower():
    print('Não segura')
    exit()

print('Segura')