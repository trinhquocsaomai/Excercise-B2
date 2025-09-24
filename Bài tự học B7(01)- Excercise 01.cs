using System;
class Program
{
    static void Main(string[] args)
    {
        //Ex04();
        //Ex06();
        //Ex07();
        Ex08();
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
    
}
