Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (res < a-1)
{
    res = res+2;
    Console.Write(res);
    Console.Write(",");
}