using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class TeacherQuery
    {
        public TeacherQuery()
        {
            name = "";
            department = "";
            age_range = "";
            gender = "";
        }
        public string name { get; set; }
        public string department { get; set; }
        public string age_range { get; set; }
        public string gender { get; set; }

    }
}
