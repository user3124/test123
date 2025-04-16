using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iclonable0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tom = new Person("Tom", 23, new Company("Microsoft"));
            var bob = (Person)tom.Clone();

            Console.WriteLine(bob.Work.Name + ", " + bob.Name + ", " + bob.Age);

            bob.Work.Name = "Google";
            bob.Name = "Bob";
            Console.WriteLine(bob.Work.Name + ", " + bob.Name + ", " + bob.Age);
        }
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public Person(string name, int age, Company company)
        {
            Name = name;
            Age = age;
            Work = company;
        }
        public object Clone() => new Person(Name, Age, new Company(Work.Name));
    }
    class Company
    {
        public string Name { get; set; }
        public Company(string name) => Name = name;
    }
}
