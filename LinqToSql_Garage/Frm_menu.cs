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
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_voitures f = new Frm_voitures();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_reparations f = new Frm_reparations();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_statistic f = new Frm_statistic();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_print f = new Frm_print();
            f.ShowDialog();
        }
    }
}
