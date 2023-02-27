using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main()
        //{
        //    int x = 120, y = 243, z = 232, v = 121;
        //    Console.WriteLine(FindMin(x, y, z, v));
        //    Console.ReadKey();
        //}
        //static int FindMin(int x, int y, int z, int v)
        //{
        //    return Math.Min(x, Math.Min(y, Math.Min(z, v)));
        //}


        //static void Main()
        //{
        //    int x = 100, y = 200;
        //    Console.WriteLine(FindMax(x, y));
        //    Console.ReadKey();
        //}
        //static int FindMax(int x, int y)
        //{
        //    return Math.Max(x, 2 * y - x) + Math.Max(5 * x + 3 * y, y);
        //}

        //static void Main()
        //{
        //    double a = int.Parse(Console.ReadLine());
        //    double b = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Fx(a) > Fx(b) ? "a" : "b");

        //}

        //static double Fx(double x)
        //{
        //    return Math.Pow(x, 3) + Math.Sin(x);
        //}

        //static void Main()
        //{
        //    double a = int.Parse(Console.ReadLine());
        //    double b = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Fx(a) > Fx(b) ? "a" : "b");

        //}

        //static double Fx(double x)
        //{
        //    return Math.Cos(2 * x) + Math.Sin(x - 3);
        //}

        //static void Main()
        //{
        //    double a = int.Parse(Console.ReadLine());
        //    double b = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Fx(a) > Fx(b) ? "a" : "b");

        //}

        //static double Fx(double x)
        //{
        //    return Math.Cos(2 * x) + Math.Sin(x - 3);
        //}

        //public static double F(double x)
        //{
        //    if (x / 1000 == 0)
        //        return ((x % 1000) % 100) % 10;
        //    else
        //        if (x / 1000 == 0)
        //        return (x % 100) % 10;
        //    else
        //        if (x / 100 == 0)
        //        return x % 10;
        //    else
        //        return x;
        //}
        //static void Main()
        //{
        //    double z;
        //    double a = double.Parse(Console.ReadLine());
        //    double b = double.Parse(Console.ReadLine());
        //    z = F(a) + F(b);
        //    Console.WriteLine(z);
        //}

        //public static double F(double x)
        //{
        //    double tmp = x / 10; // делим на 10 чтобы отбросить первую справа цифру
        //    return tmp % 10; // берем остаток от деления на 10 - те крайнюю правую цифру
        //}

        //static void Main()
        //{

        //    double a = double.Parse(Console.ReadLine());
        //    double b = double.Parse(Console.ReadLine());
        //    double c = double.Parse(Console.ReadLine());
        //    double z = F(a) + F(b) - F(c);
        //    Console.WriteLine(z);

        //}

        //    static void Main(string[] args)
        //    {
        //        var result = 0.0;
        //        var numbers = new double[] { 6, 13, 21 };

        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            result += Method.Calc(numbers[i]) / 2;
        //        }

        //        Console.Write(result);
        //        Console.ReadKey();
        //    }
        //}

        //public class Method
        //{
        //    public static double Calc(double n)
        //    {
        //        return Math.Sqrt(n) + n;
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    double x = double.Parse(Console.ReadLine());
        //    Console.WriteLine(Perform(2, x) + Perform(4, x) + Perform(6, x));
        //}

        //static public double Perform(int n, double x)
        //{
        //    return Math.Pow(x, n) / n;
        //}

        //static void Main(string[] args)
        //{
        //    double a = double.Parse(Console.ReadLine());
        //    Console.WriteLine(Perform(a));
        //}

        //static public double Perform(double x)
        //{
        //    if (x % 10 == 0)
        //    {
        //        return x / 2;
        //    }
        //    else

        //        x = 0;
        //    return x;

        //}

        //static void Main(string[] args)
        //{
        //    double a = double.Parse(Console.ReadLine());
        //    Console.WriteLine(Perform(a));
        //}

        //static public double Perform(double x)
        //{
        //    if (x % 5 == 0)
        //    {
        //        return x / 5;
        //    }
        //    else

        //        return x - 1;

        //}

        //static void Main()
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Reverse(a));
        //    Console.ReadKey();
        //}

        //static int Reverse(int x)
        //{
        //    return x > 9 && x < 100 ? x / 10 + x % 10 * 10 : x;

        //}


        //static void Main(string[] args)
        //{
        //    string m = "123";
        //    Console.WriteLine(res(m));
        //    Console.ReadLine();
        //}
        //static string res(string s)
        //{
        //    char[] n = s.ToArray();
        //    n = n.Reverse().ToArray();
        //    string str = null;
        //    foreach (char ch in n)
        //        str = string.Concat(str, ch);
        //    return str;
        //}


        //public static double f(double a, double b) => Math.Sqrt(a * a + b * b);
        //static void Main(string[] args)
        //{
        //    double AB = 10, AC = 15, CD = 5;
        //    Console.WriteLine(f(f(AB, AC), CD));
        //}

        //static void Main(string[] args)
        //{
        //    double s1, s2, s3, s, p1, p2, p3;
        //    int a, b, c, d, e, f, g;

        //    Console.Write("Сторона a=");
        //    a = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Сторона b=");
        //    b = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Сторона c=");
        //    c = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Сторона d=");
        //    d = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Сторона e=");
        //    e = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Сторона f=");
        //    f = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Сторона g=");
        //    g = Convert.ToInt32(Console.ReadLine());

        //    p1 = (a + b + f) / 2;
        //    p2 = (f + g + c) / 2;
        //    p3 = (e + g + d) / 2;

        //    s1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - f)); // площадь треугольника a,b,f
        //    s2 = Math.Sqrt(p2 * (p2 - f) * (p2 - g) * (p2 - c)); // площадь треугольника f,g,c
        //    s3 = Math.Sqrt(p3 * (p3 - e) * (p3 - g) * (p3 - d)); // площадь треугольника e,g,d
        //    s = s1 + s2 + s3;

        //    Console.WriteLine("Площадь пятиугольника равна = {0:F3}", s);
        //    Console.ReadKey();



        //}


        //static double f(double x1, double y1, double x2, double y2)
        //{

        //    return Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 1 / 2);
        //}

        //static double d(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //static void Main(string[] args)
        //{
        //    int x1, y1, x2, y2, x3, y3;
        //    Console.Write("x1=");
        //    x1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("y1=");
        //    y1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("x2=");
        //    x2 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("y2=");
        //    y2 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("x3=");
        //    x3 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("y3=");
        //    y3 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(d(f(x1, y1, x2, y2), f(x2, y2, x3, y3), f(x3, y3, x1, y1)));

        //}

        //static double f(double x1, double y1, double x2, double y2)
        //{

        //    double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        //    return L;

        //}

        //static double max(double a, double b)
        //{
        //    if (a > b)
        //        return a;
        //    return b;
        //}

        //static void Main(string[] args)

        //{
        //    Console.Write("x1=");
        //    double x1 = double.Parse(Console.ReadLine());
        //    Console.Write("y1=");
        //    double y1 = double.Parse(Console.ReadLine());
        //    Console.Write("x2=");

        //    double x2 = double.Parse(Console.ReadLine());
        //    Console.Write("y2=");

        //    double y2 = double.Parse(Console.ReadLine());
        //    double d1 = f(x1, y1, 0.0, 0.0);
        //    double d2 = f(x2, y2, 0.0, 0.0);

        //    double dmax = max(d1, d2);
        //    if (dmax == d1)
        //    {
        //        Console.WriteLine("Точка 1 наиболее удалена от начала координат.");
        //    }
        //    else if (dmax == d2)
        //    {
        //        Console.WriteLine("Точка 2 наиболее удалена от начала координат.");
        //    }
        //}

        //static double f(double x1, double y1, double x2, double y2)
        //{

        //    double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        //    return L;

        //}

        //static double min(double a, double b)
        //{
        //    if (a < b)
        //        return a;
        //    return b;
        //}

        //static void Main(string[] args)

        //{
        //    Console.Write("x1=");
        //    double x1 = double.Parse(Console.ReadLine());
        //    Console.Write("y1=");
        //    double y1 = double.Parse(Console.ReadLine());
        //    Console.Write("x2=");

        //    double x2 = double.Parse(Console.ReadLine());
        //    Console.Write("y2=");

        //    double y2 = double.Parse(Console.ReadLine());
        //    double d1 = f(x1, y1, 0.0, 0.0);
        //    double d2 = f(x2, y2, 0.0, 0.0);

        //    double dmax = min(d1, d2);
        //    if (dmax == d1)
        //    {
        //        Console.WriteLine("Точка 1 ");
        //    }
        //    else if (dmax == d2)
        //    {
        //        Console.WriteLine("Точка 2 ");
        //    }
        //}
    }
}
