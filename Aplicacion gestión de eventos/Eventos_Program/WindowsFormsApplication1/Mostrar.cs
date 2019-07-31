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

namespace WindowsFormsApplication1
{
    public partial class Mostrar : MetroFramework.Forms.MetroForm
    {
        string usuario;
        public Mostrar(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }
        string nombre;
        private void Mostrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'electivaProgDataSet.tbeventos' Puede moverla o quitarla según sea necesario.
            this.tbeventosTableAdapter.Fill(this.electivaProgDataSet.tbeventos);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblogin1 where Usuario='" + usuario + "'", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                 nombre = dr["Nombre"].ToString();
            }
            var consulta = "select Id,FechaEvento,NumeroInvitados,NombreCliente,Lugar,NumeroCocineros,NumeroMeseros,Horario from tbeventos where Usuario ='" + usuario+"';";
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
            Menucliente t = new Menucliente(usuario);
            t.Show();         
            this.Hide();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menucliente n = new Menucliente(usuario);
            n.Show();
            this.Hide();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
