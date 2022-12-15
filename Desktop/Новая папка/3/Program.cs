Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: {method(a)}");

double method(int size)
{
    double[] array = new double[size];
    // int max = 0;
    // int min = 0;
    for (int i = 0; i < size; i++)
    {
        array[i]=Math.Round(new Random().Next(1, 10)+new Random().NextDouble(),3);
        
    }

    Console.WriteLine(string.Join("|",array));
    Console.WriteLine($"Макс: {array.Max()}");
    Console.WriteLine($"Мин: {array.Min()}");
    return (array.Max()-array.Min());
}