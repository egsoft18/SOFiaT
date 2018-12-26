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
    public partial class RNC : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
        DBManager c = new DBManager();


        public RNC()
        {
            InitializeComponent();
        }

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
            string querry = @"BULK INSERT rnc FROM 'C:\Users\Ed Gomez\Desktop\DGII_RNC.TXT' WITH ( FIELDTERMINATOR = '|', ROWTERMINATOR = '\n' )";
            c.command(querry);
            txtfile.Clear();
        }
    }
}
