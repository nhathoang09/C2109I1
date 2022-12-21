using System;
using System.Text;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Vui long nhap vao mot so: ");
            int i = int.TryParse(Console.ReadLine(), out var result) ? result : 0;// nếu nhập chuỗi trả về 0

            //Làm kiểm tra xem biến i có lớn hơn 100 không?
            CheckNumber.Check(i, 100);

            //Extention Method
            //Không thông qua đối tượng của class đang chứa mà thông qua cái muốn sử dụng

            i.IsGreaterThan(200);
            var pro = new Program();
            pro.Hi();
        }
    }
}
