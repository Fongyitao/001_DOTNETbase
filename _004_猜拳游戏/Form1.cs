using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_猜拳游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //为了提高代码利用率,将三个按钮的单击事件都注册到了同一个按钮下
        private void btnStone_Click(object sender, EventArgs e)
        {
            // 把sender显示转换成Button类型
            Button btn = (Button)sender;
            if (btn != null)
            {
                Player p = new Player();
                int playerFist = p.ShowFist(btn.Text);
                lblPlayer.Text = btn.Text;

                Cpu c = new Cpu();
                int cpuFist = c.ShowFist();
                lblCpu.Text = c.FistName;

                Judge j1 = new Judge();
                lblResult.Text = j1.IsWin(playerFist, cpuFist);
            }
            
        }

        //点击剪刀
        //private void btnScissor_Click(object sender, EventArgs e)
        //{
        //    Player p = new Player();
        //    int playerFist = p.ShowFist(btnScissor.Text);
        //    lblPlayer.Text = btnScissor.Text;

        //    Cpu c = new Cpu();
        //    int cpuFist = c.ShowFist();
        //    lblCpu.Text = c.FistName;

        //    Judge j1 = new Judge();
        //    lblResult.Text = j1.IsWin(playerFist, cpuFist);
        //}

    }
}
