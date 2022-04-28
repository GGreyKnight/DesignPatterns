using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacOSTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle mac text input");
        }

        public void Render()
        {
            Console.WriteLine("Render mac text box");
        }
    }
}
