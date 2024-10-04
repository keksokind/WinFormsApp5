namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int numa = int.Parse(numInp.Text);
            int factorial = 1;
            for (int i = 1; i <= numa; i++)
            {
                factorial *= i;
            }
            lblOut.Text = factorial.ToString();
        }

        private void numInp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
