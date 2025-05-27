namespace Main_Form
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_dashboard = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_adminpwd = new System.Windows.Forms.TextBox();
            this.Txt_adminuser = new System.Windows.Forms.TextBox();
            this.Btn_adminlogin = new System.Windows.Forms.Button();
            this.Panel_dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_dashboard
            // 
            this.Panel_dashboard.Controls.Add(this.label2);
            this.Panel_dashboard.Controls.Add(this.label1);
            this.Panel_dashboard.Controls.Add(this.Txt_adminpwd);
            this.Panel_dashboard.Controls.Add(this.Txt_adminuser);
            this.Panel_dashboard.Controls.Add(this.Btn_adminlogin);
            this.Panel_dashboard.Location = new System.Drawing.Point(71, 52);
            this.Panel_dashboard.Name = "Panel_dashboard";
            this.Panel_dashboard.Size = new System.Drawing.Size(918, 280);
            this.Panel_dashboard.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // Txt_adminpwd
            // 
            this.Txt_adminpwd.Location = new System.Drawing.Point(184, 112);
            this.Txt_adminpwd.Name = "Txt_adminpwd";
            this.Txt_adminpwd.Size = new System.Drawing.Size(151, 22);
            this.Txt_adminpwd.TabIndex = 2;
            this.Txt_adminpwd.UseSystemPasswordChar = true;
            this.Txt_adminpwd.UseWaitCursor = true;
            this.Txt_adminpwd.TextChanged += new System.EventHandler(this.Txt_adminpwd_TextChanged);
            // 
            // Txt_adminuser
            // 
            this.Txt_adminuser.Location = new System.Drawing.Point(184, 68);
            this.Txt_adminuser.Name = "Txt_adminuser";
            this.Txt_adminuser.Size = new System.Drawing.Size(151, 22);
            this.Txt_adminuser.TabIndex = 1;
            this.Txt_adminuser.TextChanged += new System.EventHandler(this.Txt_adminuser_TextChanged);
            // 
            // Btn_adminlogin
            // 
            this.Btn_adminlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_adminlogin.Location = new System.Drawing.Point(203, 159);
            this.Btn_adminlogin.Name = "Btn_adminlogin";
            this.Btn_adminlogin.Size = new System.Drawing.Size(116, 53);
            this.Btn_adminlogin.TabIndex = 0;
            this.Btn_adminlogin.Text = "Login";
            this.Btn_adminlogin.UseVisualStyleBackColor = true;
            this.Btn_adminlogin.Click += new System.EventHandler(this.Btn_adminlogin_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_dashboard);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1427, 814);
            this.Panel_dashboard.ResumeLayout(false);
            this.Panel_dashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_adminpwd;
        private System.Windows.Forms.TextBox Txt_adminuser;
        private System.Windows.Forms.Button Btn_adminlogin;
    }
}
