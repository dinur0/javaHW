def fillArray(number):
    array = []
    for j in range(number):
        array.append(int(input("Введите элемент массива: ")))
    return array

def indexAdd(abr):
    counts = []
    for i in range(len(abr)):
        counts.append([i,abr[i]])
    return counts

    
num = int(input("Введите кол-во: "))
list = fillArray(num)
a = int(input("Введите минимальное число: "))
b = int(input("Введите максимальное число: "))
counts = []
for i in range(len(list)):
    counts.append([i,list[i]])
print(list)
for i in counts:
    if a<=i[1]<=b:
        print(i[0], end=" ")

