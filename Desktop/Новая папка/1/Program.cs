Console.WriteLine("Введите кол-во строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
FillArray(num1, num2);

double[,] FillArray(int line, int col)
{
    double[,] array = new double[line, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-10, 11) + new Random().NextDouble(), 1);
            Console.Write(array[i, j] + "|");
        }
        Console.WriteLine();
    }
    return array;
}

