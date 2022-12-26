using ExeciseOop.ExtentionMethod;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Product pro = new();
pro.ChangColor(ConsoleColor.Magenta, ConsoleColor.White);
Console.WriteLine("Vui lòng nhập id hàng hóa kiểu String");
pro.Proid = Validate<string>.CheckReadLine();

Console.WriteLine("Vui lòng nhập số lượng hàng hóa kiểu Int");
pro.ProQuantity = Validate<int>.CheckReadLine();

Console.WriteLine("Vui lòng nhập ngày sản xuất");
pro.ProDate = Validate<DateTime>.CheckReadLine();

Console.WriteLine(pro);