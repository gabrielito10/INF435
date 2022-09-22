namespace _09Practica
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.chkRojo = new System.Windows.Forms.CheckBox();
            this.chkAmarillo = new System.Windows.Forms.CheckBox();
            this.chkVerde = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "VARON",
            "MUJER"});
            this.cmbGenero.Location = new System.Drawing.Point(41, 47);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Location = new System.Drawing.Point(263, 23);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(55, 17);
            this.chkRojo.TabIndex = 1;
            this.chkRojo.Text = "ROJO";
            this.chkRojo.UseVisualStyleBackColor = true;
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Location = new System.Drawing.Point(263, 53);
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.Size = new System.Drawing.Size(80, 17);
            this.chkAmarillo.TabIndex = 2;
            this.chkAmarillo.Text = "AMARILLO";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            // 
            // chkVerde
            // 
            this.chkVerde.AutoSize = true;
            this.chkVerde.Location = new System.Drawing.Point(263, 85);
            this.chkVerde.Name = "chkVerde";
            this.chkVerde.Size = new System.Drawing.Size(63, 17);
            this.chkVerde.TabIndex = 3;
            this.chkVerde.Text = "VERDE";
            this.chkVerde.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(155, 125);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 197);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chkVerde);
            this.Controls.Add(this.chkAmarillo);
            this.Controls.Add(this.chkRojo);
            this.Controls.Add(this.cmbGenero);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.CheckBox chkRojo;
        private System.Windows.Forms.CheckBox chkAmarillo;
        private System.Windows.Forms.CheckBox chkVerde;
        private System.Windows.Forms.Button btnMostrar;
    }
}