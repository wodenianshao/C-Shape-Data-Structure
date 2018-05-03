using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DerivedClss:BaseClass
    {
        public DerivedClss():base()
        {
            Console.WriteLine("派生类构造函数");
        }

        public new void HideMethod()
        {
            Console.WriteLine("子类的隐藏方法");
        }
    }
}
