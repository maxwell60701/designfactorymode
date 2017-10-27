using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class neworangeguochan : guochannaiyouicecream
    {
        public void taste()
        {
            Console.WriteLine("国产橘子口味");
        }
    }
    public class neworangejinkou : jinkounaiyouicecream
    {
        public void taste()
        {
            Console.WriteLine("进口橘子口味");
        }
    }
}
