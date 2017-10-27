using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class orangeabstractfactory : icecreamabstractfactory
    {
        public override guochannaiyouicecream CreateguochannaiyouFactory()
        {
            return new neworangeguochan();
        }

        public override jinkounaiyouicecream CreatejinkounaiyouFactory()
        {
            return new neworangejinkou();
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
