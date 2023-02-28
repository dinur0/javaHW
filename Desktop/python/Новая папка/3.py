

w = input("Введите слово: ")
count = 0
for i in range(len(w)):
    if w[i] == "A" or w[i]== "E" or w[i]== "I" or w[i]== "O" or w[i]== "U" or w[i]== "L" or w[i]== "N" or w[i]== "S" or w[i]== "T" or w[i]== "R":
        count+=1
    elif w[i] == "D" or w[i]== "G":
        count+=2
    elif w[i] == "B" or w[i]== "C" or w[i]== "M" or w[i]== "P":
        count+=3
    elif w[i] == "F" or w[i]== "H" or w[i]== "V" or w[i]== "W" or w[i]== "Y":
        count+=4
    elif w[i] == "K":
        count+=5
    elif w[i] == "J" or w[i]== "X":
        count+=8
    elif w[i] == "Q" or w[i]== "Z":
        count+=10
    elif w[i]=="А" or w[i]=="В" or w[i]=="Е" or w[i]=="И" or w[i]=="Н" or w[i]=="О" or w[i]=="Р" or w[i]=="С" or w[i]=="Т":
        count+=1
    elif w[i]=="Д" or w[i]=="К" or w[i]=="Л" or w[i]=="М" or w[i]=="П" or w[i]=="У":
        count+=2
    elif w[i]=="Б" or w[i]=="Г" or w[i]=="Ё" or w[i]=="Ь" or w[i]=="Я":
        count+=3
    elif w[i]=="Й" or w[i]=="Ы":
        count+=4
    elif w[i]=="Ж" or w[i]=="З" or w[i]=="Х" or w[i]=="Ц" or w[i]=="Ч":
        count+=5
    elif w[i]=="Ш" or w[i]=="Э":
        count+=8
    elif w[i]=="Ф" or w[i]=="Щ" or w[i]=="Ъ":
        count+=10
    else:
        print("Введите заглавную букву")
        count=0
        break
print(count)