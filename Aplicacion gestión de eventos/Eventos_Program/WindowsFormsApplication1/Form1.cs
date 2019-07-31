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
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string nick, nombre, contra, contra1, correo;

        public Form1()
        {
            InitializeComponent();
        }
        private bool existe()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM tblogin 
                                        WHERE Usuario=@uname and 
                                        Contraseña=@pass", conn);
            cmd.Parameters.AddWithValue("@uname", txtnombre.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);
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
        private bool existe1()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5OEO849\SQLEXPRESS;Initial Catalog=ElectivaProg;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM tblogin1
                                        WHERE Usuario=@uname and 
                                        Contraseña=@pass", conn);
            cmd.Parameters.AddWithValue("@uname", txtnombre.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);
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
        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar= '*';
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //metroGrid1.
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string d = txtnombre.Text.ToString();
            existe();
            existe1();
            if (existe() == true)
            {

                Menuadmin n = new Menuadmin(d);
                MetroFramework.MetroMessageBox.Show(this, "\n\nPor favor Disfrute su Estadia :)", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                n.Show();
                this.Hide();



                //this.Hide();
                //Menuadmin sistema = new Menuadmin();
                //sistema.ShowDialog();
                //this.Close();

            }
            else if(existe1() == true){
                Menucliente n = new Menucliente(d);
                MetroFramework.MetroMessageBox.Show(this, "\n\nPor favor Disfrute su Estadia :)", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                n.Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nRegistro fallido", "usuario o clave incorrectos");

            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Registro fui = new Registro(nick,nombre,contra,contra1,correo );
            fui.Show();
            this.Hide();
        }
    }
}
