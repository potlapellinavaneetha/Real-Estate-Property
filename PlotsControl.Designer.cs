using System.Windows.Forms;

namespace Main_Form
{
    partial class PlotsControl
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
            this.Flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flow_layout_panel
            // 
            this.Flow_layout_panel.Location = new System.Drawing.Point(159, 40);
            this.Flow_layout_panel.Name = "Flow_layout_panel";
            this.Flow_layout_panel.Size = new System.Drawing.Size(714, 488);
            this.Flow_layout_panel.TabIndex = 0;
            this.Flow_layout_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Flow_layout_panel_Paint);
            // 
            // PlotsControl
            // 
            this.Controls.Add(this.Flow_layout_panel);
            this.Name = "PlotsControl";
            this.Size = new System.Drawing.Size(1058, 564);
            this.Load += new System.EventHandler(this.PlotsControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel Flow_layout_panel;
    }
}
