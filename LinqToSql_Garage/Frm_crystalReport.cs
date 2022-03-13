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
    public partial class Frm_crystalReport : Form
    {
        string id_rep, immatricule;
        public Frm_crystalReport(string id_rep,string immatricule)
        {
            InitializeComponent();
            this.id_rep = id_rep;
            this.immatricule = immatricule;
        }

        private void Frm_crystalReport_Load(object sender, EventArgs e)
        {
            cr_Reparations cr = new cr_Reparations();
            cr.SetDatabaseLogon("sa", "youss13262231");
            if(id_rep=="")
                crv.SelectionFormula = "{reparation.immatriculation} = '" + immatricule + "'";
            else
            crv.SelectionFormula = "{reparation.idReparation} = " + id_rep;
            crv.ReportSource = cr;
        }
    }
}
