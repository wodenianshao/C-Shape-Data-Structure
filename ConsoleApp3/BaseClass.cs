using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("默认基类构造函数");
        }

        public BaseClass(int x)
        {
            Console.WriteLine("基类构造函数{0}",x);
        }
    }
}
