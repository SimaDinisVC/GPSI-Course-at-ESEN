pessoal = [
    {
        'nome':'Pedro Costa',
        'localidade':'Vila Chã de Sá',
        'skills':["Python", "PHP", "Pascal"]
    },
    {
        'nome':'Martinho Lareira',
        'localidade':'Abraveses',
        'skills':['Brainfuck', 'Ruby']
    },
    {
        'nome':'Armando Cabral',
        'localidade':'Pascoal',
        'skills':['Pascal','C#', "VB"]
        
    },
    {
        'nome':'Fernando Pessoa',
        'localidade':'Rio de Loba',
        'skills':['Java', 'Javascript']
    },

    {
        'nome':'Bernando Pinheiro',
        'localidade':'Gumirães',
        'skills':['Java', "PHP", "Ruby", "Python"]
    }
    
]

#for i in range(len(pessoal)):
    #print(pessoal[i]['nome'])

indexesc = 2


for o in range(len(pessoal[indexesc])):
    print(list(pessoal[indexesc].keys())[o],':',pessoal[indexesc].get(list(pessoal[indexesc].keys())[o]))

