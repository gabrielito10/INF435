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
            this.btnCorto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMensaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMensaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMensaje.Location = new System.Drawing.Point(179, 142);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(232, 67);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Mostrar Mensaje";
            this.btnMensaje.UseVisualStyleBackColor = false;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnCorto
            // 
            this.btnCorto.Location = new System.Drawing.Point(209, 248);
            this.btnCorto.Name = "btnCorto";
            this.btnCorto.Size = new System.Drawing.Size(181, 49);
            this.btnCorto.TabIndex = 1;
            this.btnCorto.Text = "Mensaje Corto";
            this.btnCorto.UseVisualStyleBackColor = true;
            this.btnCorto.Click += new System.EventHandler(this.btnCorto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCorto);
            this.Controls.Add(this.btnMensaje);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Button btnCorto;
    }
}

