namespace Main_Form
{
    partial class BookingsControl
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
            this.components = new System.ComponentModel.Container();
            this.Cmbx_selectcustomer = new System.Windows.Forms.ComboBox();
            this.Cmbx_selectplot = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Txt_amount = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_book = new System.Windows.Forms.Button();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Dgv_listofbookings = new System.Windows.Forms.DataGridView();
            this.Labl_amount = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolStrip();
            this.Labelname = new System.Windows.Forms.Label();
            this.Labelplot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listofbookings)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmbx_selectcustomer
            // 
            this.Cmbx_selectcustomer.FormattingEnabled = true;
            this.Cmbx_selectcustomer.Location = new System.Drawing.Point(177, 84);
            this.Cmbx_selectcustomer.Name = "Cmbx_selectcustomer";
            this.Cmbx_selectcustomer.Size = new System.Drawing.Size(277, 24);
            this.Cmbx_selectcustomer.TabIndex = 0;
            this.Cmbx_selectcustomer.SelectedIndexChanged += new System.EventHandler(this.Cmbx_selectcustomer_SelectedIndexChanged);
            // 
            // Cmbx_selectplot
            // 
            this.Cmbx_selectplot.FormattingEnabled = true;
            this.Cmbx_selectplot.Location = new System.Drawing.Point(177, 131);
            this.Cmbx_selectplot.Name = "Cmbx_selectplot";
            this.Cmbx_selectplot.Size = new System.Drawing.Size(277, 24);
            this.Cmbx_selectplot.TabIndex = 1;
            this.Cmbx_selectplot.SelectedIndexChanged += new System.EventHandler(this.Cmbx_selectplot_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Txt_amount
            // 
            this.Txt_amount.Location = new System.Drawing.Point(177, 235);
            this.Txt_amount.Name = "Txt_amount";
            this.Txt_amount.Size = new System.Drawing.Size(211, 22);
            this.Txt_amount.TabIndex = 3;
            this.Txt_amount.TextChanged += new System.EventHandler(this.Txt_amount_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn_book
            // 
            this.Btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_book.Location = new System.Drawing.Point(177, 301);
            this.Btn_book.Name = "Btn_book";
            this.Btn_book.Size = new System.Drawing.Size(103, 51);
            this.Btn_book.TabIndex = 5;
            this.Btn_book.Text = "Book";
            this.Btn_book.UseVisualStyleBackColor = true;
            this.Btn_book.Click += new System.EventHandler(this.Btn_book_Click);
            // 
            // Btn_edit
            // 
            this.Btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_edit.Location = new System.Drawing.Point(313, 301);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(103, 51);
            this.Btn_edit.TabIndex = 6;
            this.Btn_edit.Text = "Edit";
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.Location = new System.Drawing.Point(451, 301);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(103, 51);
            this.Btn_cancel.TabIndex = 7;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Dgv_listofbookings
            // 
            this.Dgv_listofbookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listofbookings.Location = new System.Drawing.Point(587, 36);
            this.Dgv_listofbookings.Name = "Dgv_listofbookings";
            this.Dgv_listofbookings.RowHeadersWidth = 40;
            this.Dgv_listofbookings.RowTemplate.Height = 24;
            this.Dgv_listofbookings.Size = new System.Drawing.Size(783, 624);
            this.Dgv_listofbookings.TabIndex = 8;
            this.Dgv_listofbookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_listofbookings_CellContentClick);
            // 
            // Labl_amount
            // 
            this.Labl_amount.AutoSize = true;
            this.Labl_amount.Location = new System.Drawing.Point(76, 238);
            this.Labl_amount.Name = "Labl_amount";
            this.Labl_amount.Size = new System.Drawing.Size(52, 16);
            this.Labl_amount.TabIndex = 9;
            this.Labl_amount.Text = "Amount";
            // 
            // Tooltip
            // 
            this.Tooltip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tooltip.Location = new System.Drawing.Point(0, 0);
            this.Tooltip.Name = "Tooltip";
            this.Tooltip.Size = new System.Drawing.Size(1471, 25);
            this.Tooltip.TabIndex = 10;
            this.Tooltip.Text = "toolStrip1";
            // 
            // Labelname
            // 
            this.Labelname.AutoSize = true;
            this.Labelname.Location = new System.Drawing.Point(76, 92);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(44, 16);
            this.Labelname.TabIndex = 11;
            this.Labelname.Text = "Name";
            // 
            // Labelplot
            // 
            this.Labelplot.AutoSize = true;
            this.Labelplot.Location = new System.Drawing.Point(76, 148);
            this.Labelplot.Name = "Labelplot";
            this.Labelplot.Size = new System.Drawing.Size(30, 16);
            this.Labelplot.TabIndex = 12;
            this.Labelplot.Text = "Plot";
            // 
            // BookingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Labelplot);
            this.Controls.Add(this.Labelname);
            this.Controls.Add(this.Tooltip);
            this.Controls.Add(this.Labl_amount);
            this.Controls.Add(this.Dgv_listofbookings);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Btn_book);
            this.Controls.Add(this.Txt_amount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Cmbx_selectplot);
            this.Controls.Add(this.Cmbx_selectcustomer);
            this.Name = "BookingsControl";
            this.Size = new System.Drawing.Size(1471, 817);
            this.Load += new System.EventHandler(this.BookingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listofbookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmbx_selectcustomer;
        private System.Windows.Forms.ComboBox Cmbx_selectplot;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Txt_amount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn_book;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.DataGridView Dgv_listofbookings;
        private System.Windows.Forms.Label Labl_amount;
        private System.Windows.Forms.ToolStrip Tooltip;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.Label Labelplot;
    }
}
