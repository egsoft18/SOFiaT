using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SOFiaT
{
    public partial class homeform : Form
    {
        DBManager c = new DBManager();
        public homeform()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void homeform_Activated(object sender, EventArgs e)
        {
        }

        private void homeform_Load(object sender, EventArgs e)
        {
            string query = "select top 1 [idlogin],[user],[usertype],[[date] from [actualuser] order by idlogin desc";
            c.fill_txt(txtactualuser, query, "user");
            //string query1 = "select usertype from userpass"
            //c.fill_txt(txtprivileges, query, "usertype");
        }
        private void btnhide_Click(object sender, EventArgs e)
        {
            if (verticalmenu.Width == 200)
            {
                verticalmenu.Width = 70;
            }
            else
            {
                verticalmenu.Width = 200;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            login_frm frm = new login_frm();
            frm.Show();
            this.Close();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrest.Visible = true;
            btnmax.Visible = false;
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrest.Visible = false;
            btnmax.Visible = true;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
