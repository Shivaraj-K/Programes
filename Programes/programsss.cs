using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programes
{
    internal class programsss
    {
        private int abc;

         public int age { get; set; }
        public int ab
        {
            get
            {
                return abc;
            }
            set
            {
                abc = value;
            }
        }
        // public void sum(int ag, string name)
        // {

        //     Console.WriteLine(ag);
        //     Console.WriteLine(name);

        // }
        // public static void Main(string[] args)
        // {

        //     programsss p = new programsss();
        //     p.age = 45;
        //     p.ab = 67;

        //     Console.WriteLine(p.age);
        //     Console.WriteLine(p.ab);

        // }

        private int _someField;

        public int Age { get; set; }

        public int Ab
        {
            get { return _someField; }
            set { _someField = value; }
        }

        public void DisplayInfo(int age, string name)
        {
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Name: {name}");
        }

        //public static void Main(string[] args)
        //{
        //    programsss p = new programsss();

        //    Console.Write("Enter age: ");
        //    p.Age = int.Parse(Console.ReadLine());

        //    Console.Write("Enter a value for Ab: ");
        //    p.Ab = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"Age: {p.Age}");
        //    Console.WriteLine($"Ab: {p.Ab}");

        //    p.DisplayInfo(p.Age, "John");

        //    p.age = 45;
        //    p.ab = 67;

        //    Console.WriteLine(p.age);
        //    Console.WriteLine(p.ab);
        //}
    }
}
