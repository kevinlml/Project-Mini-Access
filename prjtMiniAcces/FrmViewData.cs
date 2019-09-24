using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjtMiniAcces
{
    public partial class FrmViewData : Form
    {
        string path;
        public FrmViewData()
        {
            InitializeComponent();
            System.IO.Path.GetFullPath(FrmCreateData.svflDialog.FileName);
            this.path = Convert.ToString(FrmCreateData.svflDialog.FileName);
        }

        private void btInfo_Click(object sender, EventArgs e)
        {

            DAO.DBEngine dbe = new DAO.DBEngine();

            DAO.Database myDB = dbe.OpenDatabase(path);
            lstInfo.Items.Add("the database: " + myDB.Name);

            //loop to display the tables
            for (int t = 0; t < myDB.TableDefs.Count; t++)
            {
                if (myDB.TableDefs[t].Attributes == 0)
                {
                    lstInfo.Items.Add("- table :" + myDB.TableDefs[t].Name);

                    //loop to display the fields of each table
                    for (int f = 0; f < myDB.TableDefs[t].Fields.Count; f++)
                    {
                        lstInfo.Items.Add("\t - Fields: " + myDB.TableDefs[t].Fields[f].Name);
                    }
                    //loop to display inedexes
                    for (int g = 0; g < myDB.TableDefs[t].Indexes.Count; g++)
                    {
                        lstInfo.Items.Add("\t - Fields: " + myDB.TableDefs[t].Indexes[g].Name);

                       
                     for (int f = 0; f < ((DAO.IndexFields)(myDB.TableDefs[t].Indexes[g].Fields)).Count; f++)
                        {
                            lstInfo.Items.Add("\t\t Index Fields : " + ((Field)(((IndexFields)(myDB.TableDefs[t].Indexes[g].Fields))[f])).Name);
                        }
                        
                    }
                }
            }

            //loop to display the relation
            for (int r = 0; r < myDB.Relations.Count; r++)
            {
                if (myDB.Relations[r].Attributes == 0)
                {
                    lstInfo.Items.Add("- Relation: " + myDB.Relations[r].Name);

                    lstInfo.Items.Add("\t Primary Table: " + myDB.Relations[r].Table);

                    lstInfo.Items.Add("\t Foreign Table: " + myDB.Relations[r].ForeignTable);


                    //loop to display fields of relation
                    for (int f = 0; f < myDB.Relations[r].Fields.Count; f++)
                    {
                        lstInfo.Items.Add("\t\t Primary Field: " + myDB.Relations[r].Fields[f].Name);


                        lstInfo.Items.Add("\t\t Foreign field: " + myDB.Relations[r].Fields[f].ForeignName);

                    }

                }




            }

            myDB.Close();

        }

        private void FrmViewData_Load(object sender, EventArgs e)
        {

        }
    }
}
