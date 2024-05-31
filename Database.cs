using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnknownSystem
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PANZERKAMPFWAGE\SQLEXPRESS;Initial Catalog=ALibrarySystem;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BookLists", conn);

            DataSet ds = new DataSet();

            Console.WriteLine("Testing");
            da.Fill(ds, "BookLists");
            dataGridView1.DataSource = ds.Tables["BookLists"].DefaultView;

            conn.Close();
        }

        private void backClickB(object sender, EventArgs e)
        {
            Welcome welc = new Welcome();
            welc.Show();
            this.Hide();
        }
    }
}
