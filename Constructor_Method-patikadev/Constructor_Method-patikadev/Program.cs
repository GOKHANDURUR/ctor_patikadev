using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Method_patikadev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee3 = new Employee("mehmet", "Güler", 10, "teacher");  // Constructor Method
            employee3.EmployeeInfos();

            Console.WriteLine("**********");

            Employee employee4 = new Employee("koute", "De Souza");   // Constructor Method
            employee4.EmployeeInfos();

            Console.WriteLine("**********");

            Employee employee1 = new Employee();
            employee1.Name = "gökhan";
            employee1.Surname = "durur";
            employee1.Number = 56594875;
            employee1.Occupation = "Engineer";
            employee1.EmployeeInfos();

            Console.WriteLine("**********");

            Employee employee2 = new Employee();
            employee2.Name = "gökhan";
            employee2.Surname = "Siyam";
            employee2.Number = 25654148;
            employee2.Occupation = "Director";
            employee2.EmployeeInfos();

        }
    }

    class Employee
    {
        // Constructor Methods
        public Employee(string name, string surname, int number, string occupation)
        {
            Name = name;
            this.Surname = surname;
            Number = number;
            this.Occupation = occupation;
        }
        public Employee(string name, string surname)
        {
            Name = name;
            this.Surname = surname;
        }
        public Employee()
        {

        }


        public string Name;
        public string Surname;
        public int Number;
        public string Occupation;

        public void EmployeeInfos()
        {
            Console.WriteLine("Employee name : " + Name);
            Console.WriteLine("Employee surname : " + Surname);
            Console.WriteLine("Employee number : " + Number);
            Console.WriteLine("Employee occupation : " + Occupation);
        }
    }
    
}
