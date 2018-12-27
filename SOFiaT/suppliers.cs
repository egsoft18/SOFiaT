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
            string querry = "SELECT [idsupplier] as CODE, [suppliername] as Nombre,[contactname] as Contacto,[contactphone] as 'Tel Cont.',[address] as Direccion,[city] as Ciudad,[state] as 'Procvincia/Estado',[country] as Pais,[postalcode] as 'Codigo Postal',[phonenumber] as Tel,[email] as Email,[coment] as Comentario FROM [SOFiaT].[dbo].[suppliers]";
            c.load_dgv(dataGridView1, querry);

            gbsupplierdata.Hide();

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gbsupplierdata_Enter(object sender, EventArgs e)
        {
            
        }

        private void visorDeSuplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT [idsupplier] as CODE, [suppliername] as Nombre,[contactname] as Contacto,[contactphone] as 'Tel Cont.',[address] as Direccion,[city] as Ciudad,[state] as 'Procvincia/Estado',[country] as Pais,[postalcode] as 'Codigo Postal',[phonenumber] as Tel,[email] as Email,[coment] as Comentario FROM [SOFiaT].[dbo].[suppliers]";
            c.load_dgv(dataGridView1, querry);
            gbsuppliersv.Show();
            gbsupplierdata.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string querry = "SELECT [idsupplier], [suppliername],[contactname],[contactphone],[address],[city],[state],[country],[postalcode],[phonenumber],[email],[coment] FROM [SOFiaT].[dbo].[suppliers] where [idsupplier] = '" + dataGridView1.Rows[e.RowIndex].Cells["CODE"].Value.ToString() + "'";
                c.fill_txt(txtidsupplier, querry, "idsupplier");



                gbsuppliersv.Hide();
                gbsupplierdata.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
