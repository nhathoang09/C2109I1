
using System.Diagnostics;

internal class Program
{
    //method
    public static void Add(int a, int b) => Console.WriteLine(a + b);
    public static int Substract(int a, int b) => a-b;
    public static void Show() => Console.WriteLine("C2109I1");
    public static int ReturnNumber() => 5;

    private static void Main(string[] args)
    {
        //local function
        void Sub(int a, int b) => Console.WriteLine(a + b);

        //func và action => đều là delegate
        //action dùng cho các phương thức là void
        //func dùng cho các phương thức khác void
        Action act = Show;
        act();

        Action<int, int> ac = Add;
        ac(5, 6);

        Func<int> fun = ReturnNumber;
        Console.WriteLine(fun());

        Func<int, int, int> sub = Substract;
        Console.WriteLine(sub (28, 9));

        Action<string> action = (str) =>
        {
            Console.WriteLine(str);
        };

        action("Hello");
        //action.Invoke();
    }
}