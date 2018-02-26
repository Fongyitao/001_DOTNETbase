using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_猜拳游戏
{
    class Cpu
    {
        //保存计算机出拳结果
        private string _fistName;

        public string FistName { get => _fistName; set => _fistName = value; }

        public Cpu(string fistName)
        {
            FistName = fistName;
        }

        public Cpu()
        {
        }

        //计算机出拳方法
        public int ShowFist()
        {
            Random random = new Random();
            int r = random.Next(1, 4);
            switch (r)
            {
                case 1:
                    FistName = "石头";
                    break;
                case 2:
                    FistName = "剪刀";
                    break;
                case 3:
                    FistName = "布";
                    break;
                default:
                    break;
            }
            return r;
        }
    }
}
