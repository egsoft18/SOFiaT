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
    public partial class checkin : Form
    {
        DBManager c = new DBManager();
        public checkin()
        {
            InitializeComponent();
        }

        private void btnnueva_Click(object sender, EventArgs e)
        {
            homeform frm = new homeform();
            string query = "insert into checkinhead(date,subtotal, discount, total, createby) values('" + dtpdatecheckin.Text + "', '0', '0', '0', '" + frm.txtactualuser.Text + "')";
            c.command(query);

            string comando = "Select idcheckin from checkinhead where idcheckin = (select max(idcheckin) from checkinhead)";
            c.last_id(txtlastid, comando, "idcheckin");

            txtidcheckin.Enabled = false;
        }

        private void txtlastid_TextChanged(object sender, EventArgs e)
        {
            txtidcheckin.Text = "F-" + txtlastid.Text;
        }

        private void checkin_Load(object sender, EventArgs e)
        {
            login_frm frm = new login_frm();
            txtuser.Text = frm.actual;
        }

        private void txtidprod_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT (sum(entryqty)-SUM(outqty)) as disponible FROM [SOFiaT].[dbo].[inventory] where idproduct like '" + txtidprod.Text + "'";
            c.fill_txt(txtqtyavailable, query, "disponible");
            query = "select idproduct, name, unid, saleprice from[SOFiaT].[dbo].[products] where idproduct like '" + txtidprod.Text + "'";
            c.fill_txt(txtnameprod, query, "idproduct");
            c.fill_txt(txtunid, query, "unid");
            c.fill_txt(txtprodprice, query, "saleprice");
        }

        private void txtidprod_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void txtidprod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertprodcheckin();
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertprodcheckin();
            }
        }

        private void insertprodcheckin()
        {
            string idcheckin = (txtidcheckin.Text.Remove(0, 2));
            string ci = "select * from checkinhead where idcheckin = '" + idcheckin + "'";
            c.validation(ci);
            if (c.valor == "si")
            {
                if (string.IsNullOrEmpty(txtqty.Text))
                {
                    txtqty.Text = "1";
                }
                if(Convert.ToDecimal(txtqtyavailable.Text) > Convert.ToDecimal(txtqty.Text))
                {
                txtpriceqty.Text = Convert.ToString(Convert.ToDecimal(txtqty.Text) * Convert.ToDecimal(txtprodprice.Text));
                     
                string query = "insert into inventory([idproduct], [outqty], [inventorycost], [ref], [datetrans], [typetrans]) VALUES('" + txtidprod.Text + "', '" + txtqty.Text + "', '" + txtpriceqty.Text + "', '" + txtidcheckin.Text + "', '" + dtpdatecheckin.Text + "', 'checkin')";
                c.command3(query);
                txtidprod.Clear();
                txtqty.Clear();
                txtpriceqty.Clear();
                txtnameprod.Clear();
                txtunid.Clear();
                txtprodprice.Clear();
                txtqtyavailable.Clear();
                dgv();
                }
                else
                {
                    MessageBox.Show("Segun inventarios, no puede vender las cantidad que esta procesando. Favor revise, o contacte al aministrador del sistema.", "No procede");
                }

                c.valor = "";
            }
            else
            {
                MessageBox.Show("No se ha encontrado ninguna factura con el valor digitad como ID " +idcheckin+ ", favor verifique.", "Error al procesar");
            }
        }

        private void txtidcheckin_TextChanged(object sender, EventArgs e)
        {
            if(txtidcheckin.Text.Length < 2)
            {
                txtidcheckin.Text = "F-";
                txtidcheckin.Select(txtidcheckin.Text.Length, 0);
            }
            txtsubtotal.Clear();
            txtdiscount.Clear();
            txttotal.Clear();
            dgv();
            string idcheckin = (txtidcheckin.Text.Remove(0, 2));
            string query = "select subtotal, discount, total from checkinhead where idcheckin = '" + idcheckin + "'";
            c.fill_txt(txtsubtotal, query, "subtotal");
            c.fill_txt(txtdiscount, query, "discount");
            c.fill_txt(txttotal, query, "total");
        }

        private void dgv()
        {
            string query = "select i.idproduct as IDProducto, p.name as Nombre, sum(i.[outqty]) as Cantidad, p.saleprice as Precio, sum(i.inventorycost) as Importe from [inventory] i, products p where i.idproduct = p.idproduct and i.ref = '" + txtidcheckin.Text + "' group by i.idproduct, p.name, p.saleprice";
            c.load_dgv(dataGridView1, query);

            string idcheckin = (txtidcheckin.Text.Remove(0, 2));
            query = "select date, subtotal, discount, total from checkinhead where idcheckin = '" + idcheckin + "'";
            c.validation(query);
            if (c.valor == "si")
            {
                c.fill_dtp(dtpdatecheckin, query, "date");
                string subtotal = "select sum(inventorycost) as subtotal from inventory where ref = '" + txtidcheckin.Text + "'";
                c.fill_txt(txtsubtotal, subtotal, "subtotal");
                query = "select subtotal, discount, total from checkinhead where idcheckin = '" + idcheckin + "'";
                c.fill_txt(txtdiscount, query, "discount");
                txttotal.Text = Convert.ToString(Convert.ToDecimal(txtsubtotal.Text) - Convert.ToDecimal(txtdiscount.Text));
                query = "update checkinhead set subtotal = '" + txtsubtotal.Text + "', discount = '" + txtdiscount.Text + "', total = '" + txttotal.Text + "' where idcheckin = '" + idcheckin + "'";
                c.command3(query);
                c.valor = "";
            }
        }

        private void checkinupdate()
        {
            string idcheckin = (txtidcheckin.Text.Remove(0, 2));
            if (string.IsNullOrEmpty(txtdiscount.Text))
            {
                txttotal.Text = txtsubtotal.Text;
                string query = "update checkinhead set subtotal = '" + txtsubtotal.Text + "', discount = '" + txtdiscount.Text + "', total = '" + txttotal.Text + "' where idcheckin = '" + idcheckin + "'";
                c.command3(query);
            }
            else
            {
                txttotal.Text = Convert.ToString(Convert.ToDecimal(txtsubtotal.Text) - Convert.ToDecimal(txtdiscount.Text));
                string query = "update checkinhead set subtotal = '" + txtsubtotal.Text + "', discount = '" + txtdiscount.Text + "', total = '" + txttotal.Text + "' where idcheckin = '" + idcheckin + "'";
                c.command3(query);
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            string idcheckin = (txtidcheckin.Text.Remove(0, 2));
            string query = "select subtotal, discount, total from checkinhead where idcheckin = '" + idcheckin + "'";
            c.validation(query);
            if (c.valor == "si")
            {
                if (string.IsNullOrEmpty(txtdiscount.Text))
                {
                    txttotal.Text = txtsubtotal.Text;
                    txtdiscount.Text = "0.00";
                    query = "update checkinhead set subtotal = '" + txtsubtotal.Text + "', discount = '" + txtdiscount.Text + "', total = '" + txttotal.Text + "' where idcheckin = '" + idcheckin + "'";
                    c.command3(query);
                }
                else
                {
                    txttotal.Text = Convert.ToString(Convert.ToDecimal(txtsubtotal.Text) - Convert.ToDecimal(txtdiscount.Text));
                    query = "update checkinhead set subtotal = '" + txtsubtotal.Text + "', discount = '" + txtdiscount.Text + "', total = '" + txttotal.Text + "' where idcheckin = '" + idcheckin + "'";
                    c.command3(query);
                }
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
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
