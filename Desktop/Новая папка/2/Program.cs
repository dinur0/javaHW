Console.WriteLine("Введите кол-во строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки: ");
int IndexLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int IndexCol = Convert.ToInt32(Console.ReadLine());
ShowNumber(FillArray(line, col), IndexLine, IndexCol);

int[,] FillArray(int first, int second)
{
    int[,] array = new int[first, second];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + "|");
        }
        Console.WriteLine();
    }
    return array;
}

void ShowNumber(int[,] arr, int num1, int num2)
{
    if (num1 <= arr.GetLength(0) || num2 <= arr.GetLength(1))
    {
       Console.WriteLine($"Число: {arr[num1-1, num2-1]}"); //добавил (- 1)
    }
    else
    {
    Console.WriteLine("Такого числа нет");
    }
}