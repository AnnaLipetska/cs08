using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task2
{
    class Program
    {
        // Создайте класс, поддерживающий сериализацию. Выполните сериализацию объекта этого
        // класса в формате XML.Сначала используйте формат по умолчанию, а затем измените его
        // таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML.
        static void Main(string[] args)
        {
            var emp = new Employee("Anna", 37);
            var empAttr = new EmployeeAttr("Vova", 40);

            var serializer = new XmlSerializer(typeof(Employee));
            var serializerAttr = new XmlSerializer(typeof(EmployeeAttr));

            using (var stream = new FileStream("Emp.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, emp);
            }

            using (var stream = new FileStream("EmpAttr.xml", FileMode.Create, FileAccess.Write))
            {
                serializerAttr.Serialize(stream, empAttr);
            }

            Console.ReadKey();
        }
    }
}
