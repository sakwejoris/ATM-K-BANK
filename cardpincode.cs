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
    public partial class cardpincode : Form
    {
        private int attempts = 0;
        private const int max = 3;
        private const string pass = "2468";

        public cardpincode()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int pin = Convert.ToInt32(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("please input fields");
            }
            else
            {
                string pass = textBox2.Text;
                string enteredPassword = textBox2.Text;
                while (attempts < max)
                {
                    if (pass == "2341")
                    {
                        MessageBox.Show("access granted");
                        withdrawalform withdraw = new withdrawalform();
                        withdraw.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("incorrect password");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
