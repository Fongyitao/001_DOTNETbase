using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_练习
{
    class ItcastClass
    {
        private string[] _names = new string[5] { "张三", "李四", "王五", "赵六", "田七" };
        public int Count
        {
            get
            {
                return _names.Length;
            }
        }

        //索引器其实就是一个特殊的属性,常规情况下索引器其实都是一个名字叫Item的属性
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return _names[index];
                }
            }
            set
            {
                _names[index] = value;
            }
        }
    }
}
