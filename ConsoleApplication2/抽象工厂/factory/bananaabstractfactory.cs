using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class bananaabstractfactory : icecreamabstractfactory
    {
        public override guochannaiyouicecream CreateguochannaiyouFactory()
        {
            return new newbananaguochan();
        }

        public override jinkounaiyouicecream CreatejinkounaiyouFactory()
        {
            return new newbananajinkou();
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
