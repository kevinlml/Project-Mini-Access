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

namespace prjtMiniAcces
{
    public partial class FrmRelations : Form
    {
        string path;
        public FrmRelations()
        {
            System.IO.Path.GetFullPath(FrmCreateData.svflDialog.FileName);
            this.path = Convert.ToString(FrmCreateData.svflDialog.FileName);
            InitializeComponent();
        }
        Database myDB;
        DBEngine dbe = new DBEngine();
        private void FrmRelations_Load(object sender, EventArgs e)
        {
            myDB = dbe.OpenDatabase(path);
            for (int t = 0; t < myDB.TableDefs.Count; t++)
            {
                if (myDB.TableDefs[t].Attributes == 0)
                {
                    cmbTablesIndex1.Items.Add(myDB.TableDefs[t].Name);
                    cmbTablesIndex2.Items.Add(myDB.TableDefs[t].Name);
                }

            }
            myDB.Close();
        }

        private void cmbTablesIndex1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myDB = dbe.OpenDatabase(path);
            for (int t = 0; t < myDB.TableDefs.Count; t++)
            {
                if (myDB.TableDefs[t].Attributes == 0)
                {
                    cmbTablesIndex2.Items.Remove(cmbTablesIndex1.SelectedItem);
                    //cmbTablesIndex2.Items.Add(myDB.TableDefs[t].Name);
                }
            }
            myDB = dbe.OpenDatabase(path);
            for (int f = 0; f < myDB.TableDefs[cmbTablesIndex1.SelectedIndex].Fields.Count; f++)
            {


                cmbFieldsIndex1.Items.Add(myDB.OpenTable(cmbTablesIndex1.Text).Fields[f].Name);



            }
            myDB.Close();
            cmbFieldsIndex1.Visible = true;
            lblfield1.Visible = true; 
        }

        private void cmbFieldsIndex1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTablesIndex2.Visible = true;
            lbltable2.Visible = true;
        }

        private void cmbTablesIndex2_SelectedIndexChanged(object sender, EventArgs e)
        {
            myDB = dbe.OpenDatabase(path);
            for (int f = 0; f < myDB.TableDefs[cmbTablesIndex2.SelectedIndex].Fields.Count; f++)
            {


                cmbFieldsIndex2.Items.Add(myDB.OpenTable(cmbTablesIndex2.Text).Fields[f].Name);



            }
            myDB.Close();
            cmbFieldsIndex2.Visible = true;
            lblfield2.Visible = true;
        }

        private void cmbFieldsIndex2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnRelation.Visible = true;
        }

        private void bttnRelation_Click(object sender, EventArgs e)
        {
            myDB = dbe.OpenDatabase(path);
            Relation myRel = myDB.CreateRelation(cmbTablesIndex1.Text + cmbTablesIndex2.Text, cmbTablesIndex1.Text, cmbTablesIndex2.Text);
            Field myFL = myRel.CreateField(cmbFieldsIndex1.Text);
            myFL.ForeignName = cmbFieldsIndex2.Text;
            myRel.Fields.Append(myFL);
            myDB.Relations.Append(myRel);
            MessageBox.Show("The relationship called "+myRel.Name + " was created with success.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myDB.Close();
            this.Close();
        }
    }
}
