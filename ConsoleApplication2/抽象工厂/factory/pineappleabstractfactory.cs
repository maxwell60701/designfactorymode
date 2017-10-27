using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class pineappleabstractfactory : icecreamabstractfactory
    {
        public override guochannaiyouicecream CreateguochannaiyouFactory()
        {
            return new newpineappleguochan();
        }

        public override jinkounaiyouicecream CreatejinkounaiyouFactory()
        {
            return new newpineapplejinkou();
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
