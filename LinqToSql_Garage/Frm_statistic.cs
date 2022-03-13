using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql_Garage
{
    public partial class Frm_statistic : Form
    {
        public Frm_statistic()
        {
            InitializeComponent();
        }
        void top(UserControl uc)
        {
            uc_page11.Visible = false;
            uc_page21.Visible = false;
            uc_page31.Visible = false;
            uc.Visible = true;
        }

        private void page1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top(uc_page11);
        }

        private void page2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top(uc_page21);
        }

        private void page3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top(uc_page31);
        }

        private void Frm_statistic_Load(object sender, EventArgs e)
        {
            top(uc_page11);
        }
    }
}
