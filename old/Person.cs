using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Person
    {
        string name;
        string age;
        public string Name { get => name; set => name = value; }
        public string Age { get => age; }

        public void SayHi()
        {
            Console.WriteLine($"Hi {name}!");
        }
    }
}
