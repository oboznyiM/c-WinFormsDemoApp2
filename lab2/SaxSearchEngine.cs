using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace lab2
{
    internal class SaxSearchEngine : ISearchEngine
    {
        public List<Teacher> search(TeacherQuery query)
        {
            var res = new List<Teacher>();
            var xmlReader = new XmlTextReader("./data.xml");
            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        Teacher teacher = new Teacher();

                        if (xmlReader.Name.Equals("ID"))
                        {
                            teacher.id = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("NAME") && (query.name.Equals(String.Empty) || query.name.Equals(xmlReader.Value)))
                            {
                                teacher.name = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("DEPARTMENT") && (query.department.Equals(String.Empty) || query.department.Equals(xmlReader.Value)))
                                {
                                    teacher.department = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("BIRTHDAY") && AgeValidator.validateAge(xmlReader, query))
                                    {
                                        teacher.birthday = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("GENDER") && (query.gender.Equals(String.Empty) || query.gender.Equals(xmlReader.Value)))
                                        {
                                            teacher.gender = xmlReader.Value;
                                        }
                                    }
                                }
                            }
                        }
                        if (!teacher.isEmpty())
                            res.Add(teacher);
                    }
                }
            }
            xmlReader.Close();
            return res;
        }
    }
}
