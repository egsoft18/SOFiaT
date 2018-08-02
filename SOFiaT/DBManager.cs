using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace SOFiaT
{
    class DBManager
    {
        //string cadena = "Data Surce=DELLPC;Initial Catalog=SysPandemic; Integrated Security=True";
        //public SqlConnection cnx = new SqlConnection();

        public string valor = "";
        public string actuser = "";

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dr;
        public DBManager()
        {
            try
            {
                //Conexion para la PC de desarrollo
                //cnx = new SqlConnection("Data Source=DESKTOP-RC55N5R;Initial Catalog=SysPandemic; Integrated Security=True; MultipleActiveResultSets=True");

                //Conexion para la pc del consultorio
                //cnx = new SqlConnection(@"Server=INOA-PC\EGSOFT;Database=SysPandemic;User Id=egsoft; Password=1234; MultipleActiveResultSets=True");

                //Conexion con red
                cnx = new SqlConnection("Server=DESKTOP-RC55N5R, 49172;Database=SOFiaT;User Id=egsoft; Password=1234; MultipleActiveResultSets=True");

                cnx.Open();
                //MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar " + ex.Message);

            }
        }
        public void cbusers(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select usu from userpass", cnx);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["usu"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);

            }
            finally
            {
            }
        }
        public void startseccion(string user, string pass)
        {
            try
            {
                cmd = new SqlCommand("Select [user], [password] from userpass where [user] = '" + user + "' and [password] = '" + pass + "'", cnx);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {

                    //MessageBoxTemporal.Show("Mensaje de prueba para karmany.NET", "Título", 22, true);
                    MessageBox.Show("Usuario o contraseña invalida, intente de nuevo.");

                }
                else
                {
                    valor = "si";
                    actuser = user;
                    //MessageBox.Show("Bienvenido a SysPandemic " + actuser);
                    //Homeform frm = new Homeform();
                    //login lfrm = new login();
                    //lfrm.Hide();
                    //frm.ShowDialog();
                    //lfrm.passtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer el login; " + ex.Message);
            }
        }
        public void command(string query)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se ha realizado la accion", "Hecho");
                    valor = "si";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message);
            }
        }
        public void load_dgv(DataGridView dgv, string query)
        {
            try
            {
                SqlDataAdapter adac = new SqlDataAdapter(query, cnx);
                DataTable tabla = new DataTable("table");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
        public void fill_CB(ComboBox cb, string query, string item)
        {
            try
            {
                cmd = new SqlCommand(query, cnx);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[item].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);

            }
            finally
            {
            }
        }
        public void last_id(TextBox ms, string query, string condition)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    decimal value = Convert.ToDecimal(leer[condition].ToString());
                    string nun = value.ToString();
                    ms.Text = nun;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No consiguio el ID. La causa: " + ex.Message);
            }
        }
        public void command3(string query)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    valor = "si";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message);
            }
        }
        public void test_printreport(string query, string tablename, string xml, string reportrpt)
        {

            try
            {
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos que imprimir.");
                }
                else
                {
                    ds.Tables[0].TableName = tablename;
                    ds.WriteXml(@"C:\SysPandemic server\xml\" + xml + "");
                    MessageBox.Show("Done");
                    //reportview rv = new reportview(reportrpt);
                    //rv.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        public void printreport(string query, string tablename, string xml, string reportrpt)
        {

            try
            {
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos que imprimir.");
                }
                else
                {
                    ds.Tables[0].TableName = tablename;
                    ds.WriteXml(@"C:\SysPandemic server\xml\" + xml + "");
                    //MessageBox.Show("Done");
                    reportview1 rv = new reportview1(reportrpt);
                    rv.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        public void fill_txt(TextBox txt, string query, string condition)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    string text = Convert.ToString(leer[condition]);
                    txt.Text = text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
        public void fill_diag(string query, ComboBox tmed_cb, TextBox tmedcom_txt, ComboBox mica_cb, TextBox micacom_txt, ComboBox ps_cb, ComboBox diab_cb, ComboBox hep_cb, TextBox hepcom_txt, ComboBox pr_cb, ComboBox pe_cb, TextBox pecom_txt, ComboBox pa_cb, TextBox pacom_txt, ComboBox hemo_cb, ComboBox aler_cb, TextBox alercom_txt)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {

                    tmed_cb.Text = Convert.ToString(leer["tmed"]);
                    tmedcom_txt.Text = Convert.ToString(leer["tmedcom"]);
                    mica_cb.Text = Convert.ToString(leer["mica"]);
                    micacom_txt.Text = Convert.ToString(leer["micacom"]);
                    ps_cb.Text = Convert.ToString(leer["ps"]);
                    diab_cb.Text = Convert.ToString(leer["diab"]);
                    hep_cb.Text = Convert.ToString(leer["hep"]);
                    hepcom_txt.Text = Convert.ToString(leer["hepcom"]);
                    pr_cb.Text = Convert.ToString(leer["pr"]);
                    pe_cb.Text = Convert.ToString(leer["pe"]);
                    pecom_txt.Text = Convert.ToString(leer["pecom"]);
                    pa_cb.Text = Convert.ToString(leer["pa"]);
                    pacom_txt.Text = Convert.ToString(leer["pacom"]);
                    hemo_cb.Text = Convert.ToString(leer["hemo"]);
                    aler_cb.Text = Convert.ToString(leer["aler"]);
                    alercom_txt.Text = Convert.ToString(leer["alercom"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        public void validation(string query)
        {
            try
            {
                cmd = new SqlCommand(query, cnx);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    valor = "no";
                }
                else
                {
                    valor = "si";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo validar; " + ex.Message);
            }
        }

        
    }
}