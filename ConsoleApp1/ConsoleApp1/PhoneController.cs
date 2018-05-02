using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhoneController
    {
        Dictionary<string, string> phones = new Dictionary<string, string>();
        /// <summary>
        /// 添加信息数据
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        public void AddItems(string name,string number)
        {
            phones.Add(name,number);
        }

        /// <summary>
        /// 查询信息
        /// </summary>
        public void ShowAll()
        {
            foreach (var item in phones.Keys)
            {
                Console.WriteLine("{0}:{1}",item,phones[item]);
            }
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="名字"></param>
        public void DellItem(string name)
        {
            phones.Remove(name);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="name"></param>
        /// <param name="values"></param>
        public void UpdateItem(string name,string number)
        {
            phones[name] = number;
        }
    }
}
