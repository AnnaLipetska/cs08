using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using task2;

namespace task3
{
    class Program
    {
        // Создайте новое приложение, в котором выполните десериализацию объекта из предыдущего
        // примера.Отобразите состояние объекта на экране.
        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Employee));
            var serializerAttr = new XmlSerializer(typeof(EmployeeAttr));

            Employee emp;
            EmployeeAttr empAttr;

            using (FileStream stream = new FileStream("Emp.xml", FileMode.Open, FileAccess.Read))
            {
                emp = serializer.Deserialize(stream) as Employee;
            }

            using (FileStream stream = new FileStream("EmpAttr.xml", FileMode.Open, FileAccess.Read))
            {
                empAttr = serializerAttr.Deserialize(stream) as EmployeeAttr;
            }

            if (emp != null)
            {
                Console.WriteLine($"{emp.Name} - {emp.Age}");
            } 

            if (empAttr != null)
            {
                Console.WriteLine($"{empAttr.Name} - {empAttr.Age}");
            }

            Console.ReadKey();
        }
    }
}
