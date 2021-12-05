using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace lab2
{
    static internal class DataLoader
    {
        public static XmlNodeList GetData()
        { 
            XmlDocument doc = new XmlDocument();
            doc.Load("./data.xml");
            XmlElement xmlRoot = doc.DocumentElement;
            XmlNodeList staff = xmlRoot.SelectNodes("Staff");
            return staff;
        }
        public static void SaveHTML()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load("./xsltT.xslt");
            string fXML = "./data.xml";
            string fHTML = "./htmlT.html";
            xct.Transform(fXML, fHTML);
        }
    }
}
