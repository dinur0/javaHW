
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index <= x)
{
    Console.WriteLine(Math.Pow(index,3));
    index++;
}

