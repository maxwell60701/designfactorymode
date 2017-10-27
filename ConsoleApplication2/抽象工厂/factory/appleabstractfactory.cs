using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class appleabstractfactory : icecreamabstractfactory
    {
        public override guochannaiyouicecream CreateguochannaiyouFactory()
        {
            return new newappleguochan();
        }

        public override jinkounaiyouicecream CreatejinkounaiyouFactory()
        {
            return new newapplejinkou();
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
