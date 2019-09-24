namespace prjtMiniAcces
{
    partial class FrmViewData
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
            this.btInfo = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btInfo
            // 
            this.btInfo.Location = new System.Drawing.Point(12, 12);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(372, 63);
            this.btInfo.TabIndex = 2;
            this.btInfo.Text = "Display all the information about any Acces Database";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 16;
            this.lstInfo.Location = new System.Drawing.Point(12, 91);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(372, 276);
            this.lstInfo.TabIndex = 3;
            // 
            // FrmViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 378);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btInfo);
            this.Name = "FrmViewData";
            this.Text = "FrmViewData";
            this.Load += new System.EventHandler(this.FrmViewData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.ListBox lstInfo;
    }
}