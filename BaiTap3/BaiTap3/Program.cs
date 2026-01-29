using System;

namespace BaiTap3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap Chuoi: ");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Kết quả: Chuoi ko dx");
            }
            else
            {
                string chuoiSach = input.Replace(" ", "");
                chuoiSach = chuoiSach.ToLower();
                bool laDoiXung = true;
                int doDai = chuoiSach.Length;
                for (int i = 0; i < doDai / 2; i++)
                {
                  
                    if (chuoiSach[i] != chuoiSach[doDai - 1 - i])
                    {
                        laDoiXung = false;
                        break; 
                    }
                }
                if (laDoiXung)
                {
                    Console.WriteLine("Chuoi Doi Xung");
                }
                else
                {
                    Console.WriteLine("Chuoi Khong Doi Xung");
                }
            }

            Console.ReadLine();
        }
    }
}