using System;
namespace Bai8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap Vao chuoi: ");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Loi Chuoi Null.");
            }
            else
            {
                string[] cacTu = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cacTu.Length == 0)
                {
                    Console.WriteLine("Chuoi Rong");
                }
                else
                {
                    string tuDaiNhat = "";
                    foreach (string tu in cacTu)
                    { 
                        if (tu.Length > tuDaiNhat.Length)
                        {
                            tuDaiNhat = tu;
                        }
                    }

                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"Tu Dai Nhat La \"{tuDaiNhat}\"");
                    Console.WriteLine($"Do Dai: {tuDaiNhat.Length} ký tự");
                    Console.WriteLine("Le Dinh Danh msv:2415053122308");
                }
            }
        }
    }
}