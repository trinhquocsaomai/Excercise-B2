// See https://aka.ms/new-console-template for more information
Console.WriteLine(" \n Chào mừng đến với trò chơi đoán số \n");
int money = 100;
int level;
do
{
    Console.WriteLine("Level: \n khó: 4 lần chơi \n Trung bình: 7 lần chơi \n Dễ: 10 lần chơi");
    Console.Write("Bạn chọn cấp độ nào [ 1- Khó, 2-Trung bình, 3 - Dễ]");
    string s1 = Console.ReadLine();
    //Kiểm tra nhập liệu người dùng 
    while (!int.TryParse(s1, out level))
    {
        Console.WriteLine("Nhập lại số");
        s1 = Console.ReadLine();
    }

    int solanchoi = 10; // Mặc định là dễ 
    solanchoi = level == 1 ? 4 : (level == 2 ? 7 : 10);
    //toán tử 3 ngôi,  VỀ COI LẠI NHA MÁ, THẦY DẠY THIẾU TRƯỜNG HỢP Á 

    Random rnd = new Random(); //công cụ nhĩ ra số ngẫu nhiên 
    int comp_num = rnd.Next(0, 100) + 1; //[1,100]


    bool is_won = false; //biến lưu trữ trạng thái thua hay thắng
    int man_num = 0;
    string s;
    // yêu cầu người dùng đoán số 
    for (int i = 0; i <= solanchoi; i++)
    {
        Console.WriteLine($" {i + 1}. Bạn đoán số mấy [1-100]");
        s = Console.ReadLine();
        //kiểm tra bằng TryParse 
        while (!int.TryParse(s, out man_num))
        {
            Console.WriteLine("Nhập lại số ");
            s = Console.ReadLine();

        }

        // so sánh kết quả 
        if (man_num == comp_num)
        {
            is_won = true;
            Console.WriteLine("Đoán đúng rồi");
            money++;
            break;

        }
        else
        // gợi ý người chơi đoán số nhỏ hơn hay lớn hơn 
        {
            if (man_num > comp_num)
            {
                Console.WriteLine("Số bạn đoán lớn hơn số máy nghĩ");
            }
            else
            {
                Console.WriteLine("Số bạn đoán nhỏ hơn số máy nghĩ");
            }
            money--;
        }
    }
    if (!is_won)
    // Nếu is_won là false (tức là người chơi thua)  -> !is_won là true -> chạy chương trình 
    // Biến is_won ban đầu phải gán giá trị trước khi sử dụng, nếu không gán thì đến khúc này nó sẽ báo lỗi: Use of unassigned local variable 'is_won'. Vì trong vòng lặp for sẽ có vài trường hợp không có vòng lặp (vì người chơi chọn số lần chơi là 0), thì lúc đó is_won sẽ không được gán giá trị 
    // chỗ if (!is_won) có thể viết là if (is_won == false )
    {
        Console.WriteLine($"Máy nghĩ ra {comp_num}, ghê không");
    }
    // sau 1 lần chơi, hỏi người dùng còn muốn chơi không
    Console.Write("\n Dám chơi nữa không");
    string tl = Console.ReadLine();
    if (tl.ToLower().Equals("k"))
    {
        Console.WriteLine("Hẹn gặp lại");
        break;// dùng để thoát khỏi vòng lặp do - while(true) khi người chơi lựa chọn thoát 
    }

} while (money > 0);
Console.WriteLine($"Số tiền của bạn là {money}");
// true là giá trị cố định, luôn luôn đúng -> vì vậy vòng lặp này sẽ chạy mãi mãi. Kĩ thuật while(true) nhằm duy trì tò chơi luôn chạy khi người chơi chủ động chọn thoát ra (là lệnh break ngay ở trên)
