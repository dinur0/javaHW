Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: {method(a)}");

int method(int size)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next(100, 1000);
        if (array[i]%2==0)
        {
            count++;
        }
    }
    Console.WriteLine(string.Join(",",array));
    return count;
}