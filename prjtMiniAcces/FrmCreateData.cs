using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.IO;

namespace prjtMiniAcces
{
    public partial class FrmCreateData : Form
    {
        public FrmCreateData()
        {
            InitializeComponent();
        }
        Database myDB;
        DBEngine dbe = new DBEngine();
        TableDef myTB;
        Field myFL;

        public static SaveFileDialog svflDialog = new SaveFileDialog();

        private void FrmCreateData_Load(object sender, EventArgs e)
        {
            this.Height = 140;
        }

        private void bttnCreatenSaveData_Click(object sender, EventArgs e)
        {
            svflDialog.Filter = "Microsoft Access|.accdb|All Files|*.*";
            //svflDialog.
            if (svflDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(svflDialog.FileName))
                {
                    File.Delete(svflDialog.FileName);
                }

                myDB = dbe.CreateDatabase(svflDialog.FileName, DAO.LanguageConstants.dbLangGeneral);
                Path.GetFullPath(svflDialog.FileName);




                myDB.Close();
            }
            this.Height = 190;
            bttnCreatenSaveData.Enabled = false;
        }

        private void bttnSaveTable_Click(object sender, EventArgs e)
        {
            if (txtTables.Text == "")
            { }
            else
            {
                myDB = dbe.OpenDatabase(svflDialog.FileName);
                myTB = myDB.CreateTableDef(txtTables.Text.ToString());
                myFL = myTB.CreateField("Ref" + txtTables.Text, DAO.DataTypeEnum.dbLong);
                myFL.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                myTB.Fields.Append(myFL);
                Index myInd = myTB.CreateIndex("primaryKey");
                myFL = myInd.CreateField("Ref" + txtTables.Text);
                ((IndexFields)(myInd.Fields)).Append(myFL);
                myInd.Primary = true;
                myTB.Indexes.Append(myInd);
                myDB.TableDefs.Append(myTB);
                MessageBox.Show(myTB.Name + " was created with success.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Height = 280;
                txtTables.Clear();
                txtTables.Enabled = false;
                bttnSaveTable.Enabled = false;
                txtfields.Focus();
                txtfields.Clear();
            }
        }

        private void bttnSaveFields_Click(object sender, EventArgs e)
        {
            if (txtfields.Text == "")
            {
                MessageBox.Show("Please fullfill the text field.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbDataIndexmboBox1.Text == "")
            {
                MessageBox.Show("Please fullfill the index field.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                myDB = dbe.OpenDatabase(svflDialog.FileName);

                CreateField(txtfields, cmbDataIndexmboBox1);
         
            myTB.Fields.Append(myFL);
           
            if (MessageBox.Show("Do you want to create another field?", "Create Data", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                txtfields.Clear();
                txtfields.Focus();
            }
            else
            {
                if (MessageBox.Show("Do you want to create another Table ?", "Create Data", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                { // MessageBox.Show("If you want to create another table, you can continue if not close this.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfields.Clear();
                    txtTables.Enabled = true;
                    bttnSaveTable.Enabled = true;
                    txtTables.Clear();
                    txtTables.Focus();
                    this.Height = 190;
                }
                else
                {
                        MessageBox.Show("Your data was created with success, This will close.\nIf you want to create relationship, go to 'create relationship'.\nIf you want to see your data information, go to 'view data'.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); }
            }
        }
    }

        private void CreateField(TextBox txtfields, ComboBox cmbDataIndexmboBox1)
        {
            string typedata = cmbDataIndexmboBox1.Text;

            switch (typedata)
            {
                case "Short Text":
                    {
                        myFL = myTB.CreateField(txtfields.Text, DAO.DataTypeEnum.dbText);

                    }
                    break;

                case "Number":
                    {
                        myFL = myTB.CreateField(txtfields.Text, DAO.DataTypeEnum.dbInteger);

                    }
                    break;
                case "Date/Time":
                    {
                        myFL = myTB.CreateField(txtfields.Text, DAO.DataTypeEnum.dbDate);

                    }
                    break;
                case "Currency":
                    {
                        myFL = myTB.CreateField(txtfields.Text, DAO.DataTypeEnum.dbCurrency);

                    }


                    break;
                case "Yes/No":
                    {
                        myFL = myTB.CreateField(txtfields.Text, DAO.DataTypeEnum.dbBoolean);

                    }
                    break;
            }
        }
    }
}
