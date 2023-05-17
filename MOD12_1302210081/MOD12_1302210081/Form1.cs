namespace MOD12_1302210081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            string output = CariTandaBilangan(input);
            label1.Text = output;
        }

        private string CariTandaBilangan(int a)
        {
            if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else
            {
                return "Nol";
            }
        }
    }
}
