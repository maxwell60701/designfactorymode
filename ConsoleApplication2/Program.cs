using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂
            //string key = Console.ReadLine();
            //icecream _icecream = icecreamsimplefactory.CreatesimpleFactory(key);//工厂方法
            //_icecream.taste();
            #endregion
            #region 工厂方法
            icecreamfactory _applefactory = new applefactory();
            icecream _icecreamapple = _applefactory.CreateFactory();
            _icecreamapple.taste();

            icecreamfactory _orangefactory = new orangefactory();
            icecream _icecreamorange = _orangefactory.CreateFactory();
            _icecreamorange.taste();

            icecreamfactory _bananafactory = new bananafactory();
            icecream _icecreambanana = _bananafactory.CreateFactory();
            _icecreambanana.taste();

            icecreamfactory _strawberryfactory = new strawberryfactory();
            icecream _icecreamstrawberry = _strawberryfactory.CreateFactory();
            _icecreamstrawberry.taste();

            icecreamfactory _pineapplefactory = new pineapplefactory();
            icecream _icecreampineapple = _pineapplefactory.CreateFactory();
            _icecreampineapple.taste();
            #endregion

            #region 抽象工厂
            icecreamabstractfactory _appleabstractfactory = new appleabstractfactory(); 
            guochannaiyouicecream _appleguochan = new newappleguochan();   //国产苹果
            _appleguochan.taste();
            jinkounaiyouicecream _applejinkou = new newapplejinkou();      //进口苹果
            _applejinkou.taste();


            icecreamabstractfactory _bananaabstractfactory = new bananaabstractfactory();
            guochannaiyouicecream _bananaguochan = new newbananaguochan();  //国产香蕉
            _bananaguochan.taste();
            jinkounaiyouicecream _bananajinkou = new newbananajinkou();     //进口香蕉
            _bananajinkou.taste();


            #endregion
            //总结：简单工厂,违法开闭原则，工厂方法针对单一产品结构的产品，抽象工厂针对多级产品结构。
            Console.ReadKey();

        }
    }
}
