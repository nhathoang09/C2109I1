using Tuple;

Person per = new()
{
    Id = 0,
    FirstName = "Nhat",
    LastName = "Hoang"
};

Console.WriteLine(per.Id);
Console.WriteLine(per.FirstName);

//dùng tuble không cần dùng đến class
ValueTuple<int, string, string> p1 = (1, "Le Nhat1", "Hoang1");
Console.WriteLine(p1.Item1);
Console.WriteLine(p1.Item3);

//mới hơn
(int, string, string) p2 = (2, "Nhat2", "Hoang2");
Console.WriteLine(p2.Item2);
Console.WriteLine(p2.Item3);

//dùng var
var p3 = (3, "Hoang3", "Le3");//value tuple

var p4 = (1);// variable int p4 = 1

//net core dùng name thay thế cho các loại item1, item2...

(int id, string firstname, string lastname) p5 = (5, "Nhat5", "Hoang5");
Console.WriteLine(p5.firstname);
Console.WriteLine(p5.lastname);

//hoặc dùng name phía trước
var p6 = (id: 6, firstname: "Nhat6", lastname: "Hoang6");
Console.WriteLine(p6.firstname);
Console.WriteLine(p6.lastname);

//không phải là tulbe => anonymous type
var p7 = new { id = 7, firstname = "Nhat7", lastname = "Hoang7" };
Console.WriteLine(p7.firstname);
Console.WriteLine(p7.lastname);