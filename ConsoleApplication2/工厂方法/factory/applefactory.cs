using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class applefactory:icecreamfactory
    {
       

        public override icecream CreateFactory()
        {
            return new apple();
        }
    }
    //public enum Fruit
    //{
    //    apple,
    //    orange,
    //    banana,
    //    strawberry
    //}
}
