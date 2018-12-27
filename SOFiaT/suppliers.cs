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
    public partial class suppliers : Form
    {
        DBManager c = new DBManager();
        public suppliers()
        {
            InitializeComponent();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            string querry = "SELECT TOP 1000 [idsupplier], [suppliername],[contactname],[contactphone],[address],[city],[state],[country],[postalcode],[phonenumber],[email],[coment] FROM [SOFiaT].[dbo].[suppliers]";
            c.load_dgv(dataGridView1, querry);

            gbsupplierdata.Hide();

        }

        private void nuevoSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbsupplierdata.Show();
            gbsuppliersv.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    homeform f = new homeform();
            //    supplierdata ofrm = new supplierdata();
            //    this.Close();
            //    if (f.container.Controls.Count > 0)
            //    { f.container.Controls.RemoveAt(0);
            //    Form frm = new supplierdata() as Form;
            //    frm.TopLevel = false;
            //    frm.Dock = DockStyle.Fill;
            //    f.container.Controls.Add(frm);
            //    f.container.Tag = frm;
            //    frm.Show(); }

            //    else{
            //        MessageBox.Show("mas de 0");

            //    }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
