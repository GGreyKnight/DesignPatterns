using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LiskovSubstitution
{
    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Rubber duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Rubber duck swim");
        }

        public override void Fly()
        {
            //Console.WriteLine("Rubber duck flies"); - niemożliwe, złamanie zasady podstawienia Liskov!
        }

    }
}
