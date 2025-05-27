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

namespace Main_Form
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Btn_adminlogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=PROBYTE\\SQLEXPRESS;Initial Catalog=RealEstateDB;Integrated Security=True"))
                {
                    string query = @"Select INTO AdminDetails (username,Password )
                     
                         VALUES (@username,@Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", Txt_adminuser.Text);
                        cmd.Parameters.AddWithValue("@Password", Txt_adminpwd.Text);
                        

                        conn.Open();
                        cmd.ExecuteNonQuery();  // << line causing error
                        conn.Close();

                        MessageBox.Show(" successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Txt_adminuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_adminpwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
