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
    public partial class inventoryproduct : Form
    {
        DBManager c = new DBManager();
        public inventoryproduct()
        {
            InitializeComponent();
        }

        private void inventoryproduct_Load(object sender, EventArgs e)
        {
            rbtnall.Checked = true;
            string query = "SELECT [idproduct], [name], [description], [unid], [cost], [saleprice], [supplier] FROM [SOFiaT].[dbo].[products] where [idproduct] = '" + txtidproduct.Text + "'";
            c.fill_txt(txtnameprod, query, "name");
            c.fill_txt(txtdescprod, query, "description");
            c.fill_txt(txtuniprod, query, "unid");
            c.fill_txt(txtcostprod, query, "cost");
            c.fill_txt(txtsalepriceprod, query, "saleprice");

            query = "SELECT i.[idtrans] as 'IDTransacción', i.[idproduct] as 'IDProducto', p.[name] as Producto, [entryqty] as 'Entrada', [outqty] as 'Salida', p.[unid] as Unidad, [inventorycost] as 'Costo', [ref] as 'Referencia', [datetrans] as 'Fecha', [coment] as 'Comentario', [typetrans] as 'Tipo' FROM [SOFiaT].[dbo].[inventory] as i, [SOFiaT].[dbo].[products] as p where i.[idproduct] = p.[idproduct] and i.[idproduct] = '" + txtidproduct.Text + "'";
            c.load_dgv(dataGridView1, query);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
