using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFiaT
{
    public partial class RNC : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
        DBManager c = new DBManager();
        //private BackgroundWorker bgw;

        public RNC()
        {
            InitializeComponent();
        }
        struct DataParameter
        {
            public int process;
            public int delay;

        }

        private DataParameter _inputparameter;

        private void btnfile_Click(object sender, EventArgs e)
        {
            examinar.Filter = "Text Files|*.txt;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            txtfile.Text = examinar.FileName;
            //pbphoto.Image = Image.FromFile(examinar.FileName);
        }
        

        private void btnuploadRNC_Click(object sender, EventArgs e)
        {
            if (txtfile.Text.Length > 0)
            {
                //if (!backgroundWorker1.IsBusy) {
                //    _inputparameter.delay = 100;
                //    _inputparameter.process = 1200;
                //    backgroundWorker1.RunWorkerAsync(_inputparameter);

                //}
                //MessageBox.Show("Espere mientras se procesa la informacion", "Procesando");
                string querry = @"delete [SOFiaT].[dbo].[rnc]";
                c.command3(querry);
                querry = @"BULK INSERT rnc FROM '" + txtfile.Text + "' WITH ( FIELDTERMINATOR = '|', ROWTERMINATOR = '\n' )";
                c.command(querry);
                txtfile.Clear();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el archivo para proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //    progressBar1.Value = e.ProgressPercentage;
            //    lbprogress.Text = string.Format("Procesando... {0}%", e.ProgressPercentage);
            //    progressBar1.Update();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        //    int process = ((DataParameter)e.Argument).process;
        //    int delay = ((DataParameter)e.Argument).delay;
        //    int index = 1;
        //    try
        //    {
        //        for (int i = 0; i < process; i++)
        //        {
        //            if (!backgroundWorker1.CancellationPending)
        //            {
        //                backgroundWorker1.ReportProgress(index++ * 100, string.Format("Process data {0}", i));
        //                Thread.Sleep(delay);

        //                if (txtfile.Text.Length > 0)
        //                {

        //                string querry = @"delete [SOFiaT].[dbo].[rnc]";
        //                c.command3(querry);
        //                querry = @"BULK INSERT rnc FROM '" + txtfile.Text + "' WITH ( FIELDTERMINATOR = '|', ROWTERMINATOR = '\n' )";
        //                c.command(querry);
        //                txtfile.Clear();

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Debe de seleccionar el archivo para proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
