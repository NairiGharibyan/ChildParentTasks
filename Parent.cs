using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildTask
{
    internal class Parent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Parent(string name, int age, int salary) {
            Name = name;
                Age = age;
            Salary = salary;
        }


    }
}
