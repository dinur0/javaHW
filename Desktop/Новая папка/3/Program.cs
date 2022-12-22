Console.WriteLine("Введите кол-во строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ArithmeticMean(FillArray(num1, num2));

double[,] FillArray(int line, int col)
{
    double[,] array = new double[line, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "|");
        }
        Console.WriteLine();
    }
    return array;
}

void ArithmeticMean(double[,] arr)
{
    Console.Write($"Ответ: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double score = 0;
        double temp = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            temp += arr[i,j];
            score = Math.Round(temp/arr.GetLength(0),2);
        }
        Console.Write(score+"|");
    }
}