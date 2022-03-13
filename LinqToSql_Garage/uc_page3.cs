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
    public partial class uc_page3 : UserControl
    {
        public uc_page3()
        {
            InitializeComponent();
        }
        garageDataContext db = new garageDataContext();
        private void uc_page3_Load(object sender, EventArgs e)
        {
            var v = db.reparations
                .Join(db.utilises, i => i.idReparation, t => t.idReparation, (i, t) => new { i.dateReparation, t.idPiece, t.qte })
                .Join(db.pieces, i => i.idPiece, t => t.idPiece, (i, t) => new { i.dateReparation, i.qte, t.prixPiece })
                .GroupBy(i => i.dateReparation)
                .Select(i => new { Day= i.Key,PrixTotal=i.Sum(t=>t.prixPiece*t.qte) });
            dgv.DataSource = v;
        }
    }
}
