int[] x = new int[6];
System.Console.WriteLine("Введите координаты первой точки: ");
x[0] = Convert.ToInt32(Console.ReadLine());//x1
x[1] =  Convert.ToInt32(Console.ReadLine());//y1
x[2] =  Convert.ToInt32(Console.ReadLine());//z1
System.Console.WriteLine("Введите координаты второй точки: ");
x[3] =  Convert.ToInt32(Console.ReadLine());//x2
x[4] =  Convert.ToInt32(Console.ReadLine());//y2
x[5] =  Convert.ToInt32(Console.ReadLine());//z2
Console.WriteLine(Math.Sqrt(Math.Pow(x[3]-x[0],2)+Math.Pow(x[4]-x[1],2)+Math.Pow(x[5]-x[2],2)));
