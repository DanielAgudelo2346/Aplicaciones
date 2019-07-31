namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtcontra = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtnombre = new MetroFramework.Controls.MetroTextBox();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtcontra
            // 
            this.txtcontra.AutoSize = true;
            this.txtcontra.Location = new System.Drawing.Point(16, 342);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(75, 19);
            this.txtcontra.TabIndex = 8;
            this.txtcontra.Text = "Contraseña";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 256);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Usuario";
            // 
            // txtnombre
            // 
            // 
            // 
            // 
            this.txtnombre.CustomButton.Image = null;
            this.txtnombre.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtnombre.CustomButton.Name = "";
            this.txtnombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnombre.CustomButton.TabIndex = 1;
            this.txtnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnombre.CustomButton.UseSelectable = true;
            this.txtnombre.CustomButton.Visible = false;
            this.txtnombre.Lines = new string[0];
            this.txtnombre.Location = new System.Drawing.Point(16, 293);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.ShortcutsEnabled = true;
            this.txtnombre.Size = new System.Drawing.Size(298, 23);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.UseSelectable = true;
            this.txtnombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.CustomButton.Image = null;
            this.txtpass.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtpass.CustomButton.Name = "";
            this.txtpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpass.CustomButton.TabIndex = 1;
            this.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpass.CustomButton.UseSelectable = true;
            this.txtpass.CustomButton.Visible = false;
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(16, 381);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(298, 23);
            this.txtpass.TabIndex = 11;
            this.txtpass.UseSelectable = true;
            this.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(131, 425);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Ingresar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(78, 466);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(182, 23);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.Text = "¿No tienes cuenta? Click Aqui!!";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.LIL;
            this.pictureBox1.Location = new System.Drawing.Point(78, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 180);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(337, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtcontra);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Inicia Sesión";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel txtcontra;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtpass;
        private MetroFramework.Controls.MetroTextBox txtnombre;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

