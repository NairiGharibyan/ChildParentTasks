using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildTask
{
    internal class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Parent parent1 { get; set; }
        public Parent parent2 { get; set; }
        public Child(string name, int age, Parent obj1, Parent obj2) {
            Name = name;
            Age = age;
            parent1 = obj1;
            parent2 = obj2;
        }

     
    }
}
