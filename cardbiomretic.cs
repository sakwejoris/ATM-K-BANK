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
    public partial class cardbiomretic : Form
    {
        public cardbiomretic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox2 == null)
            {
                MessageBox.Show("please enter fields");

            }
            else
            {
                int cardno = Convert.ToInt32(textBox1.Text);
                int bio = Convert.ToInt32(textBox2.Text);
                if (cardno == 12345 && bio == 1001)
                {
                    withdrawalform amt = new withdrawalform();
                    amt.Show();
                    this.Hide();
                }
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
