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
           
            //隐藏方法： 如果子类声明对象，调用隐藏方法会调用子类的；如果父类声明对象，调用隐藏方法会调用父类的。
            DerivedClss bc = new DerivedClss();
            bc.HideMethod();

            Console.WriteLine("----------------");

            BaseClass bc1 = new BaseClass();
            bc1.HideMethod();
            * */
            /***
            int[] a = new int[4] { 2, 2, 3, 4 };
            int[] b;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}-{1}",i,a[i]);
            }
            b = a;
            foreach (var item in b)
            {
                //Console.WriteLine("{0}*{1}",item,b[item]);
            }

            Console.WriteLine("------------------");
            List<int> testList = new List<int>();
            testList.Add(10);
            testList.Add(21);
            testList.Add(32);
            testList.Add(10);
            testList.Add(5);
            for (int i = 0; i < testList.Count; i++)
            {
                Console.WriteLine("{0}",testList[i]);
            }
            Console.WriteLine("------------------");
            foreach (var item in testList)
            {
                Console.WriteLine( "{0}--",item);
            }
            * */

            Console.ReadKey();


        }
    }
}