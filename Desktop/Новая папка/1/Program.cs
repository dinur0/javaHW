void ShowNumbers(int number)
{
    if (number>0)
    {
        Console.Write(number+" ");
        ShowNumbers(number-1);
    }
}

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num1);
