using System;
class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();
        Ex06();
        Ex07();
        Ex08();
        Ex09();
        Ex10();
    }
    static void Ex01()
    {
        int a = 5, b = 7;
        int c = a + b;
        Console.WriteLine($"c= {c}");
    }
    static void Ex02()
    {
        int a = 5, b = 7;
        Console.WriteLine($" truoc khi doi a = {a}, b = {b}");
        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine($"sau khi doi a = {a}, b = {b}");
    }


    static void Ex03()
    {
        float a = 0.1f, b = 0.2f;
        Console.WriteLine($"a = {a}, b = {b}");
        float c = a * b;
        Console.WriteLine($"c= {c}");
    }
    static void Ex04()
    {
        float a = 8f;
        const float b = 0.3048f;
        float c = a * b;
        Console.WriteLine($"So feet la a = {a}");
        Console.WriteLine($"So met la c = {c}");

    }
    static void Ex05()
    {
        float a = 7f;
        const float x = 33.8f;
        const float y = 0.56f;
        float b = a * x;
        float c = b * y;
        Console.WriteLine($"Do C la a = {a}");
        Console.WriteLine($"Do F sau khi doi la b = {b}");
        Console.WriteLine($"Do C sau khi doi lai la c = {c}");
    }
    static void Ex06()
    {
        Console.WriteLine($"Do lon cua kieu du lieu int = {sizeof(int)} byte");
        Console.WriteLine($"Do lon cua kieu du lieu long = {sizeof(long)} byte");
        Console.WriteLine($"Do lon cua kieu du lieu double = {sizeof(double)} byte");
        Console.WriteLine($"Do lon cua kieu du lieu bool = {sizeof(bool)} byte");
        Console.WriteLine($"Do lon cua kieu du lieu char = {sizeof(char)} byte");
    }
    static void Ex07()
    {
        Console.WriteLine("Nhap ky tu bat ky vao ban phim");
        char a = Console.ReadKey().KeyChar;
        Console.WriteLine($"Ky tu ban vua nhap la a = {a}");
        int b = (int)a;
        Console.WriteLine($"Chuyen sang ASIII la b = {b}");
    }
    static void Ex08()
    {
        float a = 0.8f;
        const float b = 3.14f;
        Console.WriteLine($"Ban kinh duong tron la a = {a}");
        float c = a *a * b;
        Console.WriteLine($"Dien tich hinh tron la  S = {c}");
    }
    static void Ex09()
    {
        float a = 5.4f;
        Console.WriteLine($"Canh hinh vuong la a = {a}");
        float b = a * 2;
        Console.WriteLine($"Dien tich hinh vuong la S = {b}");


    }
    static void Ex10()
    {
        int a = 389;
        int b = a / 365;
        int c = (a % 365) / 7;
        int d = (a % 365) % 7;
        Console.WriteLine($"So ngay ban dau la a = {a}");
        Console.WriteLine($"Doi ra  {b} nam, {c} tuan va {d} ngay");
    }
}

