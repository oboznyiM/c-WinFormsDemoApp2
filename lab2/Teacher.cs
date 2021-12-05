using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Teacher
    {
        public Teacher()
        {
            id = String.Empty;
            name = String.Empty;
            department = String.Empty;
            birthday = String.Empty;
            gender = String.Empty;
        }
        public Teacher (string _id, string _name, string _department, string _birthday, string _gender)
        {
            id = _id;
            name = _name;
            department = _department;
            birthday = _birthday;
            gender = _gender;   
        }

        public bool isEmpty()
        {
            return (id.Equals(String.Empty) || name.Equals(String.Empty) || department.Equals(String.Empty) || birthday.Equals(String.Empty) || gender.Equals(String.Empty));
        }
        public override string ToString()
        {
            return String.Format("Викладач: {0}\nФакультет: {1}\nДата народження: {2}\nСтать: {3}\n\n", name, department, birthday, gender);
        }
        public string id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string birthday { get; set; }
        public string gender { get; set; }
    }
}
