using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class bananafactory : icecreamfactory
    {


        public override icecream CreateFactory()
        {
            return new banana();
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
