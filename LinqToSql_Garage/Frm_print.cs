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
    public partial class Frm_print : Form
    {
        public Frm_print()
        {
            InitializeComponent();
        }
        garageDataContext db = new garageDataContext();
        private void Frm_print_Load(object sender, EventArgs e)
        {
            var v = db.voitures
                .Select(i => new { i.immatriculation });
            cmb_voitures.DisplayMember = "immatriculation";
            cmb_voitures.ValueMember = "immatriculation";
            cmb_voitures.DataSource = v;
        }

        private void cmb_voitures_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_reparations.Items.Clear();
            var r = db.reparations
                .Where(i => i.immatriculation == cmb_voitures.SelectedValue.ToString())
                .Select(i => i);
            if(cmb_voitures.SelectedIndex!=-1)
            foreach(var re in r)
            {
                cmb_reparations.Items.Add(re.idReparation);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Frm_crystalReport f = new Frm_crystalReport(cmb_reparations.Text,cmb_voitures.Text);
            f.ShowDialog();
        }
    }
}
