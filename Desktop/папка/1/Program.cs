Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ:{method(a,b)}");

int method(int number1, int number2)
{
    int sum = number1;
    for (int i = 0; i < number2-1; i++)
    {
      sum *= a;
    }
    return sum;
}