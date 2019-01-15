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
    public partial class entryinvoice : Form
    {
        DBManager c = new DBManager();
        public entryinvoice()
        {
            InitializeComponent();
        }

        private void entryinvoice_Load(object sender, EventArgs e)
        {
            loadview();
        }
        private void loadview()
        {
            string query = "SELECT TOP 1000 [idrecinvoice] as IDrecInvoice ,[supplier] as Suplidor, [rncsupplier] as RNC,  [invoicenum] as 'Factura #', [date] as Fecha, [nif] as NIF, [ncf] as NCF, [totalitbis] as ITBIS, [totalvalue] as Valor, [recby] as 'By' FROM [SOFiaT].[dbo].[recinvoice]";
            c.load_dgv(dgv, query);

            gbinvoiceview.Show();
            gbinvoicedata.Hide();
            rbtncode.Checked = true;
            dtpdatese.Visible = false;
        }

        private void btnaction_Click(object sender, EventArgs e)
        {
        }

        private void cbproducts_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
        }
        private void reload()
        {
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void entryinvoice_Activated(object sender, EventArgs e)
        {
            if (dtpdatese.Checked == true)
            {
                dtpdatese.Visible = true;
                txtsearch.Visible = false;
            }
            else
            {
                dtpdatese.Visible = false;
                txtsearch.Visible = true;
            }
        }

        private void rbtndate_CheckedChanged(object sender, EventArgs e)
        {
            if (dtpdatese.Checked == true)
            {
                dtpdatese.Visible = true;
                txtsearch.Visible = false;
            }
            else
            {
                dtpdatese.Visible = false;
                txtsearch.Visible = true;
            }
        }

        private void rbtnprod_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtncodeprod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtncode_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpdatese_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
        }

        private void cbproducts_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rbtninvoicenum_CheckedChanged(object sender, EventArgs e)
        {

            dtpdatese.Visible = false;
            txtsearch.Visible = true;

            string query = "SELECT TOP 1000 [idrecinvoice] as IDrecInvoice ,[supplier] as Suplidor, [rncsupplier] as RNC,  [invoicenum] as 'Factura #', [date] as Fecha, [nif] as NIF, [ncf] as NCF, [totalitbis] as ITBIS, [totalvalue] as Valor, [recby] as 'By' FROM [SOFiaT].[dbo].[recinvoice]";
            c.load_dgv(dgv, query);
        }

        private void rbtnnif_CheckedChanged(object sender, EventArgs e)
        {

            dtpdatese.Visible = false;
            txtsearch.Visible = true;

            string query = "SELECT TOP 1000 [idrecinvoice] as IDrecInvoice ,[supplier] as Suplidor, [rncsupplier] as RNC,  [invoicenum] as 'Factura #', [date] as Fecha, [nif] as NIF, [ncf] as NCF, [totalitbis] as ITBIS, [totalvalue] as Valor, [recby] as 'By' FROM [SOFiaT].[dbo].[recinvoice]";
            c.load_dgv(dgv, query);
        }

        private void rbtnncf_CheckedChanged(object sender, EventArgs e)
        {

            dtpdatese.Visible = false;
            txtsearch.Visible = true;

            string query = "SELECT TOP 1000 [idrecinvoice] as IDrecInvoice ,[supplier] as Suplidor, [rncsupplier] as RNC,  [invoicenum] as 'Factura #', [date] as Fecha, [nif] as NIF, [ncf] as NCF, [totalitbis] as ITBIS, [totalvalue] as Valor, [recby] as 'By' FROM [SOFiaT].[dbo].[recinvoice]";
            c.load_dgv(dgv, query);
        }

        private void rbtnby_CheckedChanged(object sender, EventArgs e)
        {

            dtpdatese.Visible = false;
            txtsearch.Visible = true;

            string query = "SELECT TOP 1000 [idrecinvoice] as IDrecInvoice ,[supplier] as Suplidor, [rncsupplier] as RNC,  [invoicenum] as 'Factura #', [date] as Fecha, [nif] as NIF, [ncf] as NCF, [totalitbis] as ITBIS, [totalvalue] as Valor, [recby] as 'By' FROM [SOFiaT].[dbo].[recinvoice]";
            c.load_dgv(dgv, query);
        }

        private void agregarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbinvoiceview.Hide();
            gbinvoicedata.Show();
        }

        private void visorDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadview();
        }

        private void gbinvoiceview_Enter(object sender, EventArgs e)
        {

        }
    }
}
