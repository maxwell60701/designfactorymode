using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class newappleguochan : guochannaiyouicecream
    {
        public void taste()
        {
            Console.WriteLine("国产苹果口味");
        }
    }
    public class newapplejinkou : jinkounaiyouicecream
    {
        public void taste()
        {
            Console.WriteLine("进口苹果口味");
        }
    }
}
