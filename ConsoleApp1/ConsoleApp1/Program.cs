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

            //实例化(通讯录)
            PhoneController pc = new PhoneController();
            pc.AddItems("Shelly","15866523550");
            pc.AddItems("Mark", "15866444550");
            //查看
            pc.ShowAll();
            //修改
            pc.UpdateItem("Mark1","110");
            pc.DellItem("Mark1");
            pc.ShowAll();
            Console.ReadKey();
        }
    }
}
;