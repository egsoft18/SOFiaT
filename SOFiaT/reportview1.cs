using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFiaT
{
    public partial class reportview1 : Form
    {

        public reportview1(string name_report)
        {
            InitializeComponent();

            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load(name_report);
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
