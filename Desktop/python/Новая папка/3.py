print ('Введите шестизначный номер билета')
g = int(input())
if g>=100000 and g<=999999:
    a = g//1000
    b = g%1000
    firstSumm = a//100+a%100//10+a%10
    secondHalf = b//100+b%100//10+b%10
    if firstSumm==secondHalf:
        print ('yes')
    else:
        print ('no')
else:
    print ('Билет должен быть шестизначным')
