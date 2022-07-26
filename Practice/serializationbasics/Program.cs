using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


    public class Program
    {
        static void Main(string[] args)
        {
        Employee Employee = new Employee();
            Employee.ID = 1001;
            Employee.name = "charan";
            Employee.gender = "M";
            Console.WriteLine(Employee);
            //XmlSerializer note = new XmlSerializer(typeof(employee));
            //Stream book = new FileStream(@"C:\charanreddy\employee.xml", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //note.Serialize(book, note);
            //book.Close();
            //Console.WriteLine(note);
        }
        
    }

