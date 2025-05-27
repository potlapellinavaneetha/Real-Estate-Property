using System.Drawing;
using System.Windows.Forms;

namespace Main_Form
{
    partial class MainDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_dashboard = new System.Windows.Forms.Button();
            this.Btn_projects = new System.Windows.Forms.Button();
            this.Btn_plots = new System.Windows.Forms.Button();
            this.Btn_customers = new System.Windows.Forms.Button();
            this.Btn_bookings = new System.Windows.Forms.Button();
            this.Btn_settings = new System.Windows.Forms.Button();
            this.Btn_payments = new System.Windows.Forms.Button();
            this.Btn_reports = new System.Windows.Forms.Button();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mid_panel = new System.Windows.Forms.Panel();
            this.Flow_panel.SuspendLayout();
            this.Top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flow_panel
            // 
            this.Flow_panel.Controls.Add(this.Btn_dashboard);
            this.Flow_panel.Controls.Add(this.Btn_projects);
            this.Flow_panel.Controls.Add(this.Btn_plots);
            this.Flow_panel.Controls.Add(this.Btn_customers);
            this.Flow_panel.Controls.Add(this.Btn_bookings);
            this.Flow_panel.Controls.Add(this.Btn_payments);
            this.Flow_panel.Controls.Add(this.Btn_reports);
            this.Flow_panel.Controls.Add(this.Btn_settings);
            this.Flow_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Flow_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flow_panel.ForeColor = System.Drawing.Color.Black;
            this.Flow_panel.Location = new System.Drawing.Point(0, 0);
            this.Flow_panel.Name = "Flow_panel";
            this.Flow_panel.Size = new System.Drawing.Size(134, 807);
            this.Flow_panel.TabIndex = 0;
            this.Flow_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Flow_panel_Paint);
            // 
            // Btn_dashboard
            // 
            this.Btn_dashboard.BackColor = System.Drawing.Color.Teal;
            this.Btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.Btn_dashboard.Location = new System.Drawing.Point(3, 3);
            this.Btn_dashboard.Name = "Btn_dashboard";
            this.Btn_dashboard.Size = new System.Drawing.Size(131, 73);
            this.Btn_dashboard.TabIndex = 9;
            this.Btn_dashboard.Text = "Dash Board";
            this.Btn_dashboard.UseVisualStyleBackColor = true;
            this.Btn_dashboard.Click += new System.EventHandler(this.Btn_dashboard_Click);
            // 
            // Btn_projects
            // 
            this.Btn_projects.BackColor = System.Drawing.Color.Teal;
            this.Btn_projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_projects.ForeColor = System.Drawing.Color.White;
            this.Btn_projects.Location = new System.Drawing.Point(3, 82);
            this.Btn_projects.Name = "Btn_projects";
            this.Btn_projects.Size = new System.Drawing.Size(131, 82);
            this.Btn_projects.TabIndex = 5;
            this.Btn_projects.Text = "Projects";
            this.Btn_projects.UseVisualStyleBackColor = true;
            this.Btn_projects.Click += new System.EventHandler(this.Btn_projects_Click);
            // 
            // Btn_plots
            // 
            this.Btn_plots.BackColor = System.Drawing.Color.Teal;
            this.Btn_plots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_plots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_plots.ForeColor = System.Drawing.Color.White;
            this.Btn_plots.Location = new System.Drawing.Point(3, 170);
            this.Btn_plots.Name = "Btn_plots";
            this.Btn_plots.Size = new System.Drawing.Size(131, 70);
            this.Btn_plots.TabIndex = 5;
            this.Btn_plots.Text = "Plots";
            this.Btn_plots.UseVisualStyleBackColor = true;
            this.Btn_plots.Click += new System.EventHandler(this.Btn_plots_Click);
            // 
            // Btn_customers
            // 
            this.Btn_customers.BackColor = System.Drawing.Color.Teal;
            this.Btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_customers.ForeColor = System.Drawing.Color.White;
            this.Btn_customers.Location = new System.Drawing.Point(3, 246);
            this.Btn_customers.Name = "Btn_customers";
            this.Btn_customers.Size = new System.Drawing.Size(131, 83);
            this.Btn_customers.TabIndex = 5;
            this.Btn_customers.Text = "Customers";
            this.Btn_customers.UseVisualStyleBackColor = true;
            this.Btn_customers.Click += new System.EventHandler(this.Btn_customers_Click);
            // 
            // Btn_bookings
            // 
            this.Btn_bookings.BackColor = System.Drawing.Color.Teal;
            this.Btn_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_bookings.ForeColor = System.Drawing.Color.White;
            this.Btn_bookings.Location = new System.Drawing.Point(3, 335);
            this.Btn_bookings.Name = "Btn_bookings";
            this.Btn_bookings.Size = new System.Drawing.Size(131, 77);
            this.Btn_bookings.TabIndex = 5;
            this.Btn_bookings.Text = "Bookings";
            this.Btn_bookings.UseVisualStyleBackColor = true;
            this.Btn_bookings.Click += new System.EventHandler(this.Btn_bookings_Click);
            // 
            // Btn_settings
            // 
            this.Btn_settings.BackColor = System.Drawing.Color.Teal;
            this.Btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_settings.ForeColor = System.Drawing.Color.White;
            this.Btn_settings.Location = new System.Drawing.Point(3, 589);
            this.Btn_settings.Name = "Btn_settings";
            this.Btn_settings.Size = new System.Drawing.Size(131, 80);
            this.Btn_settings.TabIndex = 5;
            this.Btn_settings.Text = "Settings";
            this.Btn_settings.UseVisualStyleBackColor = true;
            this.Btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // Btn_payments
            // 
            this.Btn_payments.BackColor = System.Drawing.Color.Teal;
            this.Btn_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_payments.ForeColor = System.Drawing.Color.White;
            this.Btn_payments.Location = new System.Drawing.Point(3, 418);
            this.Btn_payments.Name = "Btn_payments";
            this.Btn_payments.Size = new System.Drawing.Size(131, 80);
            this.Btn_payments.TabIndex = 6;
            this.Btn_payments.Text = "Payments";
            this.Btn_payments.UseVisualStyleBackColor = true;
            this.Btn_payments.Click += new System.EventHandler(this.Btn_payments_Click);
            // 
            // Btn_reports
            // 
            this.Btn_reports.BackColor = System.Drawing.Color.Teal;
            this.Btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reports.ForeColor = System.Drawing.Color.White;
            this.Btn_reports.Location = new System.Drawing.Point(3, 504);
            this.Btn_reports.Name = "Btn_reports";
            this.Btn_reports.Size = new System.Drawing.Size(131, 79);
            this.Btn_reports.TabIndex = 7;
            this.Btn_reports.Text = "Reports";
            this.Btn_reports.UseVisualStyleBackColor = true;
            this.Btn_reports.Click += new System.EventHandler(this.Btn_reports_Click);
            // 
            // Top_panel
            // 
            this.Top_panel.Controls.Add(this.label3);
            this.Top_panel.Controls.Add(this.Btn_logout);
            this.Top_panel.Controls.Add(this.label2);
            this.Top_panel.Controls.Add(this.label1);
            this.Top_panel.Location = new System.Drawing.Point(140, 12);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1250, 88);
            this.Top_panel.TabIndex = 1;
            this.Top_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Top_panel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(112, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(740, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Real Estate Property Booking and Tracking System";
            // 
            // Btn_logout
            // 
            this.Btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_logout.ForeColor = System.Drawing.Color.Black;
            this.Btn_logout.Location = new System.Drawing.Point(1131, 25);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(105, 52);
            this.Btn_logout.TabIndex = 2;
            this.Btn_logout.Text = "Log-Out";
            this.Btn_logout.UseVisualStyleBackColor = false;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1017, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1004, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login-In-User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mid_panel
            // 
            this.Mid_panel.AutoScroll = true;
            this.Mid_panel.Location = new System.Drawing.Point(152, 125);
            this.Mid_panel.Name = "Mid_panel";
            this.Mid_panel.Size = new System.Drawing.Size(1211, 659);
            this.Mid_panel.TabIndex = 2;
            this.Mid_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mid_panel_Paint);
            // 
            // MainDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 807);
            this.Controls.Add(this.Mid_panel);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Flow_panel);
            this.Name = "MainDashBoard";
            this.Text = "MainDshBoard";
            this.Load += new System.EventHandler(this.MainDashboardForm_Load);
            this.Flow_panel.ResumeLayout(false);
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow_panel;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Mid_panel;
        private System.Windows.Forms.Button Btn_projects;
        private System.Windows.Forms.Button Btn_plots;
        private System.Windows.Forms.Button Btn_customers;
        private System.Windows.Forms.Button Btn_bookings;
        private System.Windows.Forms.Button Btn_settings;
        private System.Windows.Forms.Button Btn_payments;
        private System.Windows.Forms.Button Btn_reports;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_dashboard;
        private Label label3;
    }
}

