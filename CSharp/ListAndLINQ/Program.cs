using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ListAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student() {RollNumber = 1, FullName = "Nhat Hoang0", Section = "Day so 1", HostelNumber = 1},
                new Student() {RollNumber = 2, FullName = "Nhat Hoang1", Section = "Day so 1", HostelNumber = 2},
                new Student() {RollNumber = 3, FullName = "Nhat Hoang2", Section = "Day so 2", HostelNumber = 3},
                new Student() {RollNumber = 4, FullName = "Nhat Hoang3", Section = "Day so 2", HostelNumber = 4},
                new Student() {RollNumber = 5, FullName = "Nhat Hoang4", Section = "Day so 3", HostelNumber = 5},
                new Student() {RollNumber = 6, FullName = "Nhat Hoang5", Section = "Day so 3", HostelNumber = 5},
                new Student() {RollNumber = 7, FullName = "Nhat Hoang6", Section = "Day so 4", HostelNumber = 6},
                new Student() {RollNumber = 8, FullName = "Nhat Hoang7", Section = "Day so 4", HostelNumber = 7},
                new Student() {RollNumber = 9, FullName = "Nhat Hoang8", Section = "Day so 5", HostelNumber = 8},
                new Student() {RollNumber = 10, FullName = "Nhat Hoang9", Section = "Day so 5", HostelNumber = 9},
            };

            //Stopwatch sw = new Stopwatch();
            //sw.Restart();
            //foreach(var stu in list)
            //{
            //    Console.WriteLine(stu);
            //}
            //Console.WriteLine($"forech time: {sw.ElapsedMilliseconds}");
            //sw.Restart();

            ////Tất cả các dạng của collection đều có sẵn mẫu để duyệt qua dữ liệu mà không dùng for hay foreach => ienumarator
            //IEnumerator enu = list.GetEnumerator();
            //while (enu.MoveNext())
            //{
            //    Console.WriteLine(enu.Current);
            //}
            //Console.WriteLine($"forech time: {sw.ElapsedMilliseconds}");
            //sw.Restart();

            //linq => language Intergrated query

            //ling to object
            //linq to sql
            //linq to xml, json
            //parallel linq => plinq

            //select from where group by having order
            //from where group by having order => select

            //linq to object có 2 dạng
            //style 1: theo trường phái sql => query syntax, dễ học, dễ hiểu
            //style 2: theo trường phái lamda => method syntax, khó học, khó hiểu

            //Liệt kê tất cả sinh viên với mã sinh viên phải lớn hơn 2
            //foreach (var stu in list)
            //{
            //    if(stu.RollNumber > 2)
            //    {
            //        Console.WriteLine(stu);
            //    }
            //}

            //Console.WriteLine("====================================================================");

            ////linq to object style 1
            ////var liststu = from s in list where s.RollNumber > 2 select s;
            ////tìm tổng số sinh viên trong list
            ////Console.WriteLine(liststu.Count());

            //foreach(var ls in from s in list where s.RollNumber > 2 select s)
            //{
            //    Console.WriteLine(ls);
            //}

            //Console.WriteLine("====================================================================");

            ////linq to object style 2
            ////var liststu = list.Where(stu => stu.RollNumber > 2);
            //foreach(var ls in list.Where(stu => stu.RollNumber > 2))
            //{
            //    Console.WriteLine(ls);
            //}

            //Console.WriteLine("====================================================================");

            ////các phương thức có sẵn trong list
            //list.ForEach(Console.WriteLine);
            //Console.WriteLine("====================================================================");
            //list.ForEach(
            //    stu =>
            //    {
            //        if (stu.RollNumber > 2)
            //        {
            //            Console.WriteLine(stu);
            //        }
            //    }
            //);

            //Console.WriteLine("====================================================================");

            ////kết hợp lamda với phương thức có sẵn của list
            //list.Where(stu => stu.RollNumber > 2).ToList().ForEach(Console.WriteLine);

            //var r = from stu in list where stu.RollNumber > 2 select new //anonymous type
            //{
            //    stu.RollNumber,
            //    stu.FullName
            //};
            //r.ToList().ForEach(Console.WriteLine);

            //var r = from stu in list
            //        where stu.RollNumber > 2
            //        select new //anonymous type
            //        {
            //            StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
            //            StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
            //        };
            //r.ToList().ForEach(Console.WriteLine);

            //list.Select(stu => new
            //{
            //    StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
            //    StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
            //}).ToList().ForEach(Console.WriteLine);

            //foreach (var stu in list)
            //{
            //    Console.WriteLine(stu);
            //}
            //IEnumerator enu = list.GetEnumerator();
            //while (enu.MoveNext())
            //{

            //}
            //// từ khi có linq
            //var t = from stu in list select stu;

            ////select * from list where rollnumber > 2
            //IEnumerable<Student> i = from stu in list where stu.RollNumber > 2 select stu;
            ////là vào bộ nhớ loại bỏ chỉ lấy 2 dòng đầu tiên
            //i = i.Take(2);
            ////===============================
            ////lần đầu tiên thực thi trên server và trả về bộ nhớ
            ////select * from list where rollnumber > 2
            //IQueryable<Student> u = from stu in list.AsQueryable() where stu.RollNumber > 2 select stu;
            ////select top(2) * From list where rollnumber >3 
            ////sẽ chạy lên server lần nữa
            //u = u.Take(2);
            ////===============================
            //var k = from stu in list where stu.RollNumber > 2 select stu;
            //k.ToList().ForEach(Console.WriteLine);

            //sắp xếp 
            //var obj1 = from stu in list orderby stu.Section descending, stu.HostelNumber ascending select stu;
            //var obi2 = list.OrderByDescending(stu => stu.Section).OrderBy(stu => stu.HostelNumber);
        }
    }
}
