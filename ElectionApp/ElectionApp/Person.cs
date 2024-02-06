using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public abstract class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public Account account { get; set; }

        protected Person(int id, string name, Account account)
        {
            this.id = id;
            this.name = name;
            this.account = account;
        }
    }
}
