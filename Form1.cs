namespace ATMK_BANK
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

        private void button2_Click(object sender, EventArgs e)
        {

            choose choosemethod = new choose();
            choosemethod.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            cardpincode noncustomer = new cardpincode();
            noncustomer.Show();
            this.Hide();
        }
    }
}
