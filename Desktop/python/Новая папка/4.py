111
111
print ('Введите длину плитки')
a = int(input())
print ('Введите ширину плитки')
b = int(input())
print ('Введите желаемый кусок плитки')
k = int(input())
if k%a==0 or k%b==0:
    print ('yes')
else:
    print ('no')