using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Pizza_Order
{
    struct stPizzaInfo
    {
        public string Size;
        public string CrustType;
        public string Toppings;
        public string WhereEat;
        public double SizePrice;
        public double CrustPrice;
        public double ToppingsPrice;
        public double TotalPrice;
    }

    public partial class FrmPizzaOrder : Form
    {
        stPizzaInfo Pizza1;

        public FrmPizzaOrder()
        {
            InitializeComponent();
            Pizza1.ToppingsPrice = 0;
            Comb_Size.SelectedIndex = 1;
            Rdb_EatIn.Checked = true;
            Rdb_Thin.Checked = true;

        }

        private void Rdb_Thin_CheckedChanged(object sender, EventArgs e)
        {
            Pizza1.CrustType = "Thin";
            Pizza1.CrustPrice = 0;
            Pizza1.CrustPrice = 10;
            Lab_WhichCrust_TextChanged(this, new EventArgs());
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Rdb_Think_CheckedChanged(object sender, EventArgs e)
        {
            Pizza1.CrustType = "Think";
            Pizza1.CrustPrice = 0;
            Pizza1.CrustPrice = 20;
            Lab_WhichCrust_TextChanged(this, new EventArgs());
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Rdb_TakeAway_CheckedChanged(object sender, EventArgs e)
        {
            Pizza1.WhereEat = "Take Away";
            Lab_WhichEat_TextChanged(this, new EventArgs());
        }

        private void Rdb_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            Pizza1.WhereEat = "Eat In";
            Lab_WhichEat_TextChanged(this, new EventArgs());

        }

        private void Ckb_Olives_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_Olives.Checked)
            {

                Pizza1.ToppingsPrice += 5;
                Pizza1.Toppings += "Olives,";
            }
            else
            {
                Pizza1.ToppingsPrice -= 5;
                string[] arrstr = Pizza1.Toppings.Split(',');
                Pizza1.Toppings = "";
                for (int i = 0; i < arrstr.Length - 1; i++)
                {
                    if (arrstr[i] == "Olives")
                        continue;
                    Pizza1.Toppings += arrstr[i] + ",";
                }
            }
            Lab_WhichToppings_TextChanged(sender, e);
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Ckb_Tematoes_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_Tematoes.Checked)
            {

                Pizza1.ToppingsPrice += 5;
                Pizza1.Toppings += "Tematoes,";
            }
            else
            {
                Pizza1.ToppingsPrice -= 5;
                string[] arrstr = Pizza1.Toppings.Split(',');
                Pizza1.Toppings = "";
                for (int i = 0; i < arrstr.Length - 1; i++)
                {
                    if (arrstr[i] == "Tematoes")
                        continue;
                    Pizza1.Toppings += arrstr[i] + ",";
                }
            }
            Lab_WhichToppings_TextChanged(sender, e);
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Ckb_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_Mushrooms.Checked)
            {

                Pizza1.ToppingsPrice += 5;
                Pizza1.Toppings += "Mushrooms,";
            }
            else
            {
                Pizza1.ToppingsPrice -= 5;
                string[] arrstr = Pizza1.Toppings.Split(',');
                Pizza1.Toppings = "";
                for (int i = 0; i < arrstr.Length - 1; i++)
                {
                    if (arrstr[i] == "Mushrooms")
                        continue;
                    Pizza1.Toppings += arrstr[i] + ",";
                }
            }
            Lab_WhichToppings_TextChanged(sender, e);
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Ckb_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_Green.Checked)
            {

                Pizza1.ToppingsPrice += 5;
                Pizza1.Toppings += "Green Peppers,";
            }
            else
            {
                Pizza1.ToppingsPrice -= 5;
                string[] arrstr = Pizza1.Toppings.Split(',');
                Pizza1.Toppings = "";
                for (int i = 0; i < arrstr.Length - 1; i++)
                {
                    if (arrstr[i] == "Green Peppers")
                        continue;
                    Pizza1.Toppings += arrstr[i] + ",";
                }
            }
            Lab_WhichToppings_TextChanged(sender, e);
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Ckb_Onion_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_Onion.Checked)
            {

                Pizza1.ToppingsPrice += 5;
                Pizza1.Toppings += "Onion,";
            }
            else
            {
                Pizza1.ToppingsPrice -= 5;
                string[] arrstr = Pizza1.Toppings.Split(',');
                Pizza1.Toppings = "";
                for (int i = 0; i < arrstr.Length - 1; i++)
                {
                    if (arrstr[i] == "Onion")
                        continue;
                    Pizza1.Toppings += arrstr[i] + ",";
                }
            }
            Lab_WhichToppings_TextChanged(sender, e);
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Ckb_ExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_ExtraCheese.Checked)
            {

                Pizza1.ToppingsPrice += 5;
                Pizza1.Toppings += "Extra Cheese,";
            }
            else
            {
                Pizza1.ToppingsPrice -= 5;
                string[] arrstr = Pizza1.Toppings.Split(',');
                Pizza1.Toppings = "";
                for (int i = 0; i < arrstr.Length - 1; i++)
                {
                    if (arrstr[i] == "Extra Cheese")
                        continue;
                    Pizza1.Toppings += arrstr[i] + ",";
                }
            }
            Lab_WhichToppings_TextChanged(sender, e);
            Lab_WhichPrice_TextChanged(sender, e);
        }

        private void Lab_WhichPrice_TextChanged(object sender, EventArgs e)
        {
            Pizza1.TotalPrice = Pizza1.CrustPrice + Pizza1.SizePrice + Pizza1.ToppingsPrice;
            Lab_WhichPrice.Text = Pizza1.TotalPrice.ToString();
        }

        private void Btn_OrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pan_Main.Enabled = false;
                Btn_OrderPizza.Enabled = false;
                Form frm = new FrmTimer1();
                frm.ShowDialog();
            }

        }

        private void Btn_ResetForm_Click(object sender, EventArgs e)
        {
            Pan_Main.Enabled = true;
            Btn_OrderPizza.Enabled = true;
            Ckb_ExtraCheese.Checked = false;
            Ckb_Green.Checked = false;
            Ckb_Mushrooms.Checked = false;
            Ckb_Olives.Checked = false;
            Ckb_Onion.Checked = false;
            Ckb_Tematoes.Checked = false;
            Rdb_EatIn.Checked = true;
            Rdb_Thin.Checked = true;
        }

        private void Lab_WhichSize_TextChanged(object sender, EventArgs e)
        {
            Lab_WhichSize.Text = Pizza1.Size;
        }

        private void Lab_WhichToppings_TextChanged(object sender, EventArgs e)
        {

            Lab_WhichToppings.Text = Pizza1.Toppings;
        }

        private void Lab_WhichCrust_TextChanged(object sender, EventArgs e)
        {
            Lab_WhichCrust.Text = Pizza1.CrustType;
        }

        private void Lab_WhichEat_TextChanged(object sender, EventArgs e)
        {
            Lab_WhichEat.Text = Pizza1.WhereEat;

        }

        private void Comb_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comb_Size.SelectedIndex == 0)
            {
                Pizza1.Size = "Small";
                Pizza1.SizePrice = 0;
                Pizza1.SizePrice = 10;
                Lab_WhichSize_TextChanged(this, new EventArgs());
                Lab_WhichPrice_TextChanged(sender, e);
            }
            else if (Comb_Size.SelectedIndex == 1)
            {
                Pizza1.Size = "Medium";
                Pizza1.SizePrice = 0;
                Pizza1.SizePrice = 20;
                Lab_WhichSize_TextChanged(this, new EventArgs());
                Lab_WhichPrice_TextChanged(sender, e);

            }
            else
            {
                Pizza1.Size = "Large";
                Pizza1.SizePrice = 0;
                Pizza1.SizePrice = 30;
                Lab_WhichSize_TextChanged(this, new EventArgs());
                Lab_WhichPrice_TextChanged(sender, e);
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor=Color.Black;
            Pan_Main.BackColor = Color.OrangeRed;
            Pan_Summary.BackColor = Color.OrangeRed;
            Pan_Summary.ForeColor = Color.White;
            Btn_OrderPizza.BackColor= Color.OrangeRed;
            Btn_OrderPizza.ForeColor= Color.White;
            Btn_ResetForm.BackColor= Color.White;
            Btn_ResetForm.BackColor= Color.OrangeRed;
            Btn_OrderPizza.ForeColor = Color.Crimson;
            Btn_ResetForm.ForeColor = Color.Crimson;
            Pan_Size.ForeColor = Color.White;
            
        }

        private void whiteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Crimson;
            pictureBox3.BackColor = Color.Orange;
            pictureBox4.BackColor = Color.Orange;

           
        }


    }
 
}
