using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menuadmin : MetroFramework.Forms.MetroForm
    {
        string usu;
        public Menuadmin(string c)
        {
            InitializeComponent();
            usu = c;
        }

        private void Menuadmin_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Veradmin n = new Veradmin(usu);
            n.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); 
            f.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            agrergarcasa n = new agrergarcasa(usu);
            n.Show();
            this.Hide();
        }

        private void metroTile3_MouseEnter(object sender, EventArgs e)
        {
            metroTile3.BackColor = Color.Goldenrod;
        }

        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            metroTile3.BackColor = Color.Orange;

        }

        private void metroTile4_MouseEnter(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.Goldenrod;
        }

        private void metroTile4_MouseLeave(object sender, EventArgs e)
        {
            metroTile4.BackColor = Color.Orange;
        }

        private void metroTile1_MouseEnter(object sender, EventArgs e)
        {
            metroTile1.BackColor = Color.Goldenrod;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroTile1.BackColor = Color.Orange;
             
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Eliminarad b = new Eliminarad(usu);
            b.Show();
            this.Hide();
        }
    }
}
