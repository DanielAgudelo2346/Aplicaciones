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
using System.Data.SqlClient;
using MetroFramework.Controls;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Insertar : MetroFramework.Forms.MetroForm
    {
        string usuario;
        MetroCheckBox lastChecked;
        string lugar;
        string lugar1;
        string horario;
        string fecha;
            
        public Insertar(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }
        private bool existe1()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM tbeventos
                                        WHERE FechaEvento=@fecha and 
                                        Lugar=@lugar and Horario=@horario", conn);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@lugar", lugar1);
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
                metroComboBox1.SelectedIndex = 0 ;

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
                metroComboBox1.SelectedIndex = 0;

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
                metroComboBox1.SelectedIndex = 0;

            }

            con.Close();
        }
        private void Insertar_Load(object sender, EventArgs e)
        {
            txtinvitados.MaxLength = 3;
            calendario.MinDate = DateTime.Today.AddDays(5);
            calendario.MaxDate = DateTime.Today.AddMonths(12);
            txtmeseros.Visible = false;
            txtcocineros.Visible = false;
            metroRadioButton1.Visible = false;
            metroRadioButton2.Visible = false;
            Label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            metroButton8.Visible = false;
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblogin1 where Usuario='" + usuario + "'",conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                txtnombre.Text = dr["Nombre"].ToString();
            }
            txtnombre.ReadOnly = true;

        }

        private void bunifuTileButton1_MouseHover(object sender, EventArgs e)
        {
        }

        private void bunifuTileButton1_MouseLeave(object sender, EventArgs e)
        {
        }
       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            metroButton8.Visible = true;
            Label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtmeseros.Visible = true;
            txtcocineros.Visible = true;
            metroRadioButton1.Visible = true;
            metroRadioButton2.Visible = true;
            string numero = txtinvitados.ToString();
            int invitados = Int32.Parse(txtinvitados.Text);
            int nmeseros = invitados / 4;
            int ncocineros = invitados / 7;
            txtcocineros.Text = ncocineros.ToString();
            txtmeseros.Text = nmeseros.ToString();

            if(invitados >=10 && invitados <= 100)
            {
                menores1();
               
            }
            else if(invitados >=101 && invitados <= 500)
            {
                menores2();
              

            }
            else if(invitados >= 501 && invitados <= 1000)
            {
                menores3();
               
                
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

       

        private void txtcocineros_Click(object sender, EventArgs e)
        {
                    }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        

        
        private void metroButton8_Click(object sender, EventArgs e)
        {
            fecha = calendario.Value.ToString("yyyy-MM-dd");
            existe1();
            if (existe1() == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nPor favor seleccione un lugar,fecha u horario diferente", "Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                    command.CommandText = "INSERT tbeventos(FechaEvento,NumeroInvitados,NombreCliente,Lugar,NumeroCocineros,NumeroMeseros,Horario,Usuario) VALUES('" + fecha + "','" + txtinvitados.Text.ToString() + "','" + txtnombre.Text.ToString() + "','" + lugar1 + "','" + txtcocineros.Text.ToString() + "','" + txtmeseros.Text.ToString() + "','" + horario + "','"+usuario+"');";
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    MetroFramework.MetroMessageBox.Show(this, "\n\n Registro Exitoso", "su evento ha sido reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                catch (SqlException n)
                {
                    MetroFramework.MetroMessageBox.Show(this,n.Message);
                   
                }
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
            horario = "Diurno(7:00AM-4:00PM)";
        }

        private void metroRadioButton2_Click(object sender, EventArgs e)
        {
            horario = "Nocturno(6:30PM-12:00PM)";
        }

       

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            var d = new Thread(() => Application.Run(new Menucliente(usuario)));
            d.Start();
            this.Close();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menucliente n = new Menucliente(usuario);
            n.Show();
            this.Hide();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             lugar1 = this.metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbcasas where NombreCasa='" + lugar1 + "'", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                byte[] img = (byte[])dr["imagen"];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.Image = Bitmap.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            lugar1 = this.metroComboBox1.GetItemText(this.metroComboBox1.SelectedItem);

            Masinfo n = new Masinfo(lugar1);
            n.Show();
        }

        private void txtinvitados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
