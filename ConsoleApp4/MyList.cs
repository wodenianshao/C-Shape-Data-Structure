using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MyList<T> where T : IComparable
    {
        private T[] array;
        private int count = 0;

        public MyList()
        {
            array = new T[0];
        }

        public MyList(int size)
        {
            array = new T[size];
        }
        /// <summary>
        /// 容量
        /// </summary>
        public int Capacity
        {
            private set
            {

            }
            get
            {
                return array.Length;
            }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                if (Capacity == 0)
                {
                    array = new T[4];
                }
                else
                {
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array, newArray, Count);
                    array = newArray;
                }
            }
            array[count] = item;
            count++;
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < Count)
            {
                return array[index];
            }
            else
            {
                throw new Exception("Out of Range");
            }
        }

        public T this[int index]
        {
            set
            {
                if (index >= 0 && index < Count)
                {
                    array[index] = value;
                }
            }

            get
            {
                return GetItem(index);
            }
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index < Count)
            {
                if (Count == Capacity)
                {
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array, newArray, Count);
                    array = newArray;
                }
                for (int i = Count - 1; i >= index; i--)
                {
                    array[i + 1] = array[i];
                }
                array[index] = item;
                count++;
            }
            else
            {
                throw new Exception("超出范围");
            }
        }
        /// <summary>
        /// 移除集合中的数据
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= Count)
            {
                //for (int i = index + 1; i < Count ; i++)
                //{
                //    array[i - 1] = array[i];
                //}
                for (int i = index; i < Count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;
            }
            else
            {
                throw new Exception("不存在这个索引");
            }
        }

        /// <summary>
        /// 返回数据第一次出现的索引
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 返回数据最后一次出现的索引
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int LastIndexOf(T item)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 集合数据排序
        /// </summary>
        public void Sort()
        {
            for (int j = 0; j < Count - 1; j++)
            {
                for (int i = 0; i < Count - 1 - j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        public void ShowAll()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("{0}-->{1}",i,array[i]);
            }
        }

    }
}
