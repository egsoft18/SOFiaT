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
            loadview();

        }
        public void loadview()
        {
            string querry = "SELECT [idsupplier] as CODE, [suppliername] as Nombre,[contactname] as Contacto,[contactphone] as 'Tel Cont.',[address] as Direccion,[city] as Ciudad,[state] as 'Procvincia/Estado',[country] as Pais,[postalcode] as 'Codigo Postal',[phonenumber] as Tel,[email] as Email,[coment] as Comentario FROM [SOFiaT].[dbo].[suppliers]";
            c.load_dgv(dataGridView1, querry);
            rbtnname.Checked = true;
            rbtnnameprod.Checked = true;
            gbsupplierdata.Hide();
            gbsuppliersv.Show();
            txtidsupplier.Clear();
            txtsuppliername.Clear();
            txtcontactname.Clear();
            txtcontactphone.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtstate.Clear();
            txtcountry.Clear();
            txtpostalcode.Clear();
            txtphonenumber.Clear();
            txtemail.Clear();
            txtcoment.Clear();
        }

        private void nuevoSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and [supplier] = '" + txtidsupplier.Text + "'";
            c.load_dgv(dgvsuppliersproducts, query);
            gbsupplierdata.Show();
            gbsuppliersv.Hide();
            btnsaction.Text = "Guardar";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gbsupplierdata_Enter(object sender, EventArgs e)
        {
            
        }

        private void visorDeSuplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsuppliername.Text) || !string.IsNullOrEmpty(txtidsupplier.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere cerrar sin guardar los cambios?", "Cerrar sin guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    loadview();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                loadview();
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsuppliername.Text) || !string.IsNullOrEmpty(txtidsupplier.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere cerrar sin guardar los cambios?", "Cerrar sin guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                this.Close();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["CODE"].Value.ToString().Length > 0)
            {
                try
                {
                    string querry = "SELECT [idsupplier], [suppliername],[contactname],[contactphone],[address],[city],[state],[country],[postalcode],[phonenumber],[email],[coment] FROM [SOFiaT].[dbo].[suppliers] where [idsupplier] = '" + dataGridView1.Rows[e.RowIndex].Cells["CODE"].Value.ToString() + "'";
                    c.fill_txt(txtidsupplier, querry, "idsupplier");
                    c.fill_txt(txtsuppliername, querry, "suppliername");
                    c.fill_txt(txtcontactname, querry, "contactname");
                    c.fill_txt(txtcontactphone, querry, "contactphone");
                    c.fill_txt(txtaddress, querry, "address");
                    c.fill_txt(txtcity, querry, "city");
                    c.fill_txt(txtstate, querry, "state");
                    c.fill_txt(txtcountry, querry, "country");
                    c.fill_txt(txtpostalcode, querry, "postalcode");
                    c.fill_txt(txtphonenumber, querry, "phonenumber");
                    c.fill_txt(txtemail, querry, "email");
                    c.fill_txt(txtcoment, querry, "coment");
                    btnsaction.Text = "Atualizar";

                    string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and [supplier] = '" + txtidsupplier.Text + "'";
                    c.load_dgv(dgvsuppliersproducts, query);

                    gbsuppliersv.Hide();
                    gbsupplierdata.Show();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private void txtphonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtcontactphone_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void btnsaction_Click(object sender, EventArgs e)
        {
            string querry = "";
            if (txtidsupplier.Text.Length <= 0) //Insertar suplidor
            {
                 querry = "Insert into [SOFiaT].[dbo].[suppliers]([suppliername],[contactname],[contactphone],[address],[city],[state],[country],[postalcode],[phonenumber],[email],[coment]) VALUES('" + txtsuppliername.Text + "','" + txtcontactname.Text + "','" + txtcontactphone.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "','" + txtstate.Text + "','" + txtcountry.Text + "','" + txtpostalcode.Text + "','" + txtphonenumber.Text + "','" + txtemail.Text + "','" + txtcoment.Text + "')";
                c.command(querry);
                loadview();
            }
           else if (txtidsupplier.Text.Length > 0) // Actualizar
            {
                querry = "update [SOFiaT].[dbo].[suppliers] set suppliername = '" + txtsuppliername.Text + "', contactname = '" + txtcontactname.Text + "', contactphone = '" + txtcontactphone.Text + "', address = '" + txtaddress.Text + "', city = '" + txtcity.Text + "', state = '" + txtstate.Text + "', country = '" + txtcountry.Text + "', postalcode = '" + txtpostalcode.Text + "', phonenumber = '" + txtphonenumber.Text + "', email = '" + txtemail.Text + "', coment = '" + txtcoment.Text + "' where idsupplier = '" + txtidsupplier.Text + "'";
                c.command(querry);
                loadview();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbtnname.Checked == true)
            {
                string querry = "SELECT [idsupplier] as CODE, [suppliername] as Nombre,[contactname] as Contacto,[contactphone] as 'Tel Cont.',[address] as Direccion,[city] as Ciudad,[state] as 'Procvincia/Estado',[country] as Pais,[postalcode] as 'Codigo Postal',[phonenumber] as Tel,[email] as Email,[coment] as Comentario FROM [SOFiaT].[dbo].[suppliers] where [suppliername] like '%"+ txtsupplierse.Text+"%'";
                c.load_dgv(dataGridView1, querry);
            }
            else if (rbtncontact.Checked == true)
            {
                string querry = "SELECT [idsupplier] as CODE, [suppliername] as Nombre,[contactname] as Contacto,[contactphone] as 'Tel Cont.',[address] as Direccion,[city] as Ciudad,[state] as 'Procvincia/Estado',[country] as Pais,[postalcode] as 'Codigo Postal',[phonenumber] as Tel,[email] as Email,[coment] as Comentario FROM [SOFiaT].[dbo].[suppliers] where [contactname] like '%" + txtsupplierse.Text + "%'";
                c.load_dgv(dataGridView1, querry);
            }
            else if(rbtncountry.Checked == true)
            {
                string querry = "SELECT [idsupplier] as CODE, [suppliername] as Nombre,[contactname] as Contacto,[contactphone] as 'Tel Cont.',[address] as Direccion,[city] as Ciudad,[state] as 'Procvincia/Estado',[country] as Pais,[postalcode] as 'Codigo Postal',[phonenumber] as Tel,[email] as Email,[coment] as Comentario FROM [SOFiaT].[dbo].[suppliers] where [country] like '%" + txtsupplierse.Text + "%'";
                c.load_dgv(dataGridView1, querry);
            }
            else
            {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtproductsea_TextChanged(object sender, EventArgs e)
        {
            if (rbtnnameprod.Checked == true)
            {
                string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and [supplier] = '" + txtidsupplier.Text + "' and name like '%" + txtproductsea.Text + "%'";
                c.load_dgv(dgvsuppliersproducts, query);
            }
            else if (rbtncodeprod.Checked == true)
            {
                string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and [supplier] = '" + txtidsupplier.Text + "' and idproduct like '%" + txtproductsea.Text + "%'";
                c.load_dgv(dgvsuppliersproducts, query);
            }
            else
            {

            }
        }

        private void btnsdelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsuppliername.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea borrar este suplidor? \n \n Esto borrara solo el suplidor y no podra ser asignado a mas productos, pero las demas infromaciones quedaran vigentes.", "Borrar Suplidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string querry = "delete from [SOFiaT].[dbo].[suppliers] where idsupplier = '" + txtidsupplier.Text + "'";
                    c.command(querry);
                    loadview();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void btnsclear_Click(object sender, EventArgs e)
        {
            txtsuppliername.Clear();
            txtcontactname.Clear();
            txtcontactphone.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtstate.Clear();
            txtcountry.Clear();
            txtpostalcode.Clear();
            txtphonenumber.Clear();
            txtemail.Clear();
            txtcoment.Clear();
        }
    }
}
