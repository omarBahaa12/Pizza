using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class FrmTimer1 : Form
    {
        int Counter = 0;
        public FrmTimer1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Finished";
            notifyIcon1.BalloonTipText = "The Order Finished";
            notifyIcon1.ShowBalloonTip(100000);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Counter++;
            TimeSpan time = new TimeSpan(0, 0, 0,Counter);
            Lab_Timer.Text = time.ToString();
        }

        private void Btn_OrderFinished_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled= false;
            Lab_Timer.BackColor = Color.Blue;
            Btn_OrderFinished.BackColor = Color.Blue;
            
        }

    }
}
