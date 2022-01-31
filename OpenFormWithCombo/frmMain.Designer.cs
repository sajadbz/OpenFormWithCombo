
namespace OpenFormWithCombo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboShowPage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboShowPage
            // 
            this.cboShowPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShowPage.FormattingEnabled = true;
            this.cboShowPage.Items.AddRange(new object[] {
            "Page A",
            "Page B"});
            this.cboShowPage.Location = new System.Drawing.Point(43, 31);
            this.cboShowPage.Name = "cboShowPage";
            this.cboShowPage.Size = new System.Drawing.Size(121, 23);
            this.cboShowPage.TabIndex = 0;
            this.cboShowPage.SelectedIndexChanged += new System.EventHandler(this.cboShowPage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Page :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboShowPage);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboShowPage;
        private System.Windows.Forms.Label label1;
    }
}

