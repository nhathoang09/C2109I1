using System;
using System.Text;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int num1 = Random.Shared.Next(0, 9);
            int num2 = Random.Shared.Next(0, 9);

            Console.WriteLine($"{nameof(num1)}={num1}");
            Console.WriteLine($"{nameof(num2)}={num2}");

            Console.WriteLine("Vui long nhap dau");
            var pt = Console.ReadLine();

            switch (pt)
            {
                case "+" when num1 > 0 && num2 > 0:
                    Console.WriteLine(num1 + num2);
                    break;
                case "-" when num1 > num2:
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/" when num2 != 0:
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("I can't do it");
                    break;
            }

            Console.WriteLine(
                    pt switch
                    {
                        "+" when num1 > 0 && num2 > 0 => num1 + num2,
                        "-" when num1 > num2 => num1 - num2,
                        "*" => num1 * num2,
                        "/" when num2 != 0 => num1 / num2
                    }
            );
        }
    }
}