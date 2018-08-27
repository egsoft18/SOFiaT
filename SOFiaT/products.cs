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
            string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products";
            c.load_dgv(dataGridView1, query);
            rbtncode.Checked = true;
            btnact.Text = "Agregar";
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
            string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products";
            c.load_dgv(dataGridView1, query);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                string query = "select idproduct, name, [description], cost, saleprice, supplier, unid from [products] where idproduct = '" + dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString() + "'";
                c.fill_txt(txtcode, query, "idproduct");
                txtcode.Enabled = false;
                btnact.Text = "Actualizar";
                c.fill_txt(txtnameprod, query, "name");
                c.fill_txt(txtdescprod, query, "description");
                c.fill_txt(txtcost, query, "cost");
                c.fill_txt(txtsaleprice, query, "saleprice");
                c.fill_txt(txtsupplier, query, "supplier");
                c.fill_txt(txtunid, query, "unid");
                //frm.TopLevel = false;
                //frm.Dock = DockStyle.Fill;
                //this.Controls.Add(frm);
                //this.Tag = frm;
                //frm.BringToFront();
                //frm.Show(); 
            }
            catch
            {

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtcode.Clear();
            txtcode.Enabled = true;
            btnact.Text = "Agregar";
            txtnameprod.Clear();
            txtdescprod.Clear();
            txtcost.Clear();
            txtsaleprice.Clear();
            txtsupplier.Clear();
            txtunid.Clear();
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (btnact.Text == "Agregar")
            {
                string query1 = "select * from products where idproduct = '" + txtcode.Text + "'";
                c.validation(query1);
                if (c.valor == "no")
                {
                    string query2 = "insert into products(idproduct, name, description, cost, saleprice, supplier, unid) values('" + txtcode.Text + "', '" + txtnameprod.Text + "', '" + txtdescprod.Text + "', '" + txtcost.Text + "', '" + txtsaleprice.Text + "', '" + txtsupplier.Text + "', '" + txtunid.Text + "')";
                    c.command(query2);
                    //c.valor = "";
                    if (c.valor == "si")
                    {
                        string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products";
                        c.load_dgv(dataGridView1, query);

                        txtcode.Clear();
                        txtcode.Enabled = true;
                        btnact.Text = "Agregar";
                        txtnameprod.Clear();
                        txtdescprod.Clear();
                        txtcost.Clear();
                        txtsaleprice.Clear();
                        txtsupplier.Clear();
                        txtunid.Clear();
                        c.valor = "";
                    }
                }
                else if (c.valor == "si")
                {
                    MessageBox.Show("Ya existe un producto con este codigo", "Error al guardar");
                    c.valor = "";
                }
            }
            else if (btnact.Text == "Actualizar")
            {
                string query = "update [products] set name = '" + txtnameprod.Text + "', description = '" + txtdescprod.Text + "', cost = '" + txtcost.Text + "', saleprice = '" + txtsaleprice.Text + "', supplier = '" + txtsupplier.Text + "', unid = '" + txtunid.Text + "'";
                c.command(query);
                if (c.valor == "si")
                {
                    query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products";
                    c.load_dgv(dataGridView1, query);

                    txtcode.Clear();
                    txtcode.Enabled = true;
                    btnact.Text = "Agregar";
                    txtnameprod.Clear();
                    txtdescprod.Clear();
                    txtcost.Clear();
                    txtsaleprice.Clear();
                    txtsupplier.Clear();
                    c.valor = "";
                }

            }
        }

        private void txtcost_KeyDown(object sender, KeyEventArgs e)
        {
           
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(rbtncode.Checked == true)
            {
                string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products where idproduct like '%" + txtsearch.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }
            else if (rbtnname.Checked == true)
            {
                string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products where name like '%" + txtsearch.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }
            else if (rbtnsupplier.Checked == true)
            {
                string query = "Select idproduct as Code, name as Nombre, [description] as Descripcion, unid as Unidad, cost as Costo, saleprice as 'Precio de Venta', supplier as Suplidor from products where supplier like '%" + txtsearch.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }

        }
    }
}
