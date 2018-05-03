using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WebInfoController wc = new WebInfoController();
            wc.AddItem("淘宝网",new Web("淘宝网","www.taobao.com","马云"));
            wc.AddItem("人民网", new Web("人民网", "www.renmin.com", "李彦宏"));
            wc.AddItem("新浪微博", new Web("新浪微博", "www.xinlang.com", "刘强东"));
            wc.AddItem("新浪微博", new Web("新浪微博", "www.xinlang.com", "刘强东"));
            wc.ShowAll();

            Console.WriteLine("--------------------");
            wc.DelItem("淘宝网");
            wc.ShowAll();

            Console.WriteLine("--------------------");
            wc.UpdateItem("人民网", new Web("人民网", "www.renmin.com", "立夏蛋"));
            wc.ShowAll();
            Console.ReadKey();
        }
    }
}
