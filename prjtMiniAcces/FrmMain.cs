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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you you want to quit the program ?", "Program Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void createTablaAndFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateData cdf = new FrmCreateData();
            cdf.MdiParent = this;
            cdf.Show();
        }

        private void createRelationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelations fr = new FrmRelations();
            fr.MdiParent = this;
            fr.Show();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewData fvd = new FrmViewData();
            fvd.MdiParent = this;
            fvd.Show();
        }
    }
}
