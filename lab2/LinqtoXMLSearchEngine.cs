using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class LinqtoXMLSearchEngine : ISearchEngine
    {
        public List<Teacher> search(TeacherQuery query)
        {
            var doc = System.Xml.Linq.XDocument.Load("./data.xml");
            var resp = from teacher in doc.Descendants("Staff")
                         where
                         (
                            (teacher.Attribute("NAME").Value.Equals(query.name) || query.name.Equals(String.Empty)) &&
                            (teacher.Attribute("DEPARTMENT").Value.Equals(query.department) || query.department.Equals(String.Empty)) &&
                            (teacher.Attribute("GENDER").Value.Equals(query.gender) || query.gender.Equals(String.Empty)) &&
                            AgeValidator.validateAge(teacher, query)
                           )
                         select new Teacher
                         (
                             (string)teacher.Attribute("ID"),
                             (string)teacher.Attribute("NAME"),
                             (string)teacher.Attribute("DEPARTMENT"),
                             (string)teacher.Attribute("BIRTHDAY"),
                             (string)teacher.Attribute("GENDER")
                         );
            List<Teacher> res = new List<Teacher>();
            foreach(var teacher in resp)
                res.Add(teacher);
            return res;
        }
    }
}
