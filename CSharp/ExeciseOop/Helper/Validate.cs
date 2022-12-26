namespace ExeciseOop.Helper
{
    internal class Validate<T>
    {
        public static T CheckReadLine()
        {
            var typeCode = Type.GetTypeCode(typeof(T));
            var obj = new Object();
            bool flag;
            do
            {
                flag = true;
                try
                {
                    var str = Console.ReadLine();
                    if(string.IsNullOrEmpty(str))
                    {
                        throw new Exception("Error, null or empty");
                    }
                    switch (typeCode)
                    {
                        case TypeCode.String:
                            obj = str;
                            break;
                        case TypeCode.Int32:
                            obj = Convert.ToInt32(str);
                            if ((int)obj < 0) throw new Exception("Value must be greater than zero");
                            break;
                        case TypeCode.Double:
                            obj = Convert.ToDouble(str);
                            if ((double)obj < 0) throw new Exception("Value must be greater than zero");
                            break;
                        case TypeCode.DateTime:
                            var date = DateTime.TryParseExact(str, new[] { "d/M/yyyy", "d-M-yyyy" }, new CultureInfo("vi-VN"),
                                DateTimeStyles.None, out var t)? t: throw new Exception("Datetime wrong (d/m/yyyy or d-m-yyyy)");
                            obj = date.Add(DateTime.Now.TimeOfDay);
                            break;
                        default:
                            obj = null;
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.GetType()}:{e.Message}, please enter again");
                    flag = false;
                }
            }while(!flag);

            return (T)obj;
        }
    }
}
