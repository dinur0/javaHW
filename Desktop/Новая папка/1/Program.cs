// Console.WriteLine("Введите количество цифр: ");
// int size = Convert.Toint32(Console.ReadLine());
// Console.WriteLine(String.Join(",",createArrayAndCount(size)));

// int[] createArrayAndCount(int num)
// {
//     int[] array = new int [num];
//     int count = 0;
// for (int i = 0; i < num; i++)
// {
//     Console.WriteLine($"Введите число №{i+1}: ");
//     array[i] = Convert.Toint32(Console.ReadLine());
//     if (array[i]>0) // 0-положительное число?
//     {
//         count++;
//     }
// }
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine($"Положительных чисел: {count}");
// return array;
// }

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



// double[,] FillArray(int first, int second)
// {
// double[,] array = new double[first, second];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j]= Math.Round(new Random().Next(-10,11)+ new Random().NextDouble(),1);
//             Console.Write(array[i,j]+"|");
//         }
//         Console.WriteLine(array);
//     }
//     return array;
// }
