s = int(input("Введите сумму "))
p = int(input("Введите произведение "))
first=0
second=0

while first*second!=p:
    first+=1
    second=s-first
    if first*second==p:
        print(f"Ответ: {first,second}")