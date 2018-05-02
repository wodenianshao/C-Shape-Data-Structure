using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string command = Console.ReadLine();
            //Console.WriteLine(command);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("a", "aaa");
            dic.Add("b", "bbb");
            dic.Add("c", "ccc");
            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0}:{1}",item,dic[item]);
            }

            dic.Remove("a");
            foreach (var item in dic.Values)
            {
                Console.WriteLine("{0}",item);
            }
            Console.ReadKey();
        }
    }
}
;