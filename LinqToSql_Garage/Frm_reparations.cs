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
    public partial class Frm_reparations : Form
    {
        public Frm_reparations()
        {
            InitializeComponent();
        }
        garageDataContext db = new garageDataContext();
        private void Frm_reparations_Load(object sender, EventArgs e)
        {
            var v = db.voitures
                .Select(r => new { r.immatriculation });
            combo_voitures.DisplayMember = "immatriculation";
            combo_voitures.ValueMember = "immatriculation";
            combo_voitures.DataSource = v;
        }
        void fillReparations()
        {
            var r = db.reparations
                .Where(t => t.immatriculation == combo_voitures.SelectedValue.ToString())
                .Select(t => new { t.idReparation });
            lst_reparations.DisplayMember = "idReparation";
            lst_reparations.ValueMember = "idReparation";
            lst_reparations.DataSource = r;
        }
        void fillUtilise()
        {
            var r = db.pieces
                .Join(db.utilises, i => i.idPiece, t => t.idPiece, (i, t) => new { i.nomPiece, i.prixPiece, t.idReparation, t.qte })
                .Where(i => i.idReparation == Convert.ToInt32(lst_reparations.SelectedValue))
                .Select(i => new { i.nomPiece, i.prixPiece, i.qte });
            dgv_utilise.DataSource = r;
            double prix = 0;
            foreach(DataGridViewRow row in dgv_utilise.Rows)
            {
                prix += Convert.ToDouble(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);
            }
            txt_prixPieces.Text = prix.ToString();
        }
        private void combo_voitures_SelectedValueChanged(object sender, EventArgs e)
        {
            fillReparations();
        }

        private void lst_reparations_SelectedValueChanged(object sender, EventArgs e)
        {
            fillUtilise();
            var r = db.reparations.Where(i => i.idReparation == Convert.ToInt32(lst_reparations.SelectedValue))
                .Select(i => new { i.prixReparation });
            if(r.Any())
                txt_prixReparation.Text = r.FirstOrDefault().prixReparation.ToString();
        }

        private void btn_addReparation_Click(object sender, EventArgs e)
        {
            Frm_addReparation f = new Frm_addReparation(combo_voitures.SelectedValue.ToString());
            f.ShowDialog();
            fillReparations();
        }

        private void btn_addPiece_Click(object sender, EventArgs e)
        {
            Frm_addPiece f = new Frm_addPiece(Convert.ToInt32(lst_reparations.SelectedValue));
            f.ShowDialog();
            fillUtilise();
        }
    }
}
