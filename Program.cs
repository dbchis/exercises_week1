
namespace EXERCISES_WEEK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise1();
            Exercise7();
        }
        // static void Exercise1()
        // {
        //     Console.WriteLine("What is your name?");
        //     var name = Console.ReadLine();
        //     var currentDate = DateTime.Now;
        //     Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        //     Console.Write($"{Environment.NewLine}Press any key to exit...");
        //     Console.ReadKey(true);
        // }
        static void Exercise1()
        {
            Console.Write("Name: ");
            string hoTen = Console.ReadLine();

            Console.Write("Point: ");
            double diem;
            while (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.Write("Point (0-10): ");
            }
            Console.WriteLine("Name: " + hoTen.ToUpper());

            // Xếp loại học sinh
            string xepLoai;
            if (diem >= 8)
            {
                xepLoai = "Giỏi";
            }
            else if (diem >= 6.5)
            {
                xepLoai = "Khá";
            }
            else if (diem >= 5)
            {
                xepLoai = "Trung bình";
            }
            else
            {
                xepLoai = "Yếu";
            }
            Console.WriteLine("Result: " + xepLoai);

        }
        static void Exercise2()
        {
            Console.WriteLine("Phương trình bậc 2: ax^2 + bx + c = 0");
            Console.Write("Nhập hệ số a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    // Phương trình bậc nhất bx + c = 0
                    double x = -c / b;
                    Console.WriteLine($"Phương trình có 1 nghiệm: x = {x}");
                }
                return;
            }
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có 1 nghiệm: x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }
        static void Exercise3()
        {
            int number;
            while (true)
            {
                Console.Write("Nhap so nguyen duong: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (number > 0)
                    {
                        Console.WriteLine($"Số nguyên dương bạn đã nhập là: {number}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Số bạn nhập không phải là số nguyên dương. Vui lòng thử lại.");
                    }
                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên.");
                }
            }
        }
        static void Exercise4()
        {
            Console.Write("Nhập vào một số nguyên n: ");
            string input = Console.ReadLine();

            // Kiểm tra xem đầu vào có phải là số nguyên hay không
            if (int.TryParse(input, out int n))
            {
                if (IsPrime(n))
                {
                    Console.WriteLine($"{n} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{n} không phải là số nguyên tố.");
                }
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên.");
            }

            bool IsPrime(int number)
            {
                if (number <= 1)
                {
                    return false;
                }
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Exercise5()
        {
            Console.Write("Nhập vào một năm dương lịch (n): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n > 0)
            {
                if (IsLeapYear(n))
                {
                    Console.WriteLine($"{n} là năm nhuận.");
                }
                else
                {
                    Console.WriteLine($"{n} không phải là năm nhuận.");
                }
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một năm dương lịch hợp lệ.");
            }
            bool IsLeapYear(int year)
            {
                // Năm nhuận nếu chia hết cho 4 và không chia hết cho 100, hoặc chia hết cho 400
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }
        }
        static void Exercise6()
        {
            Console.Write("Nhập vào một số nguyên dương n: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n > 0)
            {
                double sum = 0.0;

                // Tính tổng S1
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                }

                // In ra kết quả
                Console.WriteLine($"Tổng S1 = 1 + 1/2 + 1/3 + ... + 1/{n} = {sum}");
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên dương hợp lệ.");
            }
        }
        static void Exercise7()
        {
            Console.WriteLine("Welcome to minigame");
            Random random = new Random();
            int a = random.Next(1, 101);
            Console.WriteLine($"Ket qua la 1 so trong khoang 1 -> 100");
            int count = 7;
            Console.WriteLine("Bạn có 7 lần dự đoán kết quả");
            while (count > 0)
            {
                Console.Write("Dự đoán của bạn: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int n) && n > 0)
                {
                    if(n==a){
                        Console.WriteLine("Chuc mung ban da doan chinh xac: ");
                        break;
                    }else if(n>a){
                        Console.WriteLine("Ban doan so lon hon");
                    }else if(n<a){
                        Console.WriteLine("Ban doan so nho hon");
                    }
                    count --;
                    Console.WriteLine($"Ban con {count} lan du doan");
                    if(count == 0){
                        Console.WriteLine($"Ket qua la {a} Tro choi ket thuc. Ban thua");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên dương hợp lệ.");
                }
            }

        }

    }

}
