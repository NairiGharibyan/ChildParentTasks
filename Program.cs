using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParentChildTask
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Child[] children = new Child[]
{
            new Child("Tigran", 13, new Parent("Anna", 32, 270000), new Parent("Arman", 44, 500000)),
            new Child("Mariam", 10, new Parent("Lilit", 30, 150000), new Parent("Karen", 38, 320000)),
            new Child("David", 15, new Parent("Sona", 28, 190000), new Parent("Artak", 35, 280000)),
            new Child("Narek", 8, new Parent("Mane", 29, 200000), new Parent("Gor", 33, 350000)),
            new Child("Ani", 14, new Parent("Elina", 31, 220000), new Parent("Hovhannes", 41, 410000)),
            new Child("Aram", 12, new Parent("Lusine", 27, 180000), new Parent("Samvel", 34, 330000)),
            new Child("Suren", 16, new Parent("Narine", 33, 170000), new Parent("Levon", 39, 340000)),
            new Child("Hayk", 9, new Parent("Gayane", 29, 210000), new Parent("Vahagn", 37, 360000)),
            new Child("Sofia", 11, new Parent("Marine", 30, 190000), new Parent("Tigran", 40, 400000)),
            new Child("Emma", 13, new Parent("Arpine", 28, 250000), new Parent("Ashot", 36, 450000))

};

            Console.WriteLine("\nChildren whose parents' combined age does NOT exceed 70:");
            foreach (Child child in children) {
                if (child.parent1.Age + child.parent2.Age <= 70) {
                    Console.WriteLine($"Child name - {child.Name}, Age - {child.Age}");
                }

            }

            Console.WriteLine("\nThe oldest childs father Salary");
            Child oldest_child = children[0];
            int oldest_child_index = 0;
            for (int i = 1; i < children.Length; i++) {
                if (children[i].Age > oldest_child.Age) {
                    oldest_child_index = i;
                    oldest_child = children[i];
                }
            }
            Console.WriteLine($"Child name - {oldest_child.Name}, FatherSalary - {oldest_child.parent2.Salary}");

            Console.WriteLine("\nThe Child whos family has the most income");

            Child rich_child = children[0];
            for (int i = 1; i < children.Length; i++) {
                int family_income = children[i].parent1.Salary + children[i].parent2.Salary;
                if (family_income > rich_child.parent1.Salary + rich_child.parent2.Salary) {
                    rich_child = children[i];
                }
            }
            Console.WriteLine($"Child name - {rich_child.Name}, Age - {rich_child.Age}");


            Console.WriteLine("\nChildren after swapping youngest and oldest:");
            Child young_child = children[0];
            int young_child_index = 0;
            for (int i = 1; i < children.Length; i++)
            {
                if (children[i].Age < young_child.Age)
                {
                    young_child = children[i];
                    young_child_index = i;
                }
            }

            Console.WriteLine($"Oldest CHild - {oldest_child.Name},  {oldest_child.Age}");
            Console.WriteLine($"Youngest CHild - {young_child.Name},  {young_child.Age}");
            
            Child tmp = children[oldest_child_index];
            children[oldest_child_index] = children[young_child_index];
            children[young_child_index] = tmp;



            foreach (Child child in children) {
                Console.WriteLine($"Child Name - {child.Name}, Age - {child.Age}");
            }
            Console.Read();
        }
    }
}
