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
    public partial class uc_page1 : UserControl
    {
        public uc_page1()
        {
            InitializeComponent();
        }
        garageDataContext db = new garageDataContext();
        private void uc_page1_Load(object sender, EventArgs e)
        {
            var r = db.voitures.Select(i => i);
            txt_nbTotalVoitures.Text = r.Count().ToString();
            var t = db.reparations.Select(i => i);
            txt_nbTotalReparations.Text = t.Count().ToString();
        }
    }
}
