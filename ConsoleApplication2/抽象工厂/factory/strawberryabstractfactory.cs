using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class strawberryabstractfactory : icecreamabstractfactory
    {
        public override guochannaiyouicecream CreateguochannaiyouFactory()
        {
            return new newstrawberryguochan();
        }

        public override jinkounaiyouicecream CreatejinkounaiyouFactory()
        {
            return new newstrawberryjinkou();
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
