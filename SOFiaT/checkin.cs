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
            string query = "insert into checkinhead(date, createby) values('" + dtpdatecheckin.Text + "', '" + frm.txtactualuser.Text + "')";
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
            homeform frm = new homeform();
            txtuser.Text = frm.txtactualuser.Text;
            
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
        {
            
        }

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
            string query = "select * from inventory where [ref] = '" + txtidcheckin.Text + "'";
            c.load_dgv(dataGridView1, query);
        }
    }
}
