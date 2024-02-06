using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public class Election
    {
        public int electionID { get; set; }
        public int year { get; set; }
        public DateTime electionPeriod { get; set; }

        public Election(int electionID, int year, DateTime electionPeriod)
        {
            this.electionID = electionID;
            this.year = year;
            this.electionPeriod = electionPeriod;
        }
    }
}
