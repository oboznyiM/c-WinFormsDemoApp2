using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace lab2
{
    internal class AgeValidator
    {
        public static bool validateAge(XElement teacher, TeacherQuery query)
        {
            if (query.age_range.Equals(String.Empty))
               return true;
            DateTime birthday = Convert.ToDateTime(teacher.Attribute("BIRTHDAY").Value.ToString());
            var now = DateTime.Today;
            int age = now.Year - birthday.Year;
            //якщо 366 днів
            if (birthday.Date > now.AddYears(-age)) age--;
            if (query.age_range == "<30")
                return age < 30;
            else if (query.age_range == "30-50")
                return age >= 30 && age <= 50;
            else if (query.age_range == "51-65")
                return age >= 51 && age <= 65;
            else
                return age > 65;
        }
        public static bool validateAge(XmlReader teacher, TeacherQuery query)
        {
            if (query.age_range.Equals(String.Empty))
                return true;
            DateTime birthday = Convert.ToDateTime(teacher.Value);
            var now = DateTime.Today;
            int age = now.Year - birthday.Year;
            //якщо 366 днів
            if (birthday.Date > now.AddYears(-age)) age--;
            if (query.age_range == "<30")
                return age < 30;
            else if (query.age_range == "30-50")
                return age >= 30 && age <= 50;
            else if (query.age_range == "51-65")
                return age >= 51 && age <= 65;
            else
                return age > 65;
        }
        public static bool validateAge(XmlAttribute teacher, TeacherQuery query)
        {
            if (query.age_range.Equals(String.Empty))
                return true;
            DateTime birthday = Convert.ToDateTime(teacher.Value);
            var now = DateTime.Today;
            int age = now.Year - birthday.Year;
            //якщо 366 днів
            if (birthday.Date > now.AddYears(-age)) age--;
            if (query.age_range == "<30")
                return age < 30;
            else if (query.age_range == "30-50")
                return age >= 30 && age <= 50;
            else if (query.age_range == "51-65")
                return age >= 51 && age <= 65;
            else
                return age > 65;
        }
    }
}
