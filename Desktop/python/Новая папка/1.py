import random
n = int(input("Введите кол-во монет "))
array = ""
countO = 0
countP = 0
for i in range(n):
    array += random.choice("OP")
    if array[i]=="O":
        countO +=1
    else:
        countP +=1
print (array)
if countO>countP:
    print (f"Надо перевернуть {countP}")
else:
    print (f"Надо перевернуть {countO}")


