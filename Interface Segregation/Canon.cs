using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InterfaceSegregation
{
    public class Canon : IPrinter, IFaxContent
    {
        public void Fax(string content)
        {
            Console.WriteLine("Canon print fax");
        }

        public void PrintColour(string content)
        {
            Console.WriteLine("Canon print colour");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Canon print gray");
        }
    }
}
