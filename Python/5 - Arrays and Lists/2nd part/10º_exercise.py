xp, yp = input().split()
xc, yc = input().split()
r = int(input())
xp = int(xp)
xc = int(xc)
yp = int(yp)
yc = int(yc)
if xp < xc + r and xp > xc - r and yp < yc + r and yp > yc - r:
    print(1)
else:
    print(0)