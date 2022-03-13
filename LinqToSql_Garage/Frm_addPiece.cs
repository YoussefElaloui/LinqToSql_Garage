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
    public partial class Frm_addPiece : Form
    {
        int id_reparation;
        public Frm_addPiece(int id_reparation)
        {
            InitializeComponent();
            this.id_reparation = id_reparation;
        }
        garageDataContext db = new garageDataContext();
        private void Frm_addPiece_Load(object sender, EventArgs e)
        {
            var p = db.pieces
                .Select(i=>new {i.idPiece,i.nomPiece });
            cmb_pieces.DisplayMember = "nomPiece";
            cmb_pieces.ValueMember = "idPiece";
            cmb_pieces.DataSource = p;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            utilise u = new utilise();
            u.idPiece = Convert.ToInt32(cmb_pieces.SelectedValue);
            u.idReparation = id_reparation;
            u.qte = Convert.ToInt32(txt_qte.Text);
            db.utilises.InsertOnSubmit(u);
            db.SubmitChanges();
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
