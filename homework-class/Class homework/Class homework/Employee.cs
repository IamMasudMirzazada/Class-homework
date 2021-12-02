using System;
using System.Collections.Generic;
using System.Text;

namespace Class_homework
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Position;
        public int DailySalary;

        public Employee(string name,string surname,string position,int dailysalary)
        {
            Name = name;
            Surname = surname;
            Position = position;
            DailySalary = dailysalary;
        }

        public string Calc ()
        {
            
            var result = $"{Name} {Surname} {Position} {DailySalary*30}" ;
            return result;
        }
    }
}
