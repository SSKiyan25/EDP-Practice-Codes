using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public class Faculty : Person
    {
        public int isAdviser { get; set; }

        public Faculty(int facultyId, string name, Account account, int isAdviser) : base(facultyId, name, account) 
        {
            this.isAdviser = isAdviser;
        }
    }
}
