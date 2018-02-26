using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_猜拳游戏
{
    class Player
    {
        //保存玩家出拳
        private string _firstName;

        public string FirstName { get => _firstName; set => _firstName = value; }

        public Player(string firstName)
        {
            FirstName = firstName;
        }

        public Player()
        {
        }

        //玩家出拳方法
        public int ShowFist(string fist)
        {
            FirstName = fist;
            int result=-1;
            switch (FirstName)
            {
                case "石头":
                    result = 1;
                    break;
                case "剪刀":
                    result = 2;
                    break;
                case "布":
                    result = 3;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
