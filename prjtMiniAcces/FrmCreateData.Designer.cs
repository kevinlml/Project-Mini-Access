namespace prjtMiniAcces
{
    partial class FrmCreateData
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
            this.bttnCreatenSaveData = new System.Windows.Forms.Button();
            this.cmbDataIndexmboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnSaveFields = new System.Windows.Forms.Button();
            this.txtfields = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnSaveTable = new System.Windows.Forms.Button();
            this.txtTables = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCreatenSaveData
            // 
            this.bttnCreatenSaveData.Location = new System.Drawing.Point(12, 68);
            this.bttnCreatenSaveData.Name = "bttnCreatenSaveData";
            this.bttnCreatenSaveData.Size = new System.Drawing.Size(183, 44);
            this.bttnCreatenSaveData.TabIndex = 1;
            this.bttnCreatenSaveData.Text = "Create and save database";
            this.bttnCreatenSaveData.UseVisualStyleBackColor = true;
            this.bttnCreatenSaveData.Click += new System.EventHandler(this.bttnCreatenSaveData_Click);
            // 
            // cmbDataIndexmboBox1
            // 
            this.cmbDataIndexmboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataIndexmboBox1.FormattingEnabled = true;
            this.cmbDataIndexmboBox1.Items.AddRange(new object[] {
            "Short Text",
            "Number",
            "Date/Time",
            "Yes/No",
            "Currency"});
            this.cmbDataIndexmboBox1.Location = new System.Drawing.Point(11, 259);
            this.cmbDataIndexmboBox1.Name = "cmbDataIndexmboBox1";
            this.cmbDataIndexmboBox1.Size = new System.Drawing.Size(100, 24);
            this.cmbDataIndexmboBox1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fields";
            // 
            // bttnSaveFields
            // 
            this.bttnSaveFields.Location = new System.Drawing.Point(137, 259);
            this.bttnSaveFields.Name = "bttnSaveFields";
            this.bttnSaveFields.Size = new System.Drawing.Size(75, 24);
            this.bttnSaveFields.TabIndex = 33;
            this.bttnSaveFields.Text = "Save";
            this.bttnSaveFields.UseVisualStyleBackColor = true;
            this.bttnSaveFields.Click += new System.EventHandler(this.bttnSaveFields_Click);
            // 
            // txtfields
            // 
            this.txtfields.Location = new System.Drawing.Point(11, 219);
            this.txtfields.Name = "txtfields";
            this.txtfields.Size = new System.Drawing.Size(100, 22);
            this.txtfields.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tables";
            // 
            // bttnSaveTable
            // 
            this.bttnSaveTable.Location = new System.Drawing.Point(137, 160);
            this.bttnSaveTable.Name = "bttnSaveTable";
            this.bttnSaveTable.Size = new System.Drawing.Size(75, 23);
            this.bttnSaveTable.TabIndex = 29;
            this.bttnSaveTable.Text = "Save Table";
            this.bttnSaveTable.UseVisualStyleBackColor = true;
            this.bttnSaveTable.Click += new System.EventHandler(this.bttnSaveTable_Click);
            // 
            // txtTables
            // 
            this.txtTables.Location = new System.Drawing.Point(11, 161);
            this.txtTables.Name = "txtTables";
            this.txtTables.Size = new System.Drawing.Size(100, 22);
            this.txtTables.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Create Data";
            // 
            // FrmCreateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDataIndexmboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnSaveFields);
            this.Controls.Add(this.txtfields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSaveTable);
            this.Controls.Add(this.txtTables);
            this.Controls.Add(this.bttnCreatenSaveData);
            this.Name = "FrmCreateData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCreateData";
            this.Load += new System.EventHandler(this.FrmCreateData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCreatenSaveData;
        private System.Windows.Forms.ComboBox cmbDataIndexmboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnSaveFields;
        private System.Windows.Forms.TextBox txtfields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnSaveTable;
        private System.Windows.Forms.TextBox txtTables;
        private System.Windows.Forms.Label label6;
    }
}