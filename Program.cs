// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

int money = 100;
int sotranthang = 0;
int sotranthua = 0; 
do
{
    // máy tính nghĩ ngẫu nhiên ra 2 con xúc sắc 

    Random rnd = new Random();
    int die_1 = rnd.Next(6) + 1;
    int die_2 = rnd.Next(6) + 1;
    int pair_of_dice = die_1 + die_2;
    string s; // Biến quyết định Tài hay Xỉu 
    if (pair_of_dice > 5)
    {
        s = "Tài";
    }
    if (pair_of_dice < 5)
    {
        s = "Xỉu";
    }
    else
    {
        s = "5";
    }

    //Ngừoi dùng nhập liệu 
    // LÀM XONG NHỚ THÊM TRYPARSE NHA MÁ ƠI !!!!
    Console.WriteLine("Bạn đó Tài hay Xỉu hay số 5, nhập <Tài/Xỉu/5");
    string doanso = Console.ReadLine();
    while (!doanso == "Tài" && !doanso == "Xỉu" && !doanso == "5")
    {
        Console.WriteLine("Nhập lại đi"); 
    }

    if (doanso == s)
        {
            if (s == "5")
            {
                Console.WriteLine("Bạn đoán đúng trường hợp đặc biệt rồi");
                money = money + 15;
                Console.WriteLine($"Số tiền bạn đang có là {money}");
                sotranthang++;



            }
            else
            {
                Console.WriteLine("Bạn đoán đúng rồi");
                money = money + 5;
                Console.WriteLine($"Số tiền bạn đang có là {money}");
                sotranthang++;
            }
        }

        else
        {
            if (s == "5")
            {
                Console.WriteLine($"Bạn đoán sai rồi, kết quả là 5 ");
                money = money - 5;
                Console.WriteLine($"Số tiền bạn đang có là {money}");
                sotranthua++;
            }
            else
            {
                Console.WriteLine($"Bạn đoán sai rồi, kết quả đúng là {s}");
                money = money - 5;
                Console.WriteLine($"Số tiền bạn đang có là {money}");
                sotranthua++;

            }
        }

    //Hỏi người chơi còn muốn chơi nữa không
    Console.WriteLine("Muốn chơi nữa không? Nhập <c/k>");
    string tl = Console.ReadLine();
    if (tl == "k")
    {
        Console.WriteLine("Bye nha");
        break; //thoát khỏi do while
    }
} while (money > 0);
//Thống kê 
Console.WriteLine($"Số tiền còn lại của bạn là {money}");
Console.WriteLine($"Số trận thắng là {sotranthang}, số trận thua là {sotranthua}");

