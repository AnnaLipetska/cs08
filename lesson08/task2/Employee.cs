using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Employee()
        {

        }
    }
}
