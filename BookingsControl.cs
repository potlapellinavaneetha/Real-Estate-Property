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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main_Form
{
    public partial class BookingsControl : UserControl
    {

        public BookingsControl()
        {
            InitializeComponent();
            Dgv_listofbookings.DataBindingComplete += Dgv_listofbookings_DataBindingComplete;
            Cmbx_selectcustomer.Items.Add("Navaneetha");
            Cmbx_selectplot.Items.Add("\"Plot 101\", \"Available\", \"Green Acres\", \"Phase 1\", \"1200 sqft\", \"East\"");

        }

        private void LoadAvailablePlots()
        {
            string connectionString = "Data Source=PROBYTE\\SQLEXPRESS;Initial Catalog=RealEstateDB;Integrated Security=True;";
            // Replace this with your actual connection string
            string query = "SELECT PlotID, Location, Size, Price, Status FROM PlotsInformation WHERE Status = 'Available'";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dgv_listofbookings.DataSource = dt;

                // Format Status colors
            }
        }

        private void Dgv_listofbookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }






        private void Btn_book_Click(object sender, EventArgs e)
        {
            LoadAvailablePlots();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_listofbookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmbx_selectcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmbx_selectplot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_amount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BookingsControl_Load(object sender, EventArgs e)
        {

        }
    }

}


