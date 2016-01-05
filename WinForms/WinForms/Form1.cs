using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chooseBox1.SelectedIndex = 0;
            chooseBox2.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void summBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double _amount;
            double _discount = 0;

            if (summBox1.Text == String.Empty) { _amount = 0; }
            else { _amount = Convert.ToDouble(summBox1.Text); } 

           switch (Convert.ToInt32(chooseBox1.SelectedIndex))
            {
                case 0:
                    _discount = 0.05;
                    break;
                case 1:
                    _discount = 0.2;
                    break;
                case 2:
                    _discount = 0.5;
                    break;
            }

            IDiscounts Percent = new PercentDiscounts(_amount, _discount);

            Result.Text = Percent.Discount().ToString() + " д.е.";


        }

        private void summBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double _amount;
            double _discount = 0;

            if (summBox2.Text == String.Empty) { _amount = 0; }
            else { _amount = Convert.ToDouble(summBox2.Text); }

            switch (Convert.ToInt32(chooseBox2.SelectedIndex))
            {
                case 0:
                    _discount = 1000;
                    break;
                case 1:
                    _discount = 2000;
                    break;
                case 2:
                    _discount = 5000;
                    break;
            }

            IDiscounts Certificate = new CertificateDiscounts(_amount, _discount);

            Result2.Text = Certificate.Discount().ToString() + " д.е.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<IDiscounts> wayEarning = new List<IDiscounts>();
            double _amount;
            double _discount = 0;

            if (summBox1.Text == String.Empty) { _amount = 0; }
            else { _amount = Convert.ToInt32(summBox1.Text); }

            switch (Convert.ToInt32(chooseBox1.SelectedIndex))
            {
                case 0:
                    _discount = 0.05;
                    break;
                case 1:
                    _discount = 0.2;
                    break;
                case 2:
                    _discount = 0.5;
                    break;
            }

            wayEarning.Add(new PercentDiscounts(_amount, _discount));

            int _amounts;
            int _discounts = 0;

            if (summBox2.Text == String.Empty) { _amounts = 0; }
            else { _amounts = Convert.ToInt32(summBox2.Text); }

            switch (Convert.ToInt32(chooseBox2.SelectedIndex))
            {
                case 0:
                    _discounts = 1000;
                    break;
                case 1:
                    _discounts = 2000;
                    break;
                case 2:
                    _discounts = 5000;
                    break;
            }

            wayEarning.Add(new CertificateDiscounts(_amounts, _discounts));

            list2.Text = "  ";
            foreach (var item in wayEarning)
            {
                list2.Text += item.Discount().ToString() + "  ";
            }
        }
    }
}
