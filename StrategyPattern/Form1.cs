using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        double totalMoney = 0.0d;

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                CashContext cashContext = new CashContext(comboBox1.SelectedItem.ToString());
                double totalPrice = 0.0d;
                totalPrice = cashContext.GetResult(Convert.ToDouble(textPrice.Text) * Convert.ToDouble(textAmo.Text));
                totalMoney += totalPrice;
                listBox1.Items.Add("单价：" + textPrice.Text + " 数量：" + textAmo.Text + " 合计：" + totalPrice);
                total.Text = totalMoney.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
