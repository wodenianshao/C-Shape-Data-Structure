using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ml = new MyList<int>();
            ml.Add(25);
            ml.Add(10);
            ml.Add(52);
            ml.Add(5);
            ml.Add(5);
            for (int i = 0; i < ml.Count; i++)
            {
                //Console.WriteLine("{0}",ml.GetItem(i));
                Console.WriteLine("{0}",ml[i]);
            }
            Console.WriteLine( "-----------------" );
            ml.RemoveAt(2);
            ml.ShowAll();
            Console.ReadKey();
        }
    }
}
