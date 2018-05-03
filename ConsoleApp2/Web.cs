using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// 实体类
    /// </summary>
    class Web
    {
        private string name;
        private string url;
        private string boss;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Url
        {
            set
            {
                url = value;
            }
            get
            {
                return url;
            }
        }

        public string Boss
        {
            set
            {
                boss = value;
            }
            get
            {
                return boss;
            }
        }

        public Web(string name, string url, string boss)
        {
            this.name = name;
            this.url = url;
            this.boss = boss;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", name, url, boss);
        }
    }
}
