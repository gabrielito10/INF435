namespace _01Ventanas_Emergentes
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
            this.btnMensaje = new System.Windows.Forms.Button();
            this.btnPersonalizada = new System.Windows.Forms.Button();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.BackColor = System.Drawing.Color.Red;
            this.btnMensaje.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensaje.ForeColor = System.Drawing.Color.White;
            this.btnMensaje.Location = new System.Drawing.Point(74, 41);
            this.btnMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(359, 70);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Ventana Emergente solo mensaje";
            this.btnMensaje.UseVisualStyleBackColor = false;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnPersonalizada
            // 
            this.btnPersonalizada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPersonalizada.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalizada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonalizada.Location = new System.Drawing.Point(74, 118);
            this.btnPersonalizada.Name = "btnPersonalizada";
            this.btnPersonalizada.Size = new System.Drawing.Size(359, 60);
            this.btnPersonalizada.TabIndex = 1;
            this.btnPersonalizada.Text = "Ventana Emergente Personalizada";
            this.btnPersonalizada.UseVisualStyleBackColor = false;
            this.btnPersonalizada.Click += new System.EventHandler(this.btnPersonalizada_Click);
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.Location = new System.Drawing.Point(74, 184);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(359, 58);
            this.btnRespuesta.TabIndex = 2;
            this.btnRespuesta.Text = "Ventana Emergente con Respuesta";
            this.btnRespuesta.UseVisualStyleBackColor = true;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(486, 269);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.btnPersonalizada);
            this.Controls.Add(this.btnMensaje);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Alone On Earth", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAMACION IV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Button btnPersonalizada;
        private System.Windows.Forms.Button btnRespuesta;
    }
}

