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
            string query = "select idbillrec as Code, p.idproduct as 'Code Producto', p.name as Producto, qty as 'Cant.', unit as Unidad, billref as 'Ref.', billdate as Fecha, br.supplier as Suplidor, comment as Comentario from billrec as br, products as p where br.idproduct = p.idproduct ";
            c.load_dgv(dataGridView1, query);

            btnaction.Text = "Agregar";

        }
    }
}
