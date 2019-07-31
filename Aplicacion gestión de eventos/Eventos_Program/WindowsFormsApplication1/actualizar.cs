using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MetroFramework.Controls;
using System.Data.SqlClient;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class actualizar : MetroFramework.Forms.MetroForm
    {
        string usuario;
        public actualizar(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }
        string nombre;
        string horario;
        string fecha;
        string lugar;

        private void menores1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmnd = con.CreateCommand();

            cmnd.CommandText = "Select NombreCasa from tbcasas where MaximoPersonas<=100 and MaximoPersonas>11 ";

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
        private void menores2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmnd = con.CreateCommand();

            cmnd.CommandText = "Select NombreCasa from tbcasas where MaximoPersonas <=500 and MaximoPersonas>=101 ";

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
        private void menores3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmnd = con.CreateCommand();

            cmnd.CommandText = "Select NombreCasa from tbcasas where MaximoPersonas<=1000 and MaximoPersonas>=501 ";

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
        private bool existe1()
        {
            string selected = this.metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem);
            fecha = metroDateTime1.Value.ToString("yyyy-MM-dd");
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM tbeventos
                                        WHERE FechaEvento=@fecha and 
                                        Lugar=@lugar and Horario=@horario", conn);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@lugar", selected);
            cmd.Parameters.AddWithValue("@horario", horario);
            int result = (int)cmd.ExecuteScalar();
            conn.Close();
            if (result >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        private void rellenar()
        {
            // TODO: esta línea de código carga datos en la tabla 'electivaProgDataSet.tbeventos' Puede moverla o quitarla según sea necesario.
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblogin1 where Usuario='" + usuario + "'", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                nombre = dr["Nombre"].ToString();
            }
            var consulta = "select Id,FechaEvento,NumeroInvitados,NombreCliente,Lugar,NumeroCocineros,NumeroMeseros,Horario from tbeventos where Usuario ='" + usuario + "';";
            var c = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True"); // Tu String de conexión
            var adaptador = new SqlDataAdapter(consulta, c);

            var commandBuilder = new SqlCommandBuilder(adaptador);
            var ds = new DataSet();
            adaptador.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];
            metroGrid1.AutoResizeColumns();
        }
        private void actualizar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'electivaProgDataSet.tbeventos' Puede moverla o quitarla según sea necesario.
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblogin1 where Usuario='" + usuario + "'", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                nombre = dr["Nombre"].ToString();
            }
            var consulta = "select Id,FechaEvento,NumeroInvitados,NombreCliente,Lugar,NumeroCocineros,NumeroMeseros,Horario from tbeventos where Usuario ='" + usuario + "';";
            var c = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True"); // Tu String de conexión
            var adaptador = new SqlDataAdapter(consulta, c);

            var commandBuilder = new SqlCommandBuilder(adaptador);
            var ds = new DataSet();
            adaptador.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void metroGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow != null && metroGrid1.CurrentRow.Index > -1)
            {
                string value1 = metroGrid1.CurrentRow.Cells[0].Value != null ? metroGrid1.CurrentRow.Cells[0].Value.ToString() : "";
                txtid.Text = value1;

                string value2 = metroGrid1.CurrentRow.Cells[1].Value != null ? metroGrid1.CurrentRow.Cells[1].Value.ToString() : "";
               

                string value3 = metroGrid1.CurrentRow.Cells[4].Value != null ? metroGrid1.CurrentRow.Cells[4].Value.ToString() : "";
               

                

                string numin = metroGrid1.CurrentRow.Cells[2].Value != null ? metroGrid1.CurrentRow.Cells[2].Value.ToString() : "";
                
                int invitados = Int32.Parse(numin);


                if (invitados > 10 && invitados <= 100)
                    {
                    menores1();
                    }
                    else if (invitados >= 101 && invitados < 500)
                    {
                    menores2();
                    }
                    else if (invitados >= 501 && invitados < 1000)
                    {
                    menores3();
                    }
                


            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(metroGrid1.CurrentRow.Cells[2].Value != null ? metroGrid1.CurrentRow.Cells[2].Value.ToString() : "");
            string selected = this.metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem);
            
            fecha = metroDateTime1.Value.ToString("yyyy-MM-dd");
          

            existe1();
            if (existe1() == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nPor favor seleccione un lugar,fecha u horario diferente", "Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                try
                {

                    SqlConnection conn = new SqlConnection();
                    SqlCommand command = new SqlCommand();
                    DataTable dt = new DataTable();
                    conn.ConnectionString = @"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True";
                    command.Connection = conn;

                    command.CommandText = "UPDATE tbeventos SET FechaEvento='" + fecha + "', Lugar='" + selected + "', Horario='" + horario + "'WHERE Id='" + txtid.Text +"';";
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    MetroFramework.MetroMessageBox.Show(this, "\n\nLos datos de un evento han sido cambiados", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    rellenar();
                    

                }
                catch (SqlException n)
                {
                    MessageBox.Show(n.Message);
                }
            }

        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
            horario = "Diurno(7:00AM-4:00PM)";
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            horario = "Nocturno(6:30PM-12:00PM)";
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menucliente n = new Menucliente(usuario);
            n.Show();
            this.Hide();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
