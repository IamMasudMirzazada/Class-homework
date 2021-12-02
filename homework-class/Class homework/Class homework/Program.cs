using System;

namespace Class_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("Kamran", "Jabiyev","Programmer",100);
            Console.WriteLine(person1.Calc());
        }
    }
}
