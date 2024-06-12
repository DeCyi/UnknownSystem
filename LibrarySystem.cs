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
    public partial class LibrarySystem : Form
    {
        private int click;
        public LibrarySystem()
        {
            InitializeComponent();
            
        }

        private void loginbuttonClick(object sender, EventArgs e)
        {


            switch (click)
            {
                case 0:
                    loginPanel1.Visible = true;
                    click = 1;
                    break;
                case 1:
                    loginPanel1.Visible = false;
                    click = 0;
                    break;
            }
        }

        private void registerbuttonClick(object sender, EventArgs e)
        {
            switch (click)
            {
                case 0:
                    registerPanel1.Visible = true;
                    click = 1;
                    break;
                case 1:
                    registerPanel1.Visible = false;
                    click = 0;
                    break;
            }
        }

    }
}

