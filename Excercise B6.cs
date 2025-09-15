// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;
using System.IO.Pipelines;
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
    }
     static void Ex01()
    {
        //Tạo 1 mảng gồm các phần nhập vào (sau khi tách), tạo ra 1 mảng số mới mà các thành phần đã được ép kiểu
        Console.WriteLine("Nhập vào các số, cách nhau bởi dấu cách");
        string input = Console.ReadLine();


        //Tách chuỗi thành mảng số


        string[] parts = input.Split(' ');          // {"10","7","25","3"}


        int[] numbers = new int[parts.Length];      // tạo mảng int cùng độ dài
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);       // chuyển từng phần tử sang int
        }
        int max = MaxValue(numbers);
        Console.WriteLine($"So lon nhat la {max}");
    }
    static int MaxValue(params int[] numbers) //Truyền mảng numbers từ Ex01() xuống để sử dụng, nếu không nó sẽ báo lỗi The name 'IntArray' does not exist in the current context
    {
        if (numbers.Length == 0)
            throw new ArgumentException("Phải nhập ít nhất 1 số.");


        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
                max = n; //Đừng có ngược lại nha má, đang gán biến max đó mang giá trị của n mà 
        }
        return max;
    } 
    static void Ex02()
    {
        Console.WriteLine("Nhập vào 1 số");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(a));

    }
    static int Factorial(int a)
    {
        int result = 1;
        for (int i = 1; i <= a; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Ex03()
    {
        Console.WriteLine("Nhập vào 1 số");
        int a = int.Parse(Console.ReadLine());
        if (IsPrime(a) == true)
        {
            Console.WriteLine("Là số nguyên tố");
        }
        else
        {
            Console.WriteLine("Không là số nguyên tố");
        }
    }
    static bool IsPrime(int a)
    {
        if (a < 2)
        {
            return false;
        }
        for (int i = 2; i < Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }

        }
        return true;
    }

    //Kiểm tra phải số nguyên tố hay không
    static void Ex04()
        {
            // Gọi bài 4.1
            PrintPrimesLessThanX();

            // Gọi bài 4.2
            PrintFirstNPrimes();
        }
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // (1) In tất cả số nguyên tố < X
    static void PrintPrimesLessThanX()
    {
        Console.Write("Nhập số X: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine($"Các số nguyên tố nhỏ hơn {x} là:");
        for (int i = 2; i < x; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(); // xuống dòng
    }

    // (2) In N số nguyên tố đầu tiên
    static void PrintFirstNPrimes()
    {
        Console.Write("Nhập N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n} số nguyên tố đầu tiên là:");
        int count = 0;
        int number = 2; // bắt đầu từ số 2

        while (count < n)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
                count++;
            }
            number++;
        }
        Console.WriteLine();
    }

    static void Ex05()
    {
        Console.WriteLine("Các số hoàn hảo nhỏ hơn 1000 là:");
        for (int i = 1; i < 1000; i++)
        {
            if (IsPerfect(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
    static bool IsPerfect(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)  
        {
            if (n % i == 0)          
            {
                sum += i;            
            }
        }
        return sum == n;             
    }
    static void Ex06()
    {
        Console.WriteLine("Nhập vào 1 câu:");
        string input = Console.ReadLine();

        if (IsPangram(input))
            Console.WriteLine("Đây là Pangram");
        else
            Console.WriteLine("Không phải Pangram");
    }
    static bool IsPangram(string s)
    {
        s = s.ToLower(); // chuyển về chữ thường

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!s.Contains(c)) // nếu thiếu 1 ký tự trong bảng chữ cái
                return false;
        }

        return true; // đủ a-z thì là Pangram
    }
        
    }





