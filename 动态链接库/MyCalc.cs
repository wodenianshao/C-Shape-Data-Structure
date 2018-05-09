using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动态链接库
{
    public class MyCalc
    {
        /// <summary>
        /// 两个数相加
        /// </summary>
        /// <param name="a">加数</param>
        /// <param name="b">被加数</param>
        /// <returns>结果</returns>
        public float Add(float a , float b)
        {
            return a + b;
        }
        /// <summary>
        /// 两个数相减
        /// </summary>
        /// <param name="a">减数</param>
        /// <param name="b">被减数</param>
        /// <returns>差值</returns>
        public float Subtraction(float a, float b)
        {
            return a - b;
        }
        /// <summary>
        /// 两数相乘
        /// </summary>
        /// <param name="a">乘数</param>
        /// <param name="b">被乘数</param>
        /// <returns>积</returns>
        public float Multiplication(float a, float b)
        {
            return a * b;
        }
        /// <summary>
        /// 两数相除
        /// </summary>
        /// <param name="a">除数</param>
        /// <param name="b">被除数</param>
        /// <waring>被除数不能为0</waring>
        /// <returns>商值</returns>
        public float Division(float a, float b)
        {
            if (b == 0)
            {
                throw new Exception("被除数不能为0");
            }
            return a / b;
        }
         
    }
}
