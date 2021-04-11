using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace task1
{
    class Program
    {
        // Создайте пользовательский тип (например, класс) и выполните сериализацию объекта этого
        // типа, учитывая тот факт, что состояние объекта необходимо будет передать по сети.
        static void Main(string[] args)
        {
            var emp = new Employee("Anna", 37);

            using (var stream = File.Create("EmpData.data"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, emp);
            }

            //-------------------------------------------------------------------

            using (var stream = new FileStream("EmpData.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(stream, emp);

            }

            //-------------------------------------------------------------------

            using (var stream = new FileStream("EmpDataSOAP.xml", FileMode.Create))
            {
                var formatter = new SoapFormatter();
                formatter.Serialize(stream, emp);
            }

            //-------------------------------------------------------------------

            using (TextWriter writer = new StreamWriter("EmpData.json"))
            {
                var json = JsonConvert.SerializeObject(emp);
                writer.WriteLine(json);
            }

            Console.ReadKey();
        }
    }

    [Serializable]
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
