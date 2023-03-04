def fillArray(number):
    array = []
    for j in range(number):
        array.append(int(input("Введите элемент массива: ")))
    return array

a = int(input("Введите кол-во первого множества: "))
list1 = fillArray(a)
b = int(input("Введите кол-во второго множества: "))
list2 = fillArray(b)
result = []
for i in list1:
    if i in list2:
        result.append(i)
list.sort(result)
print(*result)
