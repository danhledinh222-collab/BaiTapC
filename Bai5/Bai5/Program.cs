using System;
namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So Luong Phan Tu Cua Mang");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Mang Rong Khong Co Phan Tu Nao");
                return;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Phan Tu Thu " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Phan Tu Lon Nhat Trong Mang La: " + max);
        }
    }
}