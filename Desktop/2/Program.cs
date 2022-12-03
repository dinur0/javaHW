Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 && num > -100)
{
    Console.WriteLine("У числа нет третьей цифры");
}
while (num >= 1000 || num <= -1000)
{
    num = num / 10;
}
num = num % 10;
Console.WriteLine(num);