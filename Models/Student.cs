using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsMangment.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string CourseTitle { get; set;  }
        public string Email { set; get;  }
    }
}
