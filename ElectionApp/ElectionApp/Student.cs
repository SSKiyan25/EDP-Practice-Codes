using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public class Student : Person
    {
        public int yearLevel { get; set; }

        public Student(int studentId, string name, Account account, int yearLevel) : base(studentId, name, account)
        {
            this.yearLevel = yearLevel;
        }
    }
}
