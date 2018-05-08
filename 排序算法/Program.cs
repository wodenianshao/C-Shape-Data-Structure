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
            //p.Bubbling(TestArray);
            //int index = p.ReduceHalf(TestArray,36);
            Console.WriteLine("{0}", p.Bubbling(TestArray));
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
        public int Bubbling(int[] arr)
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
            return ReduceHalf(arr, 36);
        }
        /// <summary>
        /// 折半查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public int ReduceHalf(int []arr,int keyCode)
        {
            int max = arr.Length - 1;
            int min = 0;
            while(min < max)
            {
                int mid = (max + min) / 2;
                if (keyCode < arr[mid])
                {
                    max = mid - 1;
                }
                else if(keyCode > arr[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    return mid;
                }
                Console.WriteLine("{0}-{1}",min,max);
            }
            return -1;
        }
    }
}
