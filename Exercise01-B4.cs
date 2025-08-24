// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03(); 
    }
    static void Ex01()
    {
        Console.WriteLine("Nhập bán kính số");
        string s = Console.ReadLine();
        int number = 0;
        while (!int.TryParse(s, out number))
        {
            Console.WriteLine("Nhập lại số");
            s = Console.ReadLine();
        }
        float kelvin = number + 273;
        float fahrenheit = number * 18f / 10f + 32;
        Console.WriteLine($"Kelvin la {kelvin}");
        Console.WriteLine($"Fahrenheit {fahrenheit}");
    }

    static void Ex02()
    {
        Console.WriteLine("Nhập 1 số");
        string s = Console.ReadLine();
        int number = 0;
        while (!int.TryParse(s, out number))
        {
            Console.WriteLine("Nhập lại số");
            s = Console.ReadLine();
        }
        Console.WriteLine(number);
        float surface = 4 * 3.14f * number * number;
        float volume = 4f / 3f * 3.14f * number * number * number;
        Console.WriteLine($"Diện tích xung quanh là {surface}, thể tích là {volume}");
    }
    

    static void Ex03()
    {
        Console.WriteLine("Nhập số đầu tiên ");
        string s = Console.ReadLine();
        int number1 = 0;
        while (!int.TryParse(s, out number1))
        {
            Console.WriteLine("Nhập lại số");
            s = Console.ReadLine();
        }
        Console.WriteLine("Nhập số thứ hai ");
        string p = Console.ReadLine();
        int number2 = 0;
        while (!int.TryParse(p, out number2))
        {
            Console.WriteLine("Nhập lại số");
            p = Console.ReadLine();
        }
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
    }
    
}
