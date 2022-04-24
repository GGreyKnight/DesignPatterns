using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InterfaceSegregation
{
    public class HpLaserJet : IPrinter, IFaxContent, IScanner
    {
        public void Fax(string content)
        {
            Console.WriteLine("Hp laser jet print fax");
        }

        public void PrintColour(string content)
        {
            Console.WriteLine("Hp laser jet print colour");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Hp laser jet print gray");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Hp laser jet print scan");
        }
    }
}
