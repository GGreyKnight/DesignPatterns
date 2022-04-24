using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LiskovSubstitution
{
    public class Square : Rectangle
    {
        //naruszenie zasady Liskov, nie można posługiwać się kwadratem tak jak czworokątem!
        //nie możemy zawsze traktować kwadrata jako dowolnego czworokąta!
        public override void SetHeight(int height)
        {
            _width = height;
            _height = height;
        }

        public override void SetWidth(int width)
        {
            _width = width;
            _height = width;
        }
    }
}
