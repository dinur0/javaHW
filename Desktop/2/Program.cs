Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine("Максимальное число - первое:");
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine("Максимальное число - третье:");
        Console.WriteLine(c);
    }
}
else if (b>c)
{
    Console.WriteLine("Максимальное число - второе:");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Максимальное число - третье:");
    Console.WriteLine(c);
}