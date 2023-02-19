print ('Введите 3-х значное число')
g = int(input())
if g<100 or g>999:
    print ('Введено неправильное число')
else:
    a = g//100
    b = g%100//10
    c = g%10
    print(f"{a}+{b}+{c}")
    print (a+b+c)