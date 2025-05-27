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

    public partial class CustomerControl : UserControl
    {
       
        string photoPath = "";
        string idProofPath = "";
        string addressProofPath = "";
       
       
        public CustomerControl()
        {
            InitializeComponent();
            Cmb_gender.Items.Add("Male");
            Cmb_gender.Items.Add("Female");
            Cmb_gender.Items.Add("Other");
            LoadCustomerData();
           
        }
        private void LoadCustomerData()
        {
            string connectionString = "Data Source=PROBYTE\\SQLEXPRESS;Initial Catalog=RealEstateDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT  Name, Contact, EmailAddress, AdharOrPan, Gender, DateOfBirth, Notes FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                   Datagv_list.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
                
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_emailaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_adharorpan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rtxt_notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Date_dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Datagv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Btn_addd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=PROBYTE\\SQLEXPRESS;Initial Catalog=RealEstateDB;Integrated Security=True"))
                {
                    string query = @"INSERT INTO Customers 
                         (Name, Contact, EmailAddress, AdharOrPan, Gender, DateOfBirth, Notes, PhotoPath, IDProofPath, AddressProofPath, IsKYCVerified)
                         VALUES (@Name, @Contact, @EmailAddress, @AdharOrPan, @Gender, @DateOfBirth, @Notes, @PhotoPath, @IDProofPath, @AddressProofPath, @IsKYCVerified)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Txt_name.Text);
                        cmd.Parameters.AddWithValue("@Contact", Txt_contact.Text);
                        cmd.Parameters.AddWithValue("@EmailAddress", Txt_emailaddress.Text);
                        cmd.Parameters.AddWithValue("@AdharOrPan", Txt_adharorpan.Text);
                        cmd.Parameters.AddWithValue("@Gender", Cmb_gender.SelectedItem?.ToString() ?? "Unknown");
                        cmd.Parameters.AddWithValue("@DateOfBirth", Date_dob.Value);
                        cmd.Parameters.AddWithValue("@Notes", Rtxt_notes.Text);
                        cmd.Parameters.AddWithValue("@PhotoPath", photoPath);
                        cmd.Parameters.AddWithValue("@IDProofPath", idProofPath);
                        cmd.Parameters.AddWithValue("@AddressProofPath", addressProofPath);
                        cmd.Parameters.AddWithValue("@IsKYCVerified", Chk_kyc.Checked);


                        conn.Open();
                        cmd.ExecuteNonQuery();  // << line causing error
                        conn.Close();

                        MessageBox.Show("Customer added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            this.LoadCustomerData();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customers details successfully saved");

        }


        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Kyc_Click(object sender, EventArgs e)
        {
           
            
        }


        private void His_tab_Click(object sender, EventArgs e)
        {

        }

        private void Interest_tab_Click(object sender, EventArgs e)
        {

        }

       

        
        private void Btn_uploadphoto_click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Photo";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                photoPath = open.FileName;
                Pictureboxphoto.Image = Image.FromFile(photoPath);
            }
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {

        }

        private void Brn_uploadphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Photo";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                photoPath = open.FileName;
                Pictureboxphoto.Image = Image.FromFile(photoPath);
            }
        }

        private void Btn_idproof_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select ID Proof";
            open.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                idProofPath = open.FileName;
                Idproof.Text = idProofPath;
            }
        }

        private void Btn_addressproof_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Address Proof";
            open.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                addressProofPath = open.FileName;
                Addressproof.Text = addressProofPath;
            }
        }

        private void TxtIdproof_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtaddressproof_TextChanged(object sender, EventArgs e)
        {

        }

        private void Picturebox_photo_Click(object sender, EventArgs e)
        {

        }
    }
}
