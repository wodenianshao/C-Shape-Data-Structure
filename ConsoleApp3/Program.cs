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
            BaseClass bc = new DerivedClss();

            Console.ReadKey();
        }
    }
}
