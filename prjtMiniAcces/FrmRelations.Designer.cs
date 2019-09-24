namespace prjtMiniAcces
{
    partial class FrmRelations
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
            this.lblfield2 = new System.Windows.Forms.Label();
            this.lblfield1 = new System.Windows.Forms.Label();
            this.lbltable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnRelation = new System.Windows.Forms.Button();
            this.cmbTablesIndex2 = new System.Windows.Forms.ComboBox();
            this.cmbTablesIndex1 = new System.Windows.Forms.ComboBox();
            this.cmbFieldsIndex2 = new System.Windows.Forms.ComboBox();
            this.cmbFieldsIndex1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfield2
            // 
            this.lblfield2.AutoSize = true;
            this.lblfield2.Location = new System.Drawing.Point(213, 113);
            this.lblfield2.Name = "lblfield2";
            this.lblfield2.Size = new System.Drawing.Size(50, 17);
            this.lblfield2.TabIndex = 27;
            this.lblfield2.Text = "Field 2";
            this.lblfield2.Visible = false;
            // 
            // lblfield1
            // 
            this.lblfield1.AutoSize = true;
            this.lblfield1.Location = new System.Drawing.Point(12, 113);
            this.lblfield1.Name = "lblfield1";
            this.lblfield1.Size = new System.Drawing.Size(50, 17);
            this.lblfield1.TabIndex = 26;
            this.lblfield1.Text = "Field 1";
            this.lblfield1.Visible = false;
            // 
            // lbltable2
            // 
            this.lbltable2.AutoSize = true;
            this.lbltable2.Location = new System.Drawing.Point(213, 66);
            this.lbltable2.Name = "lbltable2";
            this.lbltable2.Size = new System.Drawing.Size(56, 17);
            this.lbltable2.TabIndex = 25;
            this.lbltable2.Text = "Table 2";
            this.lbltable2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Table 1";
            // 
            // bttnRelation
            // 
            this.bttnRelation.Location = new System.Drawing.Point(159, 179);
            this.bttnRelation.Name = "bttnRelation";
            this.bttnRelation.Size = new System.Drawing.Size(87, 33);
            this.bttnRelation.TabIndex = 23;
            this.bttnRelation.Text = "Relation";
            this.bttnRelation.UseVisualStyleBackColor = true;
            this.bttnRelation.Visible = false;
            this.bttnRelation.Click += new System.EventHandler(this.bttnRelation_Click);
            // 
            // cmbTablesIndex2
            // 
            this.cmbTablesIndex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablesIndex2.FormattingEnabled = true;
            this.cmbTablesIndex2.Location = new System.Drawing.Point(216, 86);
            this.cmbTablesIndex2.Name = "cmbTablesIndex2";
            this.cmbTablesIndex2.Size = new System.Drawing.Size(160, 24);
            this.cmbTablesIndex2.TabIndex = 22;
            this.cmbTablesIndex2.Visible = false;
            this.cmbTablesIndex2.SelectedIndexChanged += new System.EventHandler(this.cmbTablesIndex2_SelectedIndexChanged);
            // 
            // cmbTablesIndex1
            // 
            this.cmbTablesIndex1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablesIndex1.FormattingEnabled = true;
            this.cmbTablesIndex1.Location = new System.Drawing.Point(15, 86);
            this.cmbTablesIndex1.Name = "cmbTablesIndex1";
            this.cmbTablesIndex1.Size = new System.Drawing.Size(160, 24);
            this.cmbTablesIndex1.TabIndex = 21;
            this.cmbTablesIndex1.SelectedIndexChanged += new System.EventHandler(this.cmbTablesIndex1_SelectedIndexChanged);
            // 
            // cmbFieldsIndex2
            // 
            this.cmbFieldsIndex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldsIndex2.FormattingEnabled = true;
            this.cmbFieldsIndex2.Location = new System.Drawing.Point(216, 133);
            this.cmbFieldsIndex2.Name = "cmbFieldsIndex2";
            this.cmbFieldsIndex2.Size = new System.Drawing.Size(160, 24);
            this.cmbFieldsIndex2.TabIndex = 20;
            this.cmbFieldsIndex2.Visible = false;
            this.cmbFieldsIndex2.SelectedIndexChanged += new System.EventHandler(this.cmbFieldsIndex2_SelectedIndexChanged);
            // 
            // cmbFieldsIndex1
            // 
            this.cmbFieldsIndex1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldsIndex1.FormattingEnabled = true;
            this.cmbFieldsIndex1.Location = new System.Drawing.Point(15, 133);
            this.cmbFieldsIndex1.Name = "cmbFieldsIndex1";
            this.cmbFieldsIndex1.Size = new System.Drawing.Size(160, 24);
            this.cmbFieldsIndex1.TabIndex = 19;
            this.cmbFieldsIndex1.Visible = false;
            this.cmbFieldsIndex1.SelectedIndexChanged += new System.EventHandler(this.cmbFieldsIndex1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Relations";
            // 
            // FrmRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 230);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblfield2);
            this.Controls.Add(this.lblfield1);
            this.Controls.Add(this.lbltable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnRelation);
            this.Controls.Add(this.cmbTablesIndex2);
            this.Controls.Add(this.cmbTablesIndex1);
            this.Controls.Add(this.cmbFieldsIndex2);
            this.Controls.Add(this.cmbFieldsIndex1);
            this.Name = "FrmRelations";
            this.Text = "FrmRelations";
            this.Load += new System.EventHandler(this.FrmRelations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfield2;
        private System.Windows.Forms.Label lblfield1;
        private System.Windows.Forms.Label lbltable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnRelation;
        private System.Windows.Forms.ComboBox cmbTablesIndex2;
        private System.Windows.Forms.ComboBox cmbTablesIndex1;
        private System.Windows.Forms.ComboBox cmbFieldsIndex2;
        private System.Windows.Forms.ComboBox cmbFieldsIndex1;
        private System.Windows.Forms.Label label6;
    }
}