using System;
namespace Bai7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap Ho Ten ");
            string hoTen = Console.ReadLine();
            if (hoTen == null)
            {
                Console.WriteLine("Loi Chuoi Null");
            }
            else
            {
                string[] mangTu = hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (mangTu == null)
                {
                    Console.WriteLine("Loi Ket Qua Null.");
                }
                else
                {
                    Console.WriteLine("ket qua:");
                    foreach (string tu in mangTu)
                    {
                        Console.WriteLine(tu);
                    }
                }
            }
            Console.WriteLine("Le Dinh Danh msv:2415053122308");
            Console.ReadLine();
        }
    }
}