using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public class Position
    {
        public string positionName {  get; set; }
        public string description { get; set; }

        public Position(string positionName, string description)
        {
            this.positionName = positionName;
            this.description = description;
        }
    }
}
