using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Main_Form
{
    public partial class MainDashBoard : Form
    {
        

        public MainDashBoard()
        {
            InitializeComponent();

        }
        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }


        private void Flow_panel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void LoadControl(UserControl control)
        {
            Mid_panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Mid_panel.Controls.Add(control);
        }

        private void LoadDashboard()
        {
            Mid_panel.Controls.Clear(); // Clear existing content if needed

            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;

            Mid_panel.Controls.Add(dashboard);
        }
        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
           
            LoadDashboard();
        }


        private void Btn_projects_Click(object sender, EventArgs e)
        {
            LoadControl(new ProjectsControl());
        }

        private void Btn_plots_Click(object sender, EventArgs e)
        {
            LoadControl(new PlotsControl());
        }

        private void Btn_customers_Click(object sender, EventArgs e)
        {
            LoadControl(new CustomerControl());
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void Btn_bookings_Click(object sender, EventArgs e)
        {
            LoadControl(new BookingsControl());
        }

        private void Btn_payments_Click(object sender, EventArgs e)
        {
            LoadControl(new PaymentsControl());
        }

        private void Btn_reports_Click(object sender, EventArgs e)
        {

        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {

        }
          
        private void Mid_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Top_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

