using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menucliente : MetroFramework.Forms.MetroForm
    {
        string usuario;
        public Menucliente(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void Menucliente_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            actualizar n = new actualizar(usuario);
            n.Show();
            this.Hide();
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            Mostrar n = new Mostrar(usuario);
            n.Show();
            this.Hide();
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            metroTile1.BackColor = Color.Silver;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroTile1.BackColor = Color.SlateGray;

        }

        private void metroTile2_MouseHover(object sender, EventArgs e)
        {
            metroTile2.BackColor = Color.Silver;

        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            metroTile2.BackColor = Color.SlateGray;

        }

        private void metroTile3_MouseHover(object sender, EventArgs e)
        {
            metroTile3.BackColor = Color.Silver;

        }

        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            metroTile3.BackColor = Color.SlateGray;

        }

        private void metroTile4_MouseHover(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.Silver;

        }

        private void metroTile4_MouseLeave(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.SlateGray;

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            Insertar n = new Insertar(usuario);
            n.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Eliminar n = new Eliminar(usuario);
            n.Show();
            this.Hide();
        }

       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
