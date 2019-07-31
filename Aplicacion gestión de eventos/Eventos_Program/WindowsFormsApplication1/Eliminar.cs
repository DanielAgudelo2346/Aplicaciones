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
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Eliminar : MetroFramework.Forms.MetroForm
    {
        string usuario;
        string correo;
        string nombre;
        string id;
        string casa;
        string usucliente;
        public Eliminar(string usu)
        {
            InitializeComponent();
            usuario = usu;
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
        private void Eliminar_Load(object sender, EventArgs e)
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MetroFramework.MetroMessageBox.Show(this, "\n\n¿ Esta seguro de cancelar el evento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dg == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
                con.Open();
                SqlCommand consulta = new SqlCommand("SELECT * FROM tblogin WHERE CasaDeEvento LIKE '%" + casa + "%'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(consulta);
                DataTable dt1 = new DataTable();
                
                SqlDataReader dr = consulta.ExecuteReader();
                while (dr.Read())
                {
                    
                    

                    //{
                    try
                    {
                        SqlConnection conn1 = new SqlConnection();
                        SqlCommand command = new SqlCommand();
                        DataTable dt = new DataTable();
                        conn1.ConnectionString = @"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True";
                        command.Connection = conn1;

                        command.CommandText = "Delete from tbeventos where Id='" + id + "';";
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);

                        rellenar();
                        correo = dr["Correo"].ToString();
                       



                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("daag2346@gmail.com");
                        msg.To.Add(correo);
                        msg.Subject = "cancelación de evento";
                        msg.Body = "Su evento de ID: " + id + " ha sido cancelado";
                        SmtpClient sc = new SmtpClient("smtp.gmail.com");
                        sc.Port = 587;
                        sc.Credentials = new NetworkCredential("daag2346@gmail.com", "trollface52");
                        sc.EnableSsl = true;
                        sc.Send(msg);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //}
                }
                MetroFramework.MetroMessageBox.Show(this, "\n\n su evento de id " + id + " ha sido eliminado, hemos enviado un correo a los administradores de la casa del evento  ", "Evento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dg == DialogResult.No)

            {

            }
        }
   
        private void metroGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow != null && metroGrid1.CurrentRow.Index > -1)
            {
                id = metroGrid1.CurrentRow.Cells[0].Value != null ? metroGrid1.CurrentRow.Cells[0].Value.ToString() : "";
                casa = metroGrid1.CurrentRow.Cells[4].Value != null ? metroGrid1.CurrentRow.Cells[4].Value.ToString() : "";



            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menucliente b = new Menucliente(usuario);
            b.Show();
            this.Hide();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
