int SumNumbers(int number1, int number2)
{
if (number1<number2)
{
return SumNumbers(number1+1, number2)+number1;
}
else if (number1>number2)
{
return SumNumbers(number1-1, number2)+number1;
}
else return number1;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(num1, num2));