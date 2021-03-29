
namespace Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonuno = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.bouttonAltoTotal = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            this.lablRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonuno
            // 
            this.botonuno.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonuno.Location = new System.Drawing.Point(47, 84);
            this.botonuno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonuno.Name = "botonuno";
            this.botonuno.Size = new System.Drawing.Size(133, 36);
            this.botonuno.TabIndex = 0;
            this.botonuno.Text = "Crear carro ";
            this.botonuno.UseVisualStyleBackColor = false;
            this.botonuno.Click += new System.EventHandler(this.botonuno_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Gold;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.Color.Black;
            this.Estado.Location = new System.Drawing.Point(294, 32);
            this.Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(0, 29);
            this.Estado.TabIndex = 1;
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Crimson;
            this.buttonEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.Location = new System.Drawing.Point(47, 144);
            this.buttonEncender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(133, 34);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender el carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.Cyan;
            this.buttonAcelerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.Location = new System.Drawing.Point(47, 209);
            this.buttonAcelerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(133, 46);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.BackColor = System.Drawing.Color.Gold;
            this.labelEstadoVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(716, 117);
            this.labelEstadoVelocidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(0, 29);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Click += new System.EventHandler(this.labelEstadoVelocidad_Click);
            // 
            // buttonBMW
            // 
            this.buttonBMW.BackColor = System.Drawing.Color.Coral;
            this.buttonBMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBMW.Location = new System.Drawing.Point(47, 32);
            this.buttonBMW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(133, 35);
            this.buttonBMW.TabIndex = 5;
            this.buttonBMW.Text = "Audi R8";
            this.buttonBMW.UseVisualStyleBackColor = false;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // bouttonAltoTotal
            // 
            this.bouttonAltoTotal.BackColor = System.Drawing.Color.DarkOrange;
            this.bouttonAltoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouttonAltoTotal.Location = new System.Drawing.Point(47, 296);
            this.bouttonAltoTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bouttonAltoTotal.Name = "bouttonAltoTotal";
            this.bouttonAltoTotal.Size = new System.Drawing.Size(133, 40);
            this.bouttonAltoTotal.TabIndex = 6;
            this.bouttonAltoTotal.Text = "Freno";
            this.bouttonAltoTotal.UseVisualStyleBackColor = false;
            this.bouttonAltoTotal.Click += new System.EventHandler(this.bouttonAltoTotal_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(265, 197);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(287, 139);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // btncargar
            // 
            this.btncargar.BackColor = System.Drawing.Color.DarkOrange;
            this.btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.Location = new System.Drawing.Point(247, 446);
            this.btncargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(149, 59);
            this.btncargar.TabIndex = 8;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.BackColor = System.Drawing.Color.Cyan;
            this.btnreproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreproducir.Location = new System.Drawing.Point(438, 446);
            this.btnreproducir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(132, 59);
            this.btnreproducir.TabIndex = 9;
            this.btnreproducir.Text = "Reproducir";
            this.btnreproducir.UseVisualStyleBackColor = false;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnparar
            // 
            this.btnparar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparar.Location = new System.Drawing.Point(738, 446);
            this.btnparar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(119, 59);
            this.btnparar.TabIndex = 10;
            this.btnparar.Text = "Parar";
            this.btnparar.UseVisualStyleBackColor = false;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnpausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpausa.Location = new System.Drawing.Point(601, 446);
            this.btnpausa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(115, 59);
            this.btnpausa.TabIndex = 11;
            this.btnpausa.Text = "Pausa";
            this.btnpausa.UseVisualStyleBackColor = false;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // lablRuta
            // 
            this.lablRuta.AutoSize = true;
            this.lablRuta.Location = new System.Drawing.Point(473, 446);
            this.lablRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lablRuta.Name = "lablRuta";
            this.lablRuta.Size = new System.Drawing.Size(0, 17);
            this.lablRuta.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(842, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lablRuta);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnreproducir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.bouttonAltoTotal);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.botonuno);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonuno;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button bouttonAltoTotal;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnpausa;
        private System.Windows.Forms.Label lablRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

