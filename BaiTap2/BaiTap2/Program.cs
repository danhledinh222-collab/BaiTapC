using System;

namespace BaiTap2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi bất kỳ: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Lỗi: chuoi rong.");
            }
            else
            {
                string[] danhSachTu = input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"Kết quả đếm: {danhSachTu.Length}");
            }
        }
    }
}