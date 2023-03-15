letters = ["а", "я", "у", "ю", "о", "е", "ё", "э", "и", "ы"]

def countLetters(x):
    count=0
    for i in x:
        if i in letters:
            count+=1
    return count
def same(р):
    return len(set(р)) <= 1

b = input().split()
c = list(map(countLetters,b))
if same(c)==True:
    print("Парам пам-пам")
else:
    print("Пам парам")
