using System;
class Program
{
    static void Main(string[] args)
    {
        Ex01();
        //Ex02();
        Ex03(); 
    }
    static void Ex01()
    {

        int[][] jaggedArray = new int[4][];


        jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
        jaggedArray[1] = new int[] { 2, 2 };
        jaggedArray[2] = new int[] { 3, 3, 3, 3 };
        jaggedArray[3] = new int[] { 4, 4 };

        Console.WriteLine("Mảng vừa nhập là");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"\t {jaggedArray[i][j]}");
            }
            Console.WriteLine();
        }
    }
    /*static void Ex02()
    {
        Random rnd = new Random();
        Console.WriteLine("Nhập số hàng");
        int rows = int.Parse(Console.ReadLine());
        //Khởi tạo dòng, bộ nhớ cho từng dòng 
        int[][] JaggedArray = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Nhập số cột hàng {i}");
            int columns = int.Parse(Console.ReadLine());
            JaggedArray[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                JaggedArray[i][j] = rnd.Next(1, 50);
            }

        }
        Console.WriteLine("Mảng vừa nhập là");

        for (int i = 0; i < JaggedArray.Length; i++)
        {
            for (int j = 0; j < JaggedArray[i].Length; j++)
            {
                Console.Write($"\t {JaggedArray[i][j]}");
            }
            Console.WriteLine();
        }

        //MaxValue(JaggedArray);
        //Organize(JaggedArray);
        //PrintPrime(JaggedArray);
        Console.WriteLine("Nhập vào số bạn cần tìm");
        int input = int.Parse(Console.ReadLine());
        Index(JaggedArray, input); 
    }
    //In ra số lớn nhất 
    /*static void MaxValue(int[][] JaggedArray)
    {

        int Totalmax = 0;


        for (int i = 0; i < JaggedArray.Length; i++)
        {
            int Maxrow = 0;
            //Nhớ là 0 nha má, lúc đầu để là JaggedArray[0][0] là không ra á má
            // Để Maxrow = 0; ở trong vòng lặp để mỗi lần xong 1 hàng thì sẽ reset lại thành 0, nếu không thì Maxrow sẽ mang giá trị lớn nhất của vòng lặp trước mà so với vòng lặp sau, dẫn đến sai
            for (int j = 0; j < JaggedArray[i].Length; j++)
            {
                if (JaggedArray[i][j] > Maxrow)
                {
                    Maxrow = JaggedArray[i][j];
                }
            }
            Console.WriteLine($"Giá trị lớn nhất của hàng {i} là {Maxrow}");
            //Cái Console.WriteLine phải đề ngoài vòng lặp for nhỏ, để đảm bảo chỉ in ra khi đã hết 1 hàng 
            if (Maxrow > Totalmax)
            {
                Totalmax = Maxrow;
            }
        }
        Console.WriteLine($"Giá trị lớn nhất của toàn mảng là {Totalmax}");
    }*/
    /*Sắp xếp từng hàng tăng dần.

    In ra các số nguyên tố trong mảng.

    Tìm và in ra vị trí của 1 số do user nhập.*/
    /*static void Organize(int[][] JaggedArray)
    {
        int a = 0;
        for (int i = 0; i < JaggedArray.Length; i++)
        {
            for (int j = 0; j < JaggedArray[i].Length - 1; j++)
            {
                for (int n = 0; n < JaggedArray[i].Length - 1 - j; n++)
                {
                    if (JaggedArray[i][n] > JaggedArray[i][n + 1])
                    {
                        a = JaggedArray[i][n];
                        JaggedArray[i][n] = JaggedArray[i][n + 1];
                        JaggedArray[i][n + 1] = a;
                    }
                }
            }
        }

        Console.WriteLine("Mảng sau khi đảo là");
        for (int i = 0; i < JaggedArray.Length; i++)
        {
            for (int j = 0; j < JaggedArray[i].Length; j++)
            {
                Console.Write($"\t {JaggedArray[i][j]}");
            }
            Console.WriteLine();
        }
    }
    //Tìm số nguyên tố 
    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    //In số nguyên tố 
    static void PrintPrime(int[][] JaggedArray)
    {
        Console.WriteLine("Các số nguyên tố là ");
        for (int i = 0; i < JaggedArray.Length; i++)
        {
            for (int j = 0; j < JaggedArray[i].Length; j++)
            {
                if (IsPrime(JaggedArray[i][j]) == true)
                {
                    Console.Write($"\t {JaggedArray[i][j]}");
                }
            }
            Console.WriteLine();
        }
    }
    //In ra địa chỉ số cần tìm 
    static void Index(int[][] JaggedArray, int input)
    {
        Console.WriteLine(">>> Đang chạy hàm Index phiên bản A <<<");
        for (int i = 0; i < JaggedArray.Length; i++)
        {
            for (int j = 0; j < JaggedArray[i].Length; j++)
            {
                if (JaggedArray[i][j] == input)
                {
                    Console.WriteLine($"Số cần tìm nằm ở hàng {i}, cột {j}");
                    return;
                }

            }
        }
        Console.WriteLine("Mảng không có số bạn cần tìm");
    }*/
    static void Ex03()
    {
        // Tổng số thành viên
        int totalMembers = 14;
        Member[] members = new Member[totalMembers];

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Initialize members (enter from keyboard)");
            Console.WriteLine("2. Print all members");
            Console.WriteLine("3. Find member by ID");
            Console.WriteLine("4. Member with highest completed tasks");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Nhập dữ liệu cho toàn bộ 14 thành viên
                    for (int i = 0; i < totalMembers; i++)
                    {
                        Console.WriteLine($"\nEnter info for member {i + 1}:");
                        Console.Write("ID: ");
                        members[i].ID = int.Parse(Console.ReadLine());
                        Console.Write("Full Name: ");
                        members[i].FullName = Console.ReadLine();
                        Console.Write("Completed Tasks: ");
                        members[i].CompletedTasks = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nAll members initialized successfully!");
                    break;

                case 2:
                    Console.WriteLine("\n--- List of all members ---");
                    for (int i = 0; i < totalMembers; i++)
                    {
                        Console.WriteLine($"ID: {members[i].ID}, Name: {members[i].FullName}, Tasks: {members[i].CompletedTasks}");
                    }
                    break;

                case 3:
                    Console.Write("\nEnter ID to search: ");
                    int searchID = int.Parse(Console.ReadLine());
                    bool found = false;
                    for (int i = 0; i < totalMembers; i++)
                    {
                        if (members[i].ID == searchID)
                        {
                            Console.WriteLine($"Found -> ID: {members[i].ID}, Name: {members[i].FullName}, Tasks: {members[i].CompletedTasks}");
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        Console.WriteLine("Member not found!");
                    break;

                case 4:
                    int maxIndex = 0;
                    for (int i = 1; i < totalMembers; i++)
                    {
                        if (members[i].CompletedTasks > members[maxIndex].CompletedTasks)
                        {
                            maxIndex = i;
                        }
                    }
                    Console.WriteLine($"\nMember with most tasks -> ID: {members[maxIndex].ID}, Name: {members[maxIndex].FullName}, Tasks: {members[maxIndex].CompletedTasks}");
                    break;

                case 5:
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
