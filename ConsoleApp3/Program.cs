using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 
            Magpie mp = new Magpie();
            mp.Fly();

            //可以使用抽象类申明对象，但是不可以实例化对象，需要通过子类去实现
            Bird bd = new Magpie();
            bd.Fly();
            * */
            //隐藏方法： 如果子类声明对象，调用隐藏方法会调用子类的；如果父类声明对象，调用隐藏方法会调用父类的。
            DerivedClss bc = new DerivedClss();
            bc.HideMethod();

            Console.WriteLine("----------------");

            BaseClass bc1 = new BaseClass();
            bc1.HideMethod();
            Console.ReadKey();
        }
    }
}
