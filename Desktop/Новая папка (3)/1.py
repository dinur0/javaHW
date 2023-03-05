def func(x,y):
    if y==1:
        return x
    x=func(x,y-1)*x
    return x

a=int(input("Введите первое число:"))
b=int(input("Введите второе число:"))
print("Ответ: ",func(a,b))