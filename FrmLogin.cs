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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == Txt_UserName.Tag.ToString() && Txt_Password.Text == Txt_Password.Tag.ToString())
            {
                Form frm = new FrmPizzaOrder();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Wrong User Name/Password!?","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
