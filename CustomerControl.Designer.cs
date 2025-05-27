namespace Main_Form
{
    partial class CustomerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Txt_contact = new System.Windows.Forms.TextBox();
            this.Txt_emailaddress = new System.Windows.Forms.TextBox();
            this.Txt_adharorpan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Rtxt_notes = new System.Windows.Forms.RichTextBox();
            this.Btn_addd = new System.Windows.Forms.Button();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Date_dob = new System.Windows.Forms.DateTimePicker();
            this.Pictureboxphoto = new System.Windows.Forms.Label();
            this.Idproof = new System.Windows.Forms.Label();
            this.Addressproof = new System.Windows.Forms.Label();
            this.Chk_kyc = new System.Windows.Forms.CheckBox();
            this.Brn_uploadphoto = new System.Windows.Forms.Button();
            this.Btn_idproof = new System.Windows.Forms.Button();
            this.Btn_addressproof = new System.Windows.Forms.Button();
            this.Txtaddressproof = new System.Windows.Forms.TextBox();
            this.TxtIdproof = new System.Windows.Forms.TextBox();
            this.Interest_tab = new System.Windows.Forms.TabPage();
            this.His_tab = new System.Windows.Forms.TabPage();
            this.Kyc = new System.Windows.Forms.TabPage();
            this.History = new System.Windows.Forms.TabControl();
            this.Datagv_list = new System.Windows.Forms.DataGridView();
            this.Picturebox_photo = new System.Windows.Forms.PictureBox();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = " Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aadhar/PAN";
            // 
            // Cmb_gender
            // 
            this.Cmb_gender.FormattingEnabled = true;
            this.Cmb_gender.Location = new System.Drawing.Point(173, 203);
            this.Cmb_gender.Name = "Cmb_gender";
            this.Cmb_gender.Size = new System.Drawing.Size(121, 24);
            this.Cmb_gender.TabIndex = 7;
            this.Cmb_gender.SelectedIndexChanged += new System.EventHandler(this.Cmb_gender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(173, 52);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(282, 22);
            this.Txt_name.TabIndex = 9;
            this.Txt_name.TextChanged += new System.EventHandler(this.Txt_name_TextChanged);
            // 
            // Txt_contact
            // 
            this.Txt_contact.Location = new System.Drawing.Point(173, 92);
            this.Txt_contact.Name = "Txt_contact";
            this.Txt_contact.Size = new System.Drawing.Size(282, 22);
            this.Txt_contact.TabIndex = 10;
            this.Txt_contact.TextChanged += new System.EventHandler(this.Txt_contact_TextChanged);
            // 
            // Txt_emailaddress
            // 
            this.Txt_emailaddress.Location = new System.Drawing.Point(173, 130);
            this.Txt_emailaddress.Name = "Txt_emailaddress";
            this.Txt_emailaddress.Size = new System.Drawing.Size(282, 22);
            this.Txt_emailaddress.TabIndex = 11;
            this.Txt_emailaddress.TextChanged += new System.EventHandler(this.Txt_emailaddress_TextChanged);
            // 
            // Txt_adharorpan
            // 
            this.Txt_adharorpan.Location = new System.Drawing.Point(173, 170);
            this.Txt_adharorpan.Name = "Txt_adharorpan";
            this.Txt_adharorpan.Size = new System.Drawing.Size(282, 22);
            this.Txt_adharorpan.TabIndex = 12;
            this.Txt_adharorpan.TextChanged += new System.EventHandler(this.Txt_adharorpan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Notes/Comments";
            // 
            // Rtxt_notes
            // 
            this.Rtxt_notes.Location = new System.Drawing.Point(173, 309);
            this.Rtxt_notes.Name = "Rtxt_notes";
            this.Rtxt_notes.Size = new System.Drawing.Size(282, 51);
            this.Rtxt_notes.TabIndex = 16;
            this.Rtxt_notes.Text = "";
            this.Rtxt_notes.TextChanged += new System.EventHandler(this.Rtxt_notes_TextChanged);
            // 
            // Btn_addd
            // 
            this.Btn_addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_addd.Location = new System.Drawing.Point(29, 613);
            this.Btn_addd.Name = "Btn_addd";
            this.Btn_addd.Size = new System.Drawing.Size(109, 55);
            this.Btn_addd.TabIndex = 17;
            this.Btn_addd.Text = "ADD";
            this.Btn_addd.UseVisualStyleBackColor = true;
            this.Btn_addd.Click += new System.EventHandler(this.Btn_addd_Click);
            // 
            // Btn_edit
            // 
            this.Btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_edit.Location = new System.Drawing.Point(173, 613);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(94, 55);
            this.Btn_edit.TabIndex = 18;
            this.Btn_edit.Text = "EDIT";
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.Location = new System.Drawing.Point(300, 613);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(97, 55);
            this.Btn_save.TabIndex = 19;
            this.Btn_save.Text = "SAVE";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.Location = new System.Drawing.Point(433, 613);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(112, 55);
            this.Btn_cancel.TabIndex = 20;
            this.Btn_cancel.Text = "CANCEL";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Date_dob
            // 
            this.Date_dob.Location = new System.Drawing.Point(173, 251);
            this.Date_dob.Name = "Date_dob";
            this.Date_dob.Size = new System.Drawing.Size(200, 22);
            this.Date_dob.TabIndex = 23;
            this.Date_dob.ValueChanged += new System.EventHandler(this.Date_dob_ValueChanged);
            // 
            // Pictureboxphoto
            // 
            this.Pictureboxphoto.AutoSize = true;
            this.Pictureboxphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pictureboxphoto.Location = new System.Drawing.Point(104, 392);
            this.Pictureboxphoto.Name = "Pictureboxphoto";
            this.Pictureboxphoto.Size = new System.Drawing.Size(47, 16);
            this.Pictureboxphoto.TabIndex = 24;
            this.Pictureboxphoto.Text = "Photo";
            // 
            // Idproof
            // 
            this.Idproof.AutoSize = true;
            this.Idproof.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idproof.Location = new System.Drawing.Point(95, 476);
            this.Idproof.Name = "Idproof";
            this.Idproof.Size = new System.Drawing.Size(58, 16);
            this.Idproof.TabIndex = 26;
            this.Idproof.Text = "IDproof";
            // 
            // Addressproof
            // 
            this.Addressproof.AutoSize = true;
            this.Addressproof.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addressproof.Location = new System.Drawing.Point(58, 532);
            this.Addressproof.Name = "Addressproof";
            this.Addressproof.Size = new System.Drawing.Size(106, 16);
            this.Addressproof.TabIndex = 28;
            this.Addressproof.Text = "Address Proof";
            // 
            // Chk_kyc
            // 
            this.Chk_kyc.AutoSize = true;
            this.Chk_kyc.Location = new System.Drawing.Point(173, 587);
            this.Chk_kyc.Name = "Chk_kyc";
            this.Chk_kyc.Size = new System.Drawing.Size(102, 20);
            this.Chk_kyc.TabIndex = 30;
            this.Chk_kyc.Text = "KYC verified";
            this.Chk_kyc.UseVisualStyleBackColor = true;
            // 
            // Brn_uploadphoto
            // 
            this.Brn_uploadphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brn_uploadphoto.Location = new System.Drawing.Point(173, 384);
            this.Brn_uploadphoto.Name = "Brn_uploadphoto";
            this.Brn_uploadphoto.Size = new System.Drawing.Size(116, 53);
            this.Brn_uploadphoto.TabIndex = 31;
            this.Brn_uploadphoto.Text = "Upload Photo";
            this.Brn_uploadphoto.UseVisualStyleBackColor = true;
            this.Brn_uploadphoto.Click += new System.EventHandler(this.Brn_uploadphoto_Click);
            // 
            // Btn_idproof
            // 
            this.Btn_idproof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_idproof.Location = new System.Drawing.Point(178, 454);
            this.Btn_idproof.Name = "Btn_idproof";
            this.Btn_idproof.Size = new System.Drawing.Size(116, 53);
            this.Btn_idproof.TabIndex = 32;
            this.Btn_idproof.Text = "ID Proof";
            this.Btn_idproof.UseVisualStyleBackColor = true;
            this.Btn_idproof.Click += new System.EventHandler(this.Btn_idproof_Click);
            // 
            // Btn_addressproof
            // 
            this.Btn_addressproof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_addressproof.Location = new System.Drawing.Point(178, 513);
            this.Btn_addressproof.Name = "Btn_addressproof";
            this.Btn_addressproof.Size = new System.Drawing.Size(116, 53);
            this.Btn_addressproof.TabIndex = 33;
            this.Btn_addressproof.Text = "Address Proof";
            this.Btn_addressproof.UseVisualStyleBackColor = true;
            this.Btn_addressproof.Click += new System.EventHandler(this.Btn_addressproof_Click);
            // 
            // Txtaddressproof
            // 
            this.Txtaddressproof.Location = new System.Drawing.Point(300, 519);
            this.Txtaddressproof.Name = "Txtaddressproof";
            this.Txtaddressproof.Size = new System.Drawing.Size(245, 22);
            this.Txtaddressproof.TabIndex = 29;
            this.Txtaddressproof.TextChanged += new System.EventHandler(this.Txtaddressproof_TextChanged);
            // 
            // TxtIdproof
            // 
            this.TxtIdproof.Location = new System.Drawing.Point(300, 470);
            this.TxtIdproof.Name = "TxtIdproof";
            this.TxtIdproof.Size = new System.Drawing.Size(245, 22);
            this.TxtIdproof.TabIndex = 27;
            this.TxtIdproof.TextChanged += new System.EventHandler(this.TxtIdproof_TextChanged);
            // 
            // Interest_tab
            // 
            this.Interest_tab.Location = new System.Drawing.Point(4, 27);
            this.Interest_tab.Name = "Interest_tab";
            this.Interest_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Interest_tab.Size = new System.Drawing.Size(538, 246);
            this.Interest_tab.TabIndex = 2;
            this.Interest_tab.Text = "Interest";
            this.Interest_tab.UseVisualStyleBackColor = true;
            this.Interest_tab.Click += new System.EventHandler(this.Interest_tab_Click);
            // 
            // His_tab
            // 
            this.His_tab.Location = new System.Drawing.Point(4, 27);
            this.His_tab.Name = "His_tab";
            this.His_tab.Padding = new System.Windows.Forms.Padding(3);
            this.His_tab.Size = new System.Drawing.Size(538, 246);
            this.His_tab.TabIndex = 1;
            this.His_tab.Text = "History";
            this.His_tab.UseVisualStyleBackColor = true;
            this.His_tab.Click += new System.EventHandler(this.His_tab_Click);
            // 
            // Kyc
            // 
            this.Kyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kyc.Location = new System.Drawing.Point(4, 27);
            this.Kyc.Name = "Kyc";
            this.Kyc.Padding = new System.Windows.Forms.Padding(3);
            this.Kyc.Size = new System.Drawing.Size(538, 246);
            this.Kyc.TabIndex = 0;
            this.Kyc.Text = "KYC";
            this.Kyc.UseVisualStyleBackColor = true;
            this.Kyc.Click += new System.EventHandler(this.Kyc_Click);
            // 
            // History
            // 
            this.History.Controls.Add(this.Kyc);
            this.History.Controls.Add(this.His_tab);
            this.History.Controls.Add(this.Interest_tab);
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(628, 454);
            this.History.Name = "History";
            this.History.SelectedIndex = 0;
            this.History.Size = new System.Drawing.Size(546, 277);
            this.History.TabIndex = 22;
            // 
            // Datagv_list
            // 
            this.Datagv_list.BackgroundColor = System.Drawing.Color.White;
            this.Datagv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagv_list.Location = new System.Drawing.Point(551, 34);
            this.Datagv_list.Name = "Datagv_list";
            this.Datagv_list.ReadOnly = true;
            this.Datagv_list.RowHeadersWidth = 51;
            this.Datagv_list.RowTemplate.Height = 24;
            this.Datagv_list.Size = new System.Drawing.Size(687, 403);
            this.Datagv_list.TabIndex = 21;
            this.Datagv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagv_list_CellContentClick);
            // 
            // Picturebox_photo
            // 
            this.Picturebox_photo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Picturebox_photo.ErrorImage")));
            this.Picturebox_photo.InitialImage = null;
            this.Picturebox_photo.Location = new System.Drawing.Point(322, 376);
            this.Picturebox_photo.Name = "Picturebox_photo";
            this.Picturebox_photo.Size = new System.Drawing.Size(104, 88);
            this.Picturebox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picturebox_photo.TabIndex = 25;
            this.Picturebox_photo.TabStop = false;
            this.Picturebox_photo.Click += new System.EventHandler(this.Picturebox_photo_Click);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Btn_addressproof);
            this.Controls.Add(this.Btn_idproof);
            this.Controls.Add(this.Brn_uploadphoto);
            this.Controls.Add(this.Chk_kyc);
            this.Controls.Add(this.Txtaddressproof);
            this.Controls.Add(this.Addressproof);
            this.Controls.Add(this.TxtIdproof);
            this.Controls.Add(this.Idproof);
            this.Controls.Add(this.Picturebox_photo);
            this.Controls.Add(this.Pictureboxphoto);
            this.Controls.Add(this.Date_dob);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Datagv_list);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Btn_addd);
            this.Controls.Add(this.Rtxt_notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_adharorpan);
            this.Controls.Add(this.Txt_emailaddress);
            this.Controls.Add(this.Txt_contact);
            this.Controls.Add(this.Txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(1418, 802);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            this.Click += new System.EventHandler(this.Btn_uploadphoto_click);
            this.History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.TextBox Txt_contact;
        private System.Windows.Forms.TextBox Txt_emailaddress;
        private System.Windows.Forms.TextBox Txt_adharorpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Rtxt_notes;
        private System.Windows.Forms.Button Btn_addd;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.DateTimePicker Date_dob;
        private System.Windows.Forms.Label Pictureboxphoto;
        private System.Windows.Forms.PictureBox Picturebox_photo;
        private System.Windows.Forms.Label Idproof;
        private System.Windows.Forms.Label Addressproof;
        private System.Windows.Forms.CheckBox Chk_kyc;
        private System.Windows.Forms.Button Brn_uploadphoto;
        private System.Windows.Forms.Button Btn_idproof;
        private System.Windows.Forms.Button Btn_addressproof;
        private System.Windows.Forms.TextBox Txtaddressproof;
        private System.Windows.Forms.TextBox TxtIdproof;
        private System.Windows.Forms.TabPage Interest_tab;
        private System.Windows.Forms.TabPage His_tab;
        private System.Windows.Forms.TabPage Kyc;
        private System.Windows.Forms.TabControl History;
        private System.Windows.Forms.DataGridView Datagv_list;
    }
}
