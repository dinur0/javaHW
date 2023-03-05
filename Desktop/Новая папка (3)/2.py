def sum(x,y):
    if y==0:
        return x
    x=sum(x+1,y-1)
    return x

a=int(input("Введите первое число:"))
b=int(input("Введите второе число:"))
print("Ответ: ",sum(a,b))
    
