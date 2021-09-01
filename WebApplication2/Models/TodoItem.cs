using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TodoItem
    {
            public long Id { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            public string Occupation { get; set; }
            public bool IsVeteran { get; set; }
            public int Fees { get; set; }
            public DateTime MemberDate { get; set; }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

    }
}

