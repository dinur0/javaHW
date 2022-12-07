Console.WriteLine("Введите 5-значное число");
string array = Convert.ToString(Console.ReadLine());
if (array.Length == 5)
{
    if (array[0]==array[4] && array[1]==array[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Число НЕ пятизначное");
}