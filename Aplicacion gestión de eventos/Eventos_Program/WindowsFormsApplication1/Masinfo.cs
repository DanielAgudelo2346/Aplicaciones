using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Masinfo : MetroFramework.Forms.MetroForm
    {
        string casa;
        public Masinfo(string cas)
        {
            InitializeComponent();
            casa = cas;
        }

        private void Masinfo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'electivaProgDataSet.tbeventos' Puede moverla o quitarla según sea necesario.
       
            
            var consulta = "select NombreCasa,MaximoPersonas,Dirección,Telefono,Dimensiones from tbcasas where NombreCasa ='" + casa + "';";
            var c = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True"); // Tu String de conexión
            var adaptador = new SqlDataAdapter(consulta, c);

            var commandBuilder = new SqlCommandBuilder(adaptador);
            var ds = new DataSet();
            adaptador.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];
            metroGrid1.AutoResizeColumns();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
