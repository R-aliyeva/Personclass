using System.Xml.Linq;

namespace Personclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Please write your name...");
           var names = Console.ReadLine();
            Console.WriteLine("Please write your surname...");
            var surnames = Console.ReadLine();
            Console.WriteLine("Please write your age...");
            var ages = Console.ReadLine();
           Console.WriteLine("Please write your weight...");
           var weights = Console.ReadLine();
           Console.WriteLine("Please write your height...");
           var heights= Console.ReadLine();

            Person person = new Person(names,surnames,ages,weights,heights);

            Console.WriteLine(person.ToString());
            





        }
        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Age { get; set; }
            public string Weight { get; set; }
            public string Height { get; set; }
            Person() { }
            Person(string name, string surname, string age, string weight, string height)

            {
                name = Name;
                surname = Surname;
                Age = age;
                Weight = weight;
                Height = height;

            }
            public override string ToString()
            {
                return (Name + " " + Surname);
                
                // return string.Concat(Name,Surname,Age, Weight, Height);
                //return $"Name:{Name}, Surname:{Surname}, Weight:{Weight}, Height:{Height}";
                //return "Name " + Name + " " + "Surname" + Surname + " " + "Weight" + Weight + " " + "Height" + Height + " " + "Age" + Age;
            }
        }
    }
}