namespace _01VentanaEmergente
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
            this.miBotoncito = new System.Windows.Forms.Button();
            this.btnDirecto = new System.Windows.Forms.Button();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // miBotoncito
            // 
            this.miBotoncito.BackColor = System.Drawing.Color.Navy;
            this.miBotoncito.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miBotoncito.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.miBotoncito.Location = new System.Drawing.Point(22, 38);
            this.miBotoncito.Name = "miBotoncito";
            this.miBotoncito.Size = new System.Drawing.Size(230, 80);
            this.miBotoncito.TabIndex = 0;
            this.miBotoncito.Text = "Presione aqui";
            this.miBotoncito.UseVisualStyleBackColor = false;
            this.miBotoncito.Click += new System.EventHandler(this.miBotoncito_Click);
            // 
            // btnDirecto
            // 
            this.btnDirecto.BackColor = System.Drawing.Color.Navy;
            this.btnDirecto.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirecto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDirecto.Location = new System.Drawing.Point(289, 38);
            this.btnDirecto.Name = "btnDirecto";
            this.btnDirecto.Size = new System.Drawing.Size(230, 80);
            this.btnDirecto.TabIndex = 1;
            this.btnDirecto.Text = "Mensaje Directo";
            this.btnDirecto.UseVisualStyleBackColor = false;
            this.btnDirecto.Click += new System.EventHandler(this.btnDirecto_Click);
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.Navy;
            this.btnCaptura.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCaptura.Location = new System.Drawing.Point(168, 164);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(230, 80);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Captura de boton";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 357);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.btnDirecto);
            this.Controls.Add(this.miBotoncito);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button miBotoncito;
        private System.Windows.Forms.Button btnDirecto;
        private System.Windows.Forms.Button btnCaptura;
    }
}

