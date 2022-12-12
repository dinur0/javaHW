Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: {method(a)}");




int method(int number)
{
    string strnum = Convert.ToString(number);
    int[] b = new int[strnum.Length];
    int sum = 0;
    for (int i = 0; i < strnum.Length; i++)
    {
        b[i] = Convert.ToInt32(strnum[i].ToString());
        sum += b[i];
    }
    return sum;
}
