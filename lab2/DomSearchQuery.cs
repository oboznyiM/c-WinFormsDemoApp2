using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab2
{
    internal class DomSearchEngine : ISearchEngine
    {
        public List<Teacher> search(TeacherQuery query)
        {
            List<Teacher> res = new List<Teacher>();
            XmlDocument doc = new XmlDocument();
            doc.Load("./data.xml");

            XmlNode node = doc.DocumentElement;
            foreach (XmlNode teacherObj in node.ChildNodes)
            {
                Teacher teacher = new Teacher();
                foreach (XmlAttribute attribute in teacherObj.Attributes)
                {
                    if (attribute.Name.Equals("ID"))
                        teacher.id = attribute.Value;
                    if (attribute.Name.Equals("NAME") && (attribute.Value.Equals(query.name) || query.name.Equals(String.Empty)))
                        teacher.name = attribute.Value;
                    if (attribute.Name.Equals("DEPARTMENT") && (attribute.Value.Equals(query.department) || query.department.Equals(String.Empty)))
                        teacher.department = attribute.Value;
                    if (attribute.Name.Equals("BIRTHDAY") && AgeValidator.validateAge(attribute, query))
                        teacher.birthday = attribute.Value;
                    if (attribute.Name.Equals("GENDER") && (attribute.Value.Equals(query.gender) || query.gender.Equals(String.Empty)))
                        teacher.gender = attribute.Value;
                }
                if (!teacher.isEmpty())
                    res.Add(teacher);
            }
            return res;
        }
    }
}
