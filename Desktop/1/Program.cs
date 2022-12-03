Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    num = num / 10 % 10;
    Console.WriteLine(num);
}
