using System;
class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03(); 
        //Ex04();
        //Ex06();
        //Ex07();
        Ex08();
        Ex09();
        Ex10();

    }
    static void Ex01()
    {
        // Tạo mảng mẫu
        int[] numbers = { 10, 20, 30, 40, 50 };

        // 1. Tính giá trị trung bình
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine("Average value: " + average);
    }

    // 2. Kiểm tra mảng có chứa giá trị cụ thể không
    static void Ex02()
    {
        int searchValue = 30;
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchValue)
            {
                found = true;
                break;
            }
        }
        if (found)
            Console.WriteLine("Array contains " + searchValue);
        else
            Console.WriteLine("Array does not contain " + searchValue);
    }

    // 3. Tìm chỉ số của phần tử trong mảng
    static void Ex03()
    {
        int findValue = 40;
        int index = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == findValue)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
            Console.WriteLine("Index of " + findValue + " is: " + index);
        else
            Console.WriteLine(findValue + " not found in array");

    }




        /*static void Ex04()
        {

            Random range = new Random();
            int size = 10;
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Array[i] = range.Next(0, 10);
            }
            //Tạo ra phần tử muốn bỏ, đếm số phần tử khác phần tử muốn bỏ 
            Console.WriteLine("Nhập số muốn bỏ");
            int input = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (int items in Array)
            {
                if (items != input)
                {
                    count++;
                }
            }
            int[] NewArray = new int[count];
            //xét mảng cũ, nếu phần tử nào khác số muốn bỏ sẽ được đưa vào trong mảng mới 
            int index = 0;
            foreach (int items in Array)
            {
                if (items != input)
                {
                    NewArray[index] = items;
                    index++;
                }
                //Không được để index++; ở đây vì index vẫn luôn tăng cho dù có thoả điều kiện hay không, Kết quả: index sẽ vượt quá số phần tử thực sự có trong NewArray
            }
            for (int b = 0; b < count; b++)
            {
                Console.Write($"\t {NewArray[b]}");
            }
        }
        static void Ex06()
        {
            Random range = new Random();
            int size = 10;
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Array[i] = range.Next(0, 10);
            }
            for (int n = 0; n < size; n++)
            {
                Console.Write($"\t {Array[n]}");
            }
            Console.WriteLine();
            int[] NewArray = new int[size];
            for (int n = 0; n < size; n++)
            {
                NewArray[n] = Array[size - 1 - n];
            }
            for (int n = 0; n < size; n++)
            {
                Console.Write($"\t {NewArray[n]}");
            }
        }
        //Đảo vị trí 1 mảng 
        static void Ex07()
        {
            Random range = new Random();
            int size = 10;
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Array[i] = range.Next(0, 10);
            }
            Console.WriteLine("Mảng ban đầu là");
            for (int n = 0; n < size; n++)
            {
                Console.Write($"\t {Array[n]}");
            }
            Console.WriteLine();
            int[] Temporary = new int[Array.Length];
            int index = 0;
            int count = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        Temporary[index] = Array[i];
                        index++;
                        count++;
                        break;
                    }
                }
            }

            int[] Result = new int[count];
            for (int i = 0; i < count; i++)
            {
                Result[i] = Temporary[i];
            }
            Console.WriteLine("Các giá trị trùng là");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"\t {Result[i]}");
            }
        }*/
        // Xét mỗi phần tử của mảng, xét xem trước đó nó đã xuất hiện chưa, nếu chưa thì cho vào mảng Temporary, còn rồi thì bỏ qua, cuối cùng tạo mảng result tham khảo từ Temporary. 
        static void Ex08()
        {
            Random range = new Random();
            int size = 10;
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Array[i] = range.Next(0, 10);
            }
            Console.WriteLine("Mảng ban đầu là");
            for (int n = 0; n < size; n++)
            {
                Console.Write($"\t {Array[n]}");
            }
            Console.WriteLine();


            int[] Temporary = new int[Array.Length];
            int index = 0;
            int count = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                bool exists = false;

                // kiểm tra Array[i] đã xuất hiện trước đó chưa
                for (int j = 0; j < i; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    Temporary[count] = Array[i];
                    count++;
                }
            }
            int[] Result = new int[count];
            for (int i = 0; i < count; i++)
            {
                Result[i] = Temporary[i];
            }
            Console.WriteLine("Mảng chưa các giá trị không trùng là");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"\t {Result[i]}");
            }
        }
        /*static void Ex09()
        {
            int size = 10;
            int[] Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}");
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mảng vừa nhập là");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\t {Array[i]}");
            }
            //Thuật toán Bubble Sort 
            int a = 0;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        //Đổi vị trí 2 biến với nhau
                        a = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = a;

                    }
                }
            }
            Console.WriteLine("Mảng sau khi sắp xếp là");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"\t {Array[i]}");
            }
        }
        /*
        1.Tại sao i lại chạy đến size -1

        Mảng có size phần tử.
        Sau mỗi vòng lặp ngoài, một phần tử “lớn nhất” đã nổi lên đúng chỗ (ở cuối mảng).
        Như vậy chỉ cần size - 1 lần là đủ:
        Sau (size - 1) lần, tất cả các phần tử còn lại tự động đúng chỗ.
        Nếu chạy đến i < size thì thừa, vì lúc đó mảng đã sắp xếp xong

        2. Tại sao j lại chạy đến size -1 -i
        size -1 đã giải thích 
        j là chỉ số so sánh cặp phần tử liền kề: arr[j] và arr[j+1].
        Nếu j chạy đến size - 1 thì sẽ bị lỗi, vì arr[j+1] sẽ vượt ngoài mảng.
        Do đó, phải dừng ở size - 1.
        Nhưng tại sao còn có - i nữa?
        Bởi vì sau mỗi vòng ngoài i, đã có i phần tử lớn nhất nằm đúng ở cuối rồi, không cần so sánh lại nữa.
        Vậy số lần so sánh giảm dần theo từng vòng.

    */
        static void Ex10()
        {
            Console.WriteLine("Nhập vào 1 câu");
            string input = Console.ReadLine().ToLower();
            string[] Array = input.Split(' ');
            Console.WriteLine("Nhập vào 1 từ");
            string input2 = Console.ReadLine();


            for (int index = 0; index < Array.Length; index++)
            {
                if (input2 == Array[index])
                {
                    Console.WriteLine($" Từ đó nằm ở {index}");
                    return;
                }
            }
            Console.WriteLine("Không có từ đó trong câu");
        }

}
