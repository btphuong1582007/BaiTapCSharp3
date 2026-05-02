using System;

class Program
{
    static void Main()
    {
        // Bật bài nào thì gọi hàm đó
        //Bai1();
        //Bai2();
        //Bai3();
        //Bai4();
        Bai5();
    }

    static void Bai1()
    {
        Console.Write("Nhập số thứ nhất: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập phép toán (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;
        switch (op)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/': result = b != 0 ? a / b : double.NaN; break;
            default: Console.WriteLine("Phép toán không hợp lệ"); return;
        }
        Console.WriteLine($"Kết quả: {result}");
    }

    static void Bai2()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }

    static void Bai3()
    {
        Console.Write("Nhập quãng đường (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập giờ: ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập phút: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập giây: ");
        int s = Convert.ToInt32(Console.ReadLine());

        double timeHours = h + m / 60.0 + s / 3600.0;
        double speedKmH = distance / timeHours;
        double speedMilesH = speedKmH / 1.609;

        Console.WriteLine($"Tốc độ: {speedKmH:F2} km/h");
        Console.WriteLine($"Tốc độ: {speedMilesH:F2} miles/h");
    }

    static void Bai4()
    {
        Console.Write("Nhập bán kính r: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        Console.WriteLine($"Diện tích mặt cầu: {surface:F2}");
        Console.WriteLine($"Thể tích khối cầu: {volume:F2}");
    }

    static void Bai5()
    {
        Console.Write("Nhập một ký tự: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ("aeiouAEIOU".IndexOf(ch) >= 0)
            Console.WriteLine("Đây là nguyên âm.");
        else if (char.IsDigit(ch))
            Console.WriteLine("Đây là chữ số.");
        else
            Console.WriteLine("Đây là ký tự khác.");
    }
}
