Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a==1 || a==2 || a==3 || a==4 || a==5)
{
    Console.WriteLine("нет");
}
else if (a==6 || a==7)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("такого дня недели не существует");
}