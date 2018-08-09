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
    public partial class addproduct : Form
    {
        DBManager c = new DBManager();
        public addproduct()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsaveprod_Click(object sender, EventArgs e)
        {
            if (btnsaveprod.Text == "Guardar") { 
            string query1 = "select * from products where idproduct = '" + txtcode.Text + "'";
            c.validation(query1);
            if(c.valor == "no")
            {
                    string query2 = "insert into products(idproduct, name, description, cost, saleprice, supplier) values('" + txtcode.Text + "', '" + txtname.Text + "', '" + txtdescription.Text + "', '" + txtcost.Text + "', '" + txtsaleprice.Text + "', '" + txtsupplier.Text + "')";
                    c.command(query2);
                    c.valor = "";
            }
            else if (c.valor == "si")
            {
                    MessageBox.Show("Ya existe un producto con este codigo", "Error al guardar");
                    c.valor = "";
            }
            }
            else if (btnsaveprod.Text == "Actualizar")
            {
                string query = "update [products] set name = '" + txtname.Text + "', description = '" + txtdescription.Text + "', cost = '" + txtcost.Text + "', saleprice = '" + txtsaleprice.Text + "', supplier = '" + txtsupplier.Text + "'";
                c.command(query);
                string query2 = "Select idproduct as Code, name as Nombre, [description] as Descripcion, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products";
                products frm = new products();
                c.load_dgv(frm.dataGridView1, query2);

                this.Close();
            }

        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
