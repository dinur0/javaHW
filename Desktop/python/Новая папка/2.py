import random
n = int(input("Введите кол-во кустов: "))
list = []
for i in range(n):
    list.append(random.randint(1,10))
count = list[-2]+list[-1]+list[0]
for i in range(len(list)-1):
    if count<list[i-1]+list[i]+list[i+1]:
        count=list[i-1]+list[i]+list[i+1]       
print(list)
print(count)
    
