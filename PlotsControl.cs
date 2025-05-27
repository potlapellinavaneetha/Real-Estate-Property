using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class PlotsControl : UserControl
    {
        public PlotsControl()
        {
            InitializeComponent();
            LoadPlots();
        }
        private void LoadPlots()
        {
            Flow_layout_panel.Controls.Clear();

            // Example data
            var plots = new List<(string Name, string Status, string Project, string Phase, string Size, string Facing)>
            {
                ("Plot 101", "Available", "Green Acres", "Phase 1", "1200 sqft", "East"),
                ("Plot 102", "Reserved", "Green Acres", "Phase 1", "1500 sqft", "North"),
                ("Plot 103", "Sold", "Blue Hills", "Phase 2", "1000 sqft", "West"),
                 ("Plot 101", "Available", "Green Acres", "Phase 1", "1200 sqft", "East"),
                ("Plot 102", "Reserved", "Green Acres", "Phase 1", "1500 sqft", "North"),
                ("Plot 103", "Sold", "Blue Hills", "Phase 2", "1000 sqft", "West"),
            };

            foreach (var plot in plots)
            {
                if (MatchesFilters(plot))
                {
                    Flow_layout_panel.Controls.Add(CreatePlotCard(plot));
                }
            }
        }

        private bool MatchesFilters((string Name, string Status, string Project, string Phase, string Size, string Facing) plot)
        {
            // Add logic to match based on dropdowns/textboxes if needed
            return true;
        }

        private Panel CreatePlotCard((string Name, string Status, string Project, string Phase, string Size, string Facing) plot)
        {
            Color bgColor;

            switch (plot.Status)
            {
                case "Available":
                    bgColor = Color.LightGreen;
                    break;
                case "Reserved":
                    bgColor = Color.Khaki;
                    break;
                case "Sold":
                    bgColor = Color.IndianRed;
                    break;
                default:
                    bgColor = Color.LightGray;
                    break;
            }

            Panel card = new Panel
            {
                Width = 200,
                Height = 100,
                BackColor = bgColor,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };


            Label lbl = new Label
            {
                Text = $"{plot.Name}\n{plot.Project} - {plot.Phase}\n{plot.Size} - {plot.Facing}\nStatus: {plot.Status}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            card.Controls.Add(lbl);
            return card;
        }
    
        private void PlotsControl_Load(object sender, EventArgs e)
        {

        }

        private void Flow_layout_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
