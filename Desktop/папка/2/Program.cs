Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: {method(a)}");




int method(int number)
{
    string strmun = Convert.ToString(number);
    int[] b = new int[strmun.Length];
    int sum = 0;
    for (int i = 0; i < strmun.Length; i++)
    {
        b[i] = Convert.ToInt32(strmun[i].ToString());
        sum += b[i];
    }
    return sum;
}
