using System;
namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
        }
    }
}
