using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnknownSystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void registerClick(object sender, EventArgs e)
        {
            Register welc = new Register();
            welc.Show();
            this.Hide();
        }

        private void databaseClick(object sender, EventArgs e)
        {
            Database welc = new Database();
            welc.Show();
            this.Hide();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
