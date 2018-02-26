using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_猜拳游戏
{
    class Judge
    {
        //玩家赢:石头1-剪刀2=-1    剪刀2-布3=-1   布3-石头1=2
        //电脑赢:石头1-布3=-2     剪刀2-石头1=1   布3-剪刀2=1
        public string IsWin(int player,int cpu)
        {
            if (player - cpu == 0)
            {
                return "Duce";
            }
            else if (player - cpu == -1 || player - cpu == 2)
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }
    }
}
