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
    public partial class RegisterPanel : UserControl
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=PANZERKAMPFWAGE\SQLEXPRESS;Initial Catalog=ALibrarySystem;Integrated Security=True");
        private void registerClick(object sender, EventArgs e)
        {
            String username = usernameField.Text;
            String password = passwordField.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [dbo].[Account] ([Username],[Password]) VALUES('" + username + "', '" + password + "')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Registered!");

                //MessageBox.Show($"Item added  Successfully! Author: {author}, Book Title: {title}, Year: {year}, Genre: {genre}");
                /*SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);*/

            
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                usernameField.Text = "";
                passwordField.Text = "";
                con.Close();
            }
        }


    }
}
