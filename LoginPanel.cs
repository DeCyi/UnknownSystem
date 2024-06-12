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
    public partial class LoginPanel : UserControl
    {
        public event EventHandler LoginSuccessful;
        public LoginPanel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=PANZERKAMPFWAGE\SQLEXPRESS;Initial Catalog=ALibrarySystem;Integrated Security=True");
        private void loginClick(object sender, EventArgs e)
        {
            String username = usernameField.Text;
            String password = passwordField.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Account WHERE Username = '{username}' AND Password = '{password}'", con);
                cmd.ExecuteNonQuery();

                //MessageBox.Show($"Item added  Successfully! Author: {author}, Book Title: {title}, Year: {year}, Genre: {genre}");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Tama ba gago");
                    Register register = new Register();
                    register.Show();
                    this.Hide();
                    Form LibrarySystem = this.FindForm();
                    if (LibrarySystem != null)
                    {
                        LibrarySystem.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Bro ano na");
                    
                }


            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                usernameField.Text = "";
                passwordField.Text = "";
            }
        }
    }
}
