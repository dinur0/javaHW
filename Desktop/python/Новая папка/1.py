import random
n = int(input("Введите кол-во элементов: "))
array = []
x = int(input("Введите число: "))
count = 0
for i in range(n):
    array.append(int(input("Введите элемент массива: ")))
    if array[i]==x:
        count+=1
print(*array)
print(f"Ответ: {count}")
