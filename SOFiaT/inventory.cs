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
    public partial class inventory : Form
    {
        DBManager c = new DBManager();

        public inventory()
        {
            InitializeComponent();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            string query = "select i.[idproduct] as IDProducto, p.name as Nombre,  sum(i.[entryqty]) as Entrada, sum(i.[outqty]) as Vendidas, sum(i.[entryqty]) - sum(i.[outqty]) as Balance  from inventory as i, products as p where i.idproduct = p.idproduct group by i.idproduct, p.name";
            c.load_dgv(dataGridView1, query);
            rbtnidprod.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbtnidprod.Checked == true)
            {
                string query = "select i.[idproduct] as IDProducto, p.name as Nombre,  sum(i.[entryqty]) as Entrada, sum(i.[outqty]) as Vendidas, sum(i.[entryqty]) - sum(i.[outqty]) as Balance  from inventory as i, products as p where i.idproduct = p.idproduct and i.[idproduct] like '%" + txtsearch.Text + "%' group by i.idproduct, p.name";
                c.load_dgv(dataGridView1, query);
            }
            else if (rbtnnameprod.Checked == true)
            {
                string query = "select i.[idproduct] as IDProducto, p.name as Nombre,  sum(i.[entryqty]) as Entrada, sum(i.[outqty]) as Vendidas, sum(i.[entryqty]) - sum(i.[outqty]) as Balance  from inventory as i, products as p where i.idproduct = p.idproduct and p.name like '%" + txtsearch.Text + "%' group by i.idproduct, p.name";
                c.load_dgv(dataGridView1, query);
            }
        }
    }
}
