int Akkerman(int m, int n)
{
if (m==0) return n+1;
else if (m>0 && n==0) return Akkerman(m-1,1);
else if (m>0 && n>0) return Akkerman(m-1, Akkerman(m,n-1));
return 0;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(num1, num2));