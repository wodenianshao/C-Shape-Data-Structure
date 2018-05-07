using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序算法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TestArray = new int[] { 1, 2, 55, 42, 88, 90, 36, 28 };
            Program p = new Program();
            //p.SelectArray(TestArray);
            p.Bubbling(TestArray);
            Console.ReadKey();
        }

        public void OutPutArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="arr"></param>
        public void SelectArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    var temp = 0;
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            OutPutArray(arr);
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        public void Bubbling(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    var temp = 0;
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            OutPutArray(arr);
        }



    }
}
