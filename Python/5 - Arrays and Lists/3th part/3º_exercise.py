L1 = list(map(int, input().split()))
L2 = input().split()

res = L1 + L2 
res[::2] = L1 
res[1::2] = L2


string = ""

for i in range(len(res)):
    string += str(res[i])

print(string)