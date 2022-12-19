Console.WriteLine("Введите количество цифр: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(String.Join(",",createArrayAndCount(size)));

int[] createArrayAndCount(int num)
{
    int[] array = new int [num];
    int count = 0;
for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Введите число №{i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) // 0-положительное число?
    {
        count++;
    }
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine($"Положительных чисел: {count}");
return array;
}