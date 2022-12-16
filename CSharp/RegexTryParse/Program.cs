using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //string? str = null;
            //Console.WriteLine("Vui lòng nhập số: ");
            //str = Console.ReadLine();

            //var formula = new Regex("^[0-9]+$");

            //if (formula.IsMatch(str))
            //{
            //    int result = Convert.ToInt32(str);
            //    Console.WriteLine(++result);
            //}

            //if (int.TryParse(str, out int i))
            //{
            //    Console.WriteLine($"i là số: {i}");
            //}



            Console.WriteLine("Vui long nhap so luong: ");
            string? amount = Console.ReadLine();
            if (string.IsNullOrEmpty(amount))
            {
                return;
            }

            try
            {
                int total = int.Parse(amount);
                if (total <= 0) throw new Exception("Phai lon hon khong");
                Console.WriteLine($"{nameof(total)} = {total}");
            }
            catch(Exception) when (amount.Contains("$"))
            {
                Console.WriteLine("Chuoi khong duoc co dau $");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType()}, {e.Message}");
            }
        }
    }
}
