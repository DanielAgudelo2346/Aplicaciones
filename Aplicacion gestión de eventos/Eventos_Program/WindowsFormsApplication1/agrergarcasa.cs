using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class agrergarcasa : MetroFramework.Forms.MetroForm
    {
        string usuario;
        string[] partes;
        string lugares ;
        public agrergarcasa(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }
        private bool supera()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblogin where Usuario='" + usuario + "'", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string lugar = dr["CasaDeEvento"].ToString();
                 partes = lugar.Split('-');

                
            }
            if (partes.Length >= 5)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private bool yaesta()
        {
            string selected = this.metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            con.Open();
            SqlCommand m = new SqlCommand(@"SELECT Count(*) FROM tblogin
                                        WHERE CasaDeEvento LIKE '%" + selected + "%'and Usuario='" + usuario + "'", con);
            int result = (int)m.ExecuteScalar();
            if (result >= 1)
                
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private void agrergarcasa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmnd = con.CreateCommand();

            cmnd.CommandText = "Select NombreCasa from tbcasas";

            con.Open();
            SqlDataReader rd = cmnd.ExecuteReader();
            metroComboBox1.Items.Clear();
            while (rd.Read())
            {
                string someFieldText = rd[0].ToString();

                metroComboBox1.Items.Add(someFieldText);
            }

            con.Close();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            RegistroCasan n = new RegistroCasan(usuario);
            n.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            supera();
            yaesta();
            if (supera() == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n Hay un Límite de administrar 5 casas por cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (yaesta() == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n Usted ya es administrador de la casa seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                try
                {

                    SqlConnection conn = new SqlConnection();
                    SqlCommand command = new SqlCommand();
                    DataTable dt = new DataTable();
                    conn.ConnectionString = @"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True";
                    command.Connection = conn;
                    string selected = this.metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem);

                    command.CommandText = "UPDATE tblogin SET CasaDeEvento=CasaDeEvento+'-'+'" + selected + "'WHERE Usuario='" + usuario + "';";
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    MetroFramework.MetroMessageBox.Show(this, "\n\nSe ha agregado Una nueva Casa", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);




                }
                catch (SqlException n)
                {
                    MessageBox.Show(n.Message);
                }
            }



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menuadmin n = new Menuadmin(usuario);
            n.Show();
            this.Hide();
        }
    }
}
