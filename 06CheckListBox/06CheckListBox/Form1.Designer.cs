namespace _06CheckListBox
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
            this.lstColores = new System.Windows.Forms.CheckedListBox();
            this.lstSeleccionados = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Items.AddRange(new object[] {
            "ROJO",
            "AMARILLO",
            "VERDE",
            "AZUL",
            "CAFE",
            "NARANJA",
            "BLANCO",
            "NEGRO",
            "GRIS",
            "CELESTE",
            "VIOLETA"});
            this.lstColores.Location = new System.Drawing.Point(58, 60);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(120, 169);
            this.lstColores.TabIndex = 0;
            // 
            // lstSeleccionados
            // 
            this.lstSeleccionados.FormattingEnabled = true;
            this.lstSeleccionados.Location = new System.Drawing.Point(312, 64);
            this.lstSeleccionados.Name = "lstSeleccionados";
            this.lstSeleccionados.Size = new System.Drawing.Size(120, 160);
            this.lstSeleccionados.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(189, 129);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(112, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR >>>";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lstSeleccionados);
            this.Controls.Add(this.lstColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstColores;
        private System.Windows.Forms.ListBox lstSeleccionados;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
    }
}

