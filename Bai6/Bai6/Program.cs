using System;
namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So Phan Tu cua Mang:");
            int n = int.Parse(Console.ReadLine());
            if(n==0)
                {
                Console.WriteLine("Mang Rong!");
                return;
            }
            int[] arr = new int[n];
            Console.WriteLine("Nhap Cac Phan Tu Cua Mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"So Luong So Chan Trong Mang La: {count}");
        }
    }
}