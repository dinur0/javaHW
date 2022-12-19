Console.WriteLine("Введите первую координату первой линии: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой линии: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите превую координату второй линии: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй линии: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: {String.Join("|",pointSearch(b1, k1, b2, k2))}");
double[] pointSearch(double numb1, double numk1, double numb2, double numk2)
{
    double x = (numb2-numb1) / (numk1-numk2);
    double[] array = new double [2];
    array[0] = numk1*x+numb1;
    array[1] = numk2*x+numb2;
    return array;
}