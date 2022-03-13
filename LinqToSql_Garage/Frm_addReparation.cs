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
    public partial class Frm_addReparation : Form
    {
        string immatricule;
        garageDataContext db = new garageDataContext();
        public Frm_addReparation(string mtrcl)
        {
            InitializeComponent();
            this.immatricule = mtrcl;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            reparation r = new reparation();
            r.immatriculation = immatricule;
            r.idGarage =Convert.ToInt32(cmb_garage.SelectedValue);
            r.dateReparation = dtp_date.Value;
            r.prixReparation = Convert.ToDecimal(txt_prix.Text);
            db.reparations.InsertOnSubmit(r);
            db.SubmitChanges();
            this.Close();
        }

        private void Frm_addReparation_Load(object sender, EventArgs e)
        {
            var g = db.garages
                .Select(i => new { i.idGarage, i.nomGarage });
            cmb_garage.DisplayMember = "nomGarage";
            cmb_garage.ValueMember = "idGarage";
            cmb_garage.DataSource = g;
        }
    }
}
