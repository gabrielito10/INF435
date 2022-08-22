namespace _01Ventanas_Emergente
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
            this.btnPregunta = new System.Windows.Forms.Button();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregunta
            // 
            this.btnPregunta.BackColor = System.Drawing.Color.Yellow;
            this.btnPregunta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregunta.ForeColor = System.Drawing.Color.Maroon;
            this.btnPregunta.Location = new System.Drawing.Point(97, 36);
            this.btnPregunta.Name = "btnPregunta";
            this.btnPregunta.Size = new System.Drawing.Size(204, 54);
            this.btnPregunta.TabIndex = 0;
            this.btnPregunta.Text = "MOSTRAR PREGUNTA";
            this.btnPregunta.UseVisualStyleBackColor = false;
            this.btnPregunta.Click += new System.EventHandler(this.btnPregunta_Click);
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(121, 140);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(158, 46);
            this.btnMensaje.TabIndex = 1;
            this.btnMensaje.Text = "MOSTRAR MENSAJE";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(4)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(402, 254);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.btnPregunta);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programacion IV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregunta;
        private System.Windows.Forms.Button btnMensaje;
    }
}

