using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    public partial class frmVisualizador : Form
    {
        public frmVisualizador(CrystalDecisions.CrystalReports.Engine.ReportDocument reporte)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
