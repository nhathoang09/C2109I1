using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLINQ
{
    class Student
    {
        public int RollNumber { get; set; }
        public string FullName { get; set; }
        public string Section { get; set; }
        public int HostelNumber { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(RollNumber)}={RollNumber.ToString()},{nameof(FullName)}={FullName.ToString()},{nameof(Section)}={Section.ToString()},{nameof(HostelNumber)}={HostelNumber.ToString()}}}";
        }
    }
}
