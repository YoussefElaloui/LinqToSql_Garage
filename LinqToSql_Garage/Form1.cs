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
    public partial class Frm_voitures : Form
    {
        garageDataContext db = new garageDataContext();
        public Frm_voitures()
        {
            InitializeComponent();
        }
        void activate(bool b)
        {
            pnl_lst.Enabled = b;
            pnl_details.Enabled = !b;
            btn_save.Visible = !b;
            btn_cancel.Visible = !b;
            btn_add.Visible = b;
            btn_update.Visible = b;
            btn_delete.Visible = b;
        }
        void clearBindings()
        {
            txt_matricule.DataBindings.Clear();
            txt_marque.DataBindings.Clear();
            txt_modele.DataBindings.Clear();
            txt_tele.DataBindings.Clear();
            txt_matricule.Clear();
            txt_marque.Clear();
            txt_modele.Clear();
            txt_tele.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var v = db.voitures
                .Where(r => r.immatriculation.Contains(txt_find.Text) || r.MarqueVoiture.Contains(txt_find.Text))
                .Select(r => new { r.immatriculation, r.MarqueVoiture });
            dgv.DataSource = v;
            
        }

        private void Frm_voitures_Load(object sender, EventArgs e)
        {
            btn_find.PerformClick();
            activate(true);
        }

        private void txt_find_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_find.PerformClick();
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0 && dgv.SelectedRows.Count > 0)
            {
                clearBindings();
                var v = db.voitures
                    .Where(r => r.immatriculation == dgv.SelectedRows[0].Cells[0].Value.ToString())
                    .Select(r => r);
                txt_matricule.DataBindings.Add("text", v, "immatriculation");
                txt_marque.DataBindings.Add("text", v, "MarqueVoiture");
                txt_modele.DataBindings.Add("text", v, "ModeleVoiture");
                txt_tele.DataBindings.Add("text", v, "TelephoneProprietaire");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows[0].Index < dgv.Rows.Count - 1)
            {
                int id = dgv.SelectedRows[0].Index;
                dgv.SelectedRows[0].Selected = false;
                dgv.Rows[id + 1].Selected = true;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows[0].Index != 0)
            {
                int id = dgv.SelectedRows[0].Index;
                dgv.SelectedRows[0].Selected = false;
                dgv.Rows[id - 1].Selected = true;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            dgv.SelectedRows[0].Selected = false;
            dgv.Rows[0].Selected = true;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            dgv.SelectedRows[0].Selected = false;
            dgv.Rows[dgv.Rows.Count-1].Selected = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            clearBindings();
            txt_matricule.Focus();
            activate(false);
            txt_matricule.Focus();
            isAdd = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            activate(false);
            txt_matricule.Focus();
            isAdd = false;
        }
        bool isAdd=true;
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                voiture v = new voiture();
                v.immatriculation = txt_matricule.Text;
                v.MarqueVoiture = txt_marque.Text;
                v.ModeleVoiture = txt_modele.Text;
                v.TelephoneProprietaire = txt_tele.Text;
                db.voitures.InsertOnSubmit(v);
                db.SubmitChanges();
            }
            else
            {
                var v = db.voitures
                    .Where(r => r.immatriculation == txt_matricule.Text)
                    .Select(r => r);
                voiture vo = v.FirstOrDefault();
                vo.MarqueVoiture = txt_marque.Text;
                vo.ModeleVoiture = txt_modele.Text;
                vo.TelephoneProprietaire = txt_tele.Text;
                db.SubmitChanges();

            }
            activate(true);
            btn_find.PerformClick();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            activate(true);
            btn_find.PerformClick();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about deleting this item", "Delete Car", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var v = db.voitures.Single(r => r.immatriculation == txt_matricule.Text);
                db.voitures.DeleteOnSubmit(v);
                db.SubmitChanges();
                btn_find.PerformClick();
            }
        }
    }
}
