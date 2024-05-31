namespace UnknownSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterClick(object sender, EventArgs e)
        {
            Welcome welc = new Welcome();
            welc.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
