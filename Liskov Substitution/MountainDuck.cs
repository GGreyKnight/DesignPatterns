using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LiskovSubstitution
{
    public class MountainDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Mountaing duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Mountaing duck swim");
        }

        public override void Fly()
        {
            Console.WriteLine("Mountaing duck flies");
        }

    }
}
