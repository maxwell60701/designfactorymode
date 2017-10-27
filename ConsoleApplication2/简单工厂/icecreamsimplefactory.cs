using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class icecreamsimplefactory
    {
        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <param name="fruit"></param>
        /// <returns></returns>
        public static icecream CreatesimpleFactory(string fruit)
        {
            if(fruit==Fruit.apple.ToString())
            {
                return new apple();
            }
            if (fruit == Fruit.orange.ToString())
            {
                return new orange();
            }
            if (fruit == Fruit.banana.ToString())
            {
                return new banana();
            }
            if (fruit == Fruit.strawberry.ToString())
            {
                return new strawberry();
            }
            else
            {
                throw new Exception("无此水果");
            }

        }
        
    }

   
    public enum Fruit
    {
        apple,
        orange,
        banana,
        strawberry
    }
}
