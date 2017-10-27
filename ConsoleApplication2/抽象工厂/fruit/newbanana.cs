using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class newbananaguochan : guochannaiyouicecream
    {
        public void taste()
        {
            Console.WriteLine("国产香蕉口味");
        }
    }
    public class newbananajinkou : jinkounaiyouicecream
    {
        public void taste()
        {
            Console.WriteLine("进口香蕉口味");
        }
    }
}
