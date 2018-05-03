using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class WebInfoController
    {
        //实例化字典集合，管理网站信息
        Dictionary<string, Web> webInfos = new Dictionary<string, Web>();

        /// <summary>
        /// 添加网站信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="web"></param>
        public void AddItem(string name,Web web)
        {
            if (webInfos.ContainsKey(name))
            {
                Console.WriteLine("添加了相同key的数据信息:{0}",name);
                return;
            }
            foreach (var key in webInfos.Keys)
            {
                if (key == name)
                {
                    Console.WriteLine("添加了相同key的数据信息:{0}",key);
                    return;
                }
            }
            webInfos.Add(name,web);
        }

        /// <summary>
        /// 删除网站信息
        /// </summary>
        /// <param name="name"></param>
        public void DelItem(string name)
        {
            webInfos.Remove(name);
        }

        /// <summary>
        /// 更新网站信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="web"></param>
        public void UpdateItem(string name,Web web)
        {
            webInfos[name] = web;
        }

        public void ShowAll()
        {
            foreach (var item in webInfos.Keys)
            {
                Console.WriteLine("{0}-{1}",item,webInfos[item]);
            }
        }
    }
}
