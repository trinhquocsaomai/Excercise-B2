// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Ex01();
        Ex02(); 
    }
    static void Ex01()
    {
        Random rand = new Random();

        // 1. Tạo mảng số nguyên ngẫu nhiên
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 20); // số từ 1 đến 20
        }

        Console.WriteLine("Original Array: " + string.Join(", ", arr));

        // 2. Tính trung bình
        Console.WriteLine("Average: " + CalculateAverage(arr));

        // 3. Kiểm tra mảng có chứa giá trị
        int testValue = 10;
        Console.WriteLine($"Contains {testValue}? {ContainsValue(arr, testValue)}");

        // 4. Tìm chỉ số của phần tử
        Console.WriteLine($"Index of {testValue}: {FindIndex(arr, testValue)}");

        // 5. Xoá phần tử
        int removeValue = arr[0]; // xoá phần tử đầu tiên
        Console.WriteLine($"Remove {removeValue}: " + string.Join(", ", RemoveElement(arr, removeValue)));

        // 6. Tìm max và min
        int max, min;
        FindMaxMin(arr, out max, out min);
        Console.WriteLine($"Max: {max}, Min: {min}");

        // 7. Đảo ngược mảng
        Console.WriteLine("Reversed: " + string.Join(", ", ReverseArray(arr)));

        // 8. Tìm giá trị trùng lặp
        Console.WriteLine("Duplicates: " + string.Join(", ", FindDuplicates(arr)));

        // 9. Xoá phần tử trùng lặp
        Console.WriteLine("Without Duplicates: " + string.Join(", ", RemoveDuplicates(arr)));
    }

    // 1. Tính trung bình
    static double CalculateAverage(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return (double)sum / arr.Length;
    }

    // 2. Kiểm tra có giá trị trong mảng không
    static bool ContainsValue(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == value) return true;
        return false;
    }

    // 3. Tìm chỉ số của phần tử
    static int FindIndex(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == value) return i;
        return -1; // không tìm thấy
    }

    // 4. Xoá phần tử
    static int[] RemoveElement(int[] arr, int value)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == value) count++;

        int[] result = new int[arr.Length - count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] != value) result[index++] = arr[i];

        return result;
    }

    // 5. Tìm max và min
    static void FindMaxMin(int[] arr, out int max, out int min)
    {
        max = arr[0];
        min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
    }

    // 6. Đảo ngược mảng
    static int[] ReverseArray(int[] arr)
    {
        int[] reversed = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            reversed[i] = arr[arr.Length - 1 - i];
        return reversed;
    }

    // 7. Tìm phần tử trùng lặp
    static int[] FindDuplicates(int[] arr)
    {
        int[] duplicates = new int[arr.Length];
        int dupCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] && !Exists(duplicates, dupCount, arr[i]))
                {
                    duplicates[dupCount++] = arr[i];
                }
            }
        }

        int[] result = new int[dupCount];
        Array.Copy(duplicates, result, dupCount);
        return result;
    }

    // Hàm phụ kiểm tra tồn tại
    static bool Exists(int[] arr, int length, int value)
    {
        for (int i = 0; i < length; i++)
            if (arr[i] == value) return true;
        return false;
    }

    // 8. Xoá phần tử trùng lặp
    static int[] RemoveDuplicates(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!Exists(temp, count, arr[i]))
            {
                temp[count++] = arr[i];
            }
        }

        int[] result = new int[count];
        Array.Copy(temp, result, count);
        return result;
    }
    static void Ex02()
    {
        // Bubble Sort 
        int[] numbers = new int[10];
        Console.WriteLine("Nhập 10 số nguyên:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nMảng trước khi sắp xếp: " + string.Join(", ", numbers));

        BubbleSort(numbers);

        Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", numbers));

        // Linear Search 
        Console.WriteLine("\nNhập một câu:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Nhập một từ cần tìm:");
        string word = Console.ReadLine();

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int index = LinearSearch(words, word);

        if (index != -1)
        {
            Console.WriteLine($"Từ \"{word}\" xuất hiện ở vị trí {index} trong câu.");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy từ \"{word}\" trong câu.");
        }
    }

    // Thuật toán Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // hoán đổi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Thuật toán Linear Search
    static int LinearSearch(string[] arr, string target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(target, StringComparison.OrdinalIgnoreCase))
            {
                return i; // trả về chỉ số nếu tìm thấy
            }
        }
        return -1; // không tìm thấy
    }
}
