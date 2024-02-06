using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public class Candidate
    {
        public Student student;
        public Position position;

        public Candidate(Student student, Position position)
        {
            this.student = student;
            this.position = position;
        }
    }
}
