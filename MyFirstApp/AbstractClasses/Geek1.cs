using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.AbstractClasses
{
    public class Geek1 : GeeksForGeeks
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void gfg()
        {
            throw new NotImplementedException();
        }
    }
}
