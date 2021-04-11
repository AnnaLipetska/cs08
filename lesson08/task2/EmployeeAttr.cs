using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task2
{
    public class EmployeeAttr
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public int Age { get; set; }

        public EmployeeAttr(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public EmployeeAttr()
        {

        }
    }
}
