﻿using System;
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
            string query = "select idbillrec as Code, p.idproduct as 'Code Producto', p.name as Producto, qty as 'Cant.', unit as Unidad, br.cost as 'Costo total', billref as 'Ref.', billdate as Fecha, br.supplier as Suplidor, comment as Comentario from billrec as br, products as p where br.idproduct = p.idproduct ";
            c.load_dgv(dgv, query);

            btnaction.Text = "Agregar";

            query = "select name from products";
            c.fill_CB(cbproducts, query, "name");
        }

        private void btnaction_Click(object sender, EventArgs e)
        {
            if (btnaction.Text == "Agregar")
            {
                string query = "Insert Into billrec([idproduct], [qty], [unit], [cost], [billref],[billdate],[supplier],[comment]) values('" + txtcodeprod.Text + "', '" + txtqty.Text + "','" + txtunid.Text + "', '" + txttotalcost.Text + "', '" + txtref.Text + "','" + dtpdate.Text + "','" + txtsupplier.Text + "','" + txtcomentary.Text + "')";
                c.command(query);
                reload();
            }
            else if (btnaction.Text == "Actualizar")
            {
                string query = "Update billrec set [idproduct] = '" + txtcodeprod.Text + "', [qty] = '" + txtqty.Text + "', [unit] = '" + txtunid.Text + "', [cost] = '" + txttotalcost.Text + "', [billref] = '" + txtref.Text + "',[billdate] = '" + dtpdate.Text + "',[supplier] = '" + txtsupplier.Text + "',[comment] = '" + txtcomentary.Text + "' where [idbillrec] = '" + txtbillcode.Text + "'";
                c.command(query);
                reload();
            }
        }

        private void cbproducts_TextChanged(object sender, EventArgs e)
        {
            string query = "select idproduct, cost from products where name = '" + cbproducts.Text + "'";
            c.fill_txt(txtcodeprod, query, "idproduct");
            c.fill_txt(txtcost, query, "cost");
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
            if (txtqty.Text.Length > 0 && txtcost.Text.Length > 0)
            {
            txttotalcost.Text = (Convert.ToDecimal(txtcost.Text) * Convert.ToDecimal(txtqty.Text)).ToString();
            }
        }
        private void reload()
        {
            string query = "select idbillrec as Code, p.idproduct as 'Code Producto', p.name as Producto, qty as 'Cant.', unit as Unidad, br.cost as 'Costo total', billref as 'Ref.', billdate as Fecha, br.supplier as Suplidor, comment as Comentario from billrec as br, products as p where br.idproduct = p.idproduct ";
            c.load_dgv(dgv, query);

            btnaction.Text = "Agregar";

            txtbillcode.Clear();
            txtcodeprod.Clear();
            txtcomentary.Clear();
            txtcost.Clear();
            txtqty.Clear();
            txtref.Clear();
            txtsupplier.Clear();
            txttotalcost.Clear();
            txtunid.Clear();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbillcode.Text = dgv.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            txtcodeprod.Text = dgv.Rows[e.RowIndex].Cells["Code Producto"].Value.ToString();
            txtcomentary.Text = dgv.Rows[e.RowIndex].Cells["Comentario"].Value.ToString();
            txtcost.Clear();
            txtqty.Text = dgv.Rows[e.RowIndex].Cells["Cant."].Value.ToString();
            txtref.Text = dgv.Rows[e.RowIndex].Cells["Ref."].Value.ToString();
            txtsupplier.Text = dgv.Rows[e.RowIndex].Cells["Suplidor"].Value.ToString();
            txttotalcost.Text = dgv.Rows[e.RowIndex].Cells["Costo total"].Value.ToString();
            txtunid.Text = dgv.Rows[e.RowIndex].Cells["Unidad"].Value.ToString();
            dtpdate.Text = dgv.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            cbproducts.Text = dgv.Rows[e.RowIndex].Cells["Producto"].Value.ToString();

            btnaction.Text = "Actualizar";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
