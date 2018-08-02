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
    public partial class products : Form
    {
        DBManager c = new DBManager();
        public products()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void products_Load(object sender, EventArgs e)
        {
            string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, cost as Costo, saleprice as 'Precio de Venta', supplier as Siplidor from products";
            c.load_dgv(dataGridView1, query);
    }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            //homeform c = new homeform();
            //c.openfrm(new addproduct());
            addproduct frm = new addproduct();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
         
        }

        private void products_Activated(object sender, EventArgs e)
        {
            string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, cost as Costo, saleprice as 'Precio de Venta', supplier as Siplidor from products";
            c.load_dgv(dataGridView1, query);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addproduct frm = new addproduct();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
