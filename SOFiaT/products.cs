using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFiaT
{
    public partial class products : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
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
            string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier";
            c.load_dgv(dataGridView1, query);
            rbtncode.Checked = true;
            btnact.Text = "Agregar";

            query = "select suppliername from [suppliers]";
            c.fill_CB(cbsupplier, query, "suppliername");


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
                string query = "select idproduct, name, [description], cost, saleprice, supplier, unid, photo, supplier from [products] where idproduct = '" + dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString() + "'";
                c.fill_txt(txtcode, query, "idproduct");
                txtcode.Enabled = false;
                btnact.Text = "Actualizar";
                c.fill_txt(txtnameprod, query, "name");
                c.fill_txt(txtdescprod, query, "description");
                //c.fill_txt(txtcost, query, "cost");
                c.fill_txt(txtsaleprice, query, "saleprice");
                //c.fill_txt(txtsupplier, query, "supplier");
                c.fill_txt(txtunid, query, "unid");
                cbsupplier.Text = dataGridView1.Rows[e.RowIndex].Cells["Suplidor"].Value.ToString();



                //c.fill_txt(txtshowimage, query, "photo");
                //c.fill_picture(pbphoto, query, "[products]", "photo");



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
            //txtcost.Clear();
            txtsaleprice.Clear();
            //txtsupplier.Clear();
            txtphoto.Clear();
            pbphoto.Image.Dispose();
            txtunid.Clear();
            c.valor = "";
            cbsupplier.Text = "";
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (!(txtcode.Text == "" || txtnameprod.Text == "" || txtsaleprice.Text == "" || txtunid.Text == "" || cbsupplier.Text == ""))
            {
                if (btnact.Text == "Agregar")
            {
                
                    string query1 = "select * from products where idproduct = '" + txtcode.Text + "'";
                    c.validation(query1);
                    if (c.valor == "no")
                    {

                        FileStream stream = new FileStream(txtphoto.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(stream);
                        FileInfo fi = new FileInfo(txtphoto.Text);
                        byte[] binData = new byte[stream.Length];
                        stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                        string supplierquery = "select idsupplier from suppliers where suppliername = '" + cbsupplier.Text + "'";
                        c.fill_txt(txtidsupplier, supplierquery, "idsupplier");

                        string query2 = "insert into products(idproduct, name, description, saleprice, idsupplier, unid, photo) values('" + txtcode.Text + "', '" + txtnameprod.Text + "', '" + txtdescprod.Text + "', '" + txtsaleprice.Text + "', '" + txtidsupplier.Text + "', '" + txtunid.Text + "', '"+ binData +"')";
                        c.command(query2);
                        //c.valor = "";
                        if (c.valor == "si")
                        {
                            string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier";
                            c.load_dgv(dataGridView1, query);

                            txtcode.Clear();
                            txtcode.Enabled = true;
                            btnact.Text = "Agregar";
                            txtnameprod.Clear();
                            txtdescprod.Clear();
                            //txtcost.Clear();
                            txtsaleprice.Clear();
                            //txtsupplier.Clear();
                            txtphoto.Clear();
                            pbphoto.Image.Dispose();
                            txtunid.Clear();
                            c.valor = "";
                            cbsupplier.Text = "";
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
                    string supplierquery = "select idsupplier from suppliers where suppliername = '" + cbsupplier.Text + "'";
                    c.fill_txt(txtidsupplier, supplierquery, "idsupplier");

                    string query = "update [products] set name = '" + txtnameprod.Text + "', description = '" + txtdescprod.Text + "',  saleprice = '" + txtsaleprice.Text + "', idsupplier = '" + txtidsupplier.Text + "', unid = '" + txtunid.Text + "' where [idproduct] = '" + txtcode.Text + "'";
                    c.command(query);
                    if (c.valor == "si")
                    {
                        query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier";
                        c.load_dgv(dataGridView1, query);

                        txtcode.Clear();
                        txtcode.Enabled = true;
                        btnact.Text = "Agregar";
                        txtnameprod.Clear();
                        txtdescprod.Clear();
                        //txtcost.Clear();
                        txtsaleprice.Clear();
                        //txtsupplier.Clear();
                        txtphoto.Clear();
                        try
                        {
                            pbphoto.Image.Dispose();
                        }
                        catch { }
                        txtunid.Clear();
                        c.valor = "";
                        cbsupplier.Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("No se ha procedido la informacion por falta de datos.");

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, base.ClientRectangle, this.BackColor, ButtonBorderStyle.Solid);
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
                string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and idproduct like '%" + txtsearch.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }
            else if (rbtnname.Checked == true)
            {
                string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and name like '%" + txtsearch.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }
            else if (rbtnsupplier.Checked == true)
            {
                string query = "SELECT idproduct as Code, [name] as Producto, [description] as Descripcion, [unid] as Unidad, [saleprice] as 'Precio de venta', s.suppliername as Suplidor FROM [products] as p, suppliers as s where p.idsupplier = s.idsupplier and s.suppliername like '%" + txtsearch.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }

        }

        private void cbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            txtphoto.Text = examinar.FileName;
            pbphoto.Image = Image.FromFile(examinar.FileName);



        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
