using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Intrinsics.Arm;

namespace UnknownSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=PANZERKAMPFWAGE\SQLEXPRESS;Initial Catalog=ALibrarySystem;Integrated Security=True");

        private void regClick(object sender, EventArgs e)
        {
            String author = authorField.Text;
            String title = titleField.Text;
            String genre = Genre.Text;
            int year = Convert.ToInt32(yearField.Text);

            //MessageBox.Show(author + title + genre + year);
            //MessageBox.Show($"You ahve put:" + author + " " + title + " " + year + " ");
                try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[BookLists]
                    ([BookTitle]
                    ,[BookAuthor],[BookGenre],[BookYear])
                    VALUES
                    ('" + title + "', '" + author + "', '" + genre + "', '" + year + "')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Item added  Successfully! Author: {author}, Book Title: {title}, Year: {year}, ");


            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            } 


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
