import random
n = int(input("Введите кол-во элементов: "))
list = []
for i in range(n):
    list.append(int(input("Введите элемент массива: ")))
x = int(input("Введите число: "))
diffList = []
diffList.extend(list)
for y in range(n):
    diffList[y]=x-list[y]
    if diffList[y]<0:
        diffList[y]*=-1
print(list[diffList.index(min(diffList))])
print(*list)




