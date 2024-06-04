using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMK_BANK
{
    public partial class withdrawalform : Form
    {
        public withdrawalform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double withdraw = Convert.ToDouble(textBox1.Text);
            if (withdraw > 10000)
            {
                MessageBox.Show("insufficient funds");
            }
            else if (withdraw < 0)
            {
                MessageBox.Show("invalid amount");

            }
            else
            {
                MessageBox.Show("withdrawal successfull");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
