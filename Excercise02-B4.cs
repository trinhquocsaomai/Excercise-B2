// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();

    }
    
    static void Ex01()
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
   
   static void Ex02()
    {
        Console.WriteLine("Nhập số y ");
        string s = Console.ReadLine();
        int number1 = 0;
        while (!int.TryParse(s, out number1) && int.Parse(s) < -5 || int.Parse(s) > 5)
        {
            Console.WriteLine("Nhập lại số");
            s = Console.ReadLine();
        }
        int x = number1 * number1 + 2 * number1 + 1;
        Console.WriteLine($"Kết quả x la {x}");
    }

    static void Ex03()
    {
        Console.WriteLine("Nhập số giờ");
        string s = Console.ReadLine();
        float number1 = 0f;
        while (!float.TryParse(s, out number1))
        {
            Console.WriteLine("Nhập lại số giờ");
            s = Console.ReadLine();
        }

        Console.WriteLine("Nhập số phút");
        string p = Console.ReadLine();
        float number2 = 0f;
        while (!float.TryParse(p, out number2))
        {
            Console.WriteLine("Nhập lại số phút");
            p = Console.ReadLine();
        }

        Console.WriteLine("Nhập số giây");
        string z = Console.ReadLine();
        float number3 = 0f;
        while (!float.TryParse(z, out number3))
        {
            Console.WriteLine("Nhập lại số giây");
            p = Console.ReadLine();
        }

        Console.WriteLine("Nhập khoảng cách");
        string i = Console.ReadLine();
        float number4 = 0f;
        while (!float.TryParse(i, out number4))
        {
            Console.WriteLine("Nhập lại khoảng cách");
            p = Console.ReadLine();
        }

        float thoigian = number1 + number2 / 60 + number3 / 3600;
        Console.WriteLine($"Khoảng cách đơn vị km/h là  {number4 / thoigian}");
        float x = number4 * 0.621371f;
        Console.WriteLine($"Khoảng cách đơn vị là miles/h là {x / thoigian}");
    }
    
    static void Ex04()
    {
        Console.WriteLine("Nhập bán kính");
        string s = Console.ReadLine();
        float number1 = 0;
        while (!float.TryParse(s, out number1))
        {
            Console.WriteLine("Nhập lại bán kính");
            s = Console.ReadLine();
        }
        float v = 4 / 3f * 3.14f * number1 * number1 * number1;
        Console.WriteLine($"Thể tích là {v}");

    }
    static void Ex05()
    {
       Console.WriteLine("Nhập vào bàn phím");
        
      
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine(); 

        if (Char.IsLetter(inputChar))
        {
            
            char lowerChar = Char.ToLower(inputChar);

           
            if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            {
                Console.WriteLine("Ký tự '" + inputChar + "' là một nguyên âm.");
            }
            else
            {
                Console.WriteLine("Ký tự '" + inputChar + "' là một phụ âm.");
            }
        }
    
        else if (Char.IsDigit(inputChar))
        {
            Console.WriteLine("Ký tự '" + inputChar + "' là một chữ số.");
        }
        
        else
        {
            Console.WriteLine("Ký tự '" + inputChar + "' là một ký tự đặc biệt khác.");
        }
    }
    
}

