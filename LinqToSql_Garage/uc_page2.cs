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
    public partial class uc_page2 : UserControl
    {
        public uc_page2()
        {
            InitializeComponent();
        }
        garageDataContext db = new garageDataContext();
        private void uc_page2_Load(object sender, EventArgs e)
        {
            var r = db.voitures
                .GroupBy(i => i.MarqueVoiture)
                .Select(i => new { i.Key, NombreVoitures = i.Count() });
            dgv.DataSource = r;
        }
    }
}
