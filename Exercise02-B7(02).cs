// See https://aka.ms/new-console-template for more information

 class Member
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int CompletedTasks { get; set; }

    public Member(int id, string name, int tasks)
    {
        ID = id;
        Name = name;
        CompletedTasks = tasks;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Tasks: {CompletedTasks}";
    }
}


class Program
{


    static void Main()
    {
        Ex01();
        Ex02();
    }
    static void Ex01()
    {
        // Tạo Jagged Array cố định và in ra
        Console.WriteLine("== Part 1: Jagged Array cố định ==");

        int[][] jagged1 = new int[4][];
        jagged1[0] = new int[] { 1, 1, 1, 1, 1 };
        jagged1[1] = new int[] { 2, 2 };
        jagged1[2] = new int[] { 3, 3, 3, 3 };
        jagged1[3] = new int[] { 4, 4 };

        PrintJaggedArray(jagged1);

        // Tạo Jagged Array ngẫu nhiên (hoặc từ người dùng)
        Console.WriteLine("\n== Part 2: Jagged Array ngẫu nhiên ==");

        Console.Write("Nhập số hàng: ");
        int rows = int.Parse(Console.ReadLine());

        int[][] jagged2 = new int[rows][];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Nhập số cột cho hàng {i}: ");
            int cols = int.Parse(Console.ReadLine());

            jagged2[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                jagged2[i][j] = rand.Next(1, 100); // số ngẫu nhiên 1-99
            }
        }

        Console.WriteLine("\nJagged Array đã tạo:");
        PrintJaggedArray(jagged2);

        // 1. In số lớn nhất 
        PrintBiggestNumbers(jagged2);

        // 2. Sắp xếp tăng dần 
        SortRowsAscending(jagged2);
        Console.WriteLine("\nJagged Array sau khi sắp xếp tăng dần từng hàng:");
        PrintJaggedArray(jagged2);

        // 3. In số nguyên tố 
        Console.WriteLine("\nCác số nguyên tố trong Jagged Array:");
        PrintPrimes(jagged2);

        // 4. Tìm số
        Console.Write("\nNhập số cần tìm: ");
        int target = int.Parse(Console.ReadLine());
        SearchNumber(jagged2, target);
    }

    //  HÀM TIỆN ÍCH 
    static void PrintJaggedArray(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
                Console.Write(arr[i][j] + " ");
            Console.WriteLine();
        }
    }

    // 1. In số lớn nhất 
    static void PrintBiggestNumbers(int[][] arr)
    {
        int globalMax = arr[0][0];
        Console.WriteLine("\nSố lớn nhất của từng hàng:");
        for (int i = 0; i < arr.Length; i++)
        {
            int rowMax = arr[i][0];
            for (int j = 1; j < arr[i].Length; j++)
            {
                if (arr[i][j] > rowMax) rowMax = arr[i][j];
            }
            Console.WriteLine($"Hàng {i}: {rowMax}");
            if (rowMax > globalMax) globalMax = rowMax;
        }
        Console.WriteLine($"Số lớn nhất trong toàn mảng: {globalMax}");
    }

    // 2. Sắp xếp tăng dần
    static void SortRowsAscending(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Array.Sort(arr[i]);
        }
    }

    // 3. In số nguyên tố 
    static void PrintPrimes(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (IsPrime(arr[i][j]))
                    Console.Write(arr[i][j] + " ");
            }
        }
        Console.WriteLine();
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    // 4. Tìm số
    static void SearchNumber(int[][] arr, int target)
    {
        bool found = false;
        Console.WriteLine($"Vị trí xuất hiện của {target}:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == target)
                {
                    Console.WriteLine($"Hàng {i}, Cột {j}");
                    found = true;
                }
            }
        }
        if (!found) Console.WriteLine("Không tìm thấy.");
    }






    static void Ex02()
    {
        // 1. Khởi tạo Jagged Array các nhóm
        Member[][] groups = InitializeGroups();

        int choice;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. In danh sách tất cả thành viên");
            Console.WriteLine("2. Tìm thông tin theo ID");
            Console.WriteLine("3. Thành viên có nhiều task nhất");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintAllMembers(groups);
                    break;
                case 2:
                    Console.Write("Nhập ID cần tìm: ");
                    int id = int.Parse(Console.ReadLine());
                    PrintMemberByID(groups, id);
                    break;
                case 3:
                    PrintTopPerformer(groups);
                    break;
                case 0:
                    Console.WriteLine("Kết thúc chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

        } while (choice != 0);
    }

    // 1. Khởi tạo dữ liệu
    static Member[][] InitializeGroups()
    {
        Member[][] groups = new Member[3][];

        groups[0] = new Member[5] {
            new Member(1, "Alice", 12),
            new Member(2, "Bob", 8),
            new Member(3, "Charlie", 15),
            new Member(4, "David", 6),
            new Member(5, "Emma", 10)
        };

        groups[1] = new Member[3] {
            new Member(6, "Frank", 11),
            new Member(7, "Grace", 7),
            new Member(8, "Hannah", 14)
        };

        groups[2] = new Member[6] {
            new Member(9, "Ivy", 9),
            new Member(10, "Jack", 20),
            new Member(11, "Kevin", 13),
            new Member(12, "Laura", 5),
            new Member(13, "Mike", 17),
            new Member(14, "Nina", 16)
        };

        return groups;
    }

    // 2. In tất cả thành viên
    static void PrintAllMembers(Member[][] groups)
    {
        Console.WriteLine("\nDanh sách tất cả thành viên:");
        for (int i = 0; i < groups.Length; i++)
        {
            Console.WriteLine($"-- Group {i + 1} --");
            for (int j = 0; j < groups[i].Length; j++)
            {
                Console.WriteLine(groups[i][j]);
            }
        }
    }

    // 3. Tìm thành viên theo ID
    static void PrintMemberByID(Member[][] groups, int id)
    {
        foreach (var group in groups)
        {
            foreach (var member in group)
            {
                if (member.ID == id)
                {
                    Console.WriteLine("Thông tin tìm thấy: " + member);
                    return;
                }
            }
        }
        Console.WriteLine("Không tìm thấy thành viên với ID này.");
    }

    // 4. Thành viên có nhiều task nhất
    static void PrintTopPerformer(Member[][] groups)
    {
        Member top = groups[0][0];
        foreach (var group in groups)
        {
            foreach (var member in group)
            {
                if (member.CompletedTasks > top.CompletedTasks)
                    top = member;
            }
        }
        Console.WriteLine("\nThành viên có nhiều task nhất:");
        Console.WriteLine(top);
    }
}
