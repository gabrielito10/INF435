namespace _03CheckBox_y_RadioButton
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
            this.opSoltero = new System.Windows.Forms.RadioButton();
            this.opCasado = new System.Windows.Forms.RadioButton();
            this.opDivorciado = new System.Windows.Forms.RadioButton();
            this.opFutbol = new System.Windows.Forms.CheckBox();
            this.opBasquet = new System.Windows.Forms.CheckBox();
            this.opVoley = new System.Windows.Forms.CheckBox();
            this.opViudo = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnDeporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opSoltero
            // 
            this.opSoltero.AutoSize = true;
            this.opSoltero.Location = new System.Drawing.Point(31, 31);
            this.opSoltero.Name = "opSoltero";
            this.opSoltero.Size = new System.Drawing.Size(76, 17);
            this.opSoltero.TabIndex = 0;
            this.opSoltero.TabStop = true;
            this.opSoltero.Text = "SOLTERO";
            this.opSoltero.UseVisualStyleBackColor = true;
            // 
            // opCasado
            // 
            this.opCasado.AutoSize = true;
            this.opCasado.Location = new System.Drawing.Point(31, 67);
            this.opCasado.Name = "opCasado";
            this.opCasado.Size = new System.Drawing.Size(72, 17);
            this.opCasado.TabIndex = 1;
            this.opCasado.TabStop = true;
            this.opCasado.Text = "CASADO ";
            this.opCasado.UseVisualStyleBackColor = true;
            // 
            // opDivorciado
            // 
            this.opDivorciado.AutoSize = true;
            this.opDivorciado.Location = new System.Drawing.Point(31, 103);
            this.opDivorciado.Name = "opDivorciado";
            this.opDivorciado.Size = new System.Drawing.Size(92, 17);
            this.opDivorciado.TabIndex = 2;
            this.opDivorciado.TabStop = true;
            this.opDivorciado.Text = "DIVORCIADO";
            this.opDivorciado.UseVisualStyleBackColor = true;
            // 
            // opFutbol
            // 
            this.opFutbol.AutoSize = true;
            this.opFutbol.Location = new System.Drawing.Point(201, 31);
            this.opFutbol.Name = "opFutbol";
            this.opFutbol.Size = new System.Drawing.Size(71, 17);
            this.opFutbol.TabIndex = 3;
            this.opFutbol.Text = "RAQUET";
            this.opFutbol.UseVisualStyleBackColor = true;
            // 
            // opBasquet
            // 
            this.opBasquet.AutoSize = true;
            this.opBasquet.Location = new System.Drawing.Point(201, 67);
            this.opBasquet.Name = "opBasquet";
            this.opBasquet.Size = new System.Drawing.Size(77, 17);
            this.opBasquet.TabIndex = 4;
            this.opBasquet.Text = "BASQUET";
            this.opBasquet.UseVisualStyleBackColor = true;
            // 
            // opVoley
            // 
            this.opVoley.AutoSize = true;
            this.opVoley.Location = new System.Drawing.Point(201, 104);
            this.opVoley.Name = "opVoley";
            this.opVoley.Size = new System.Drawing.Size(61, 17);
            this.opVoley.TabIndex = 5;
            this.opVoley.Text = "VOLEY";
            this.opVoley.UseVisualStyleBackColor = true;
            // 
            // opViudo
            // 
            this.opViudo.AutoSize = true;
            this.opViudo.Location = new System.Drawing.Point(31, 139);
            this.opViudo.Name = "opViudo";
            this.opViudo.Size = new System.Drawing.Size(59, 17);
            this.opViudo.TabIndex = 6;
            this.opViudo.TabStop = true;
            this.opViudo.Text = "VIUDO";
            this.opViudo.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(31, 183);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(102, 38);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar Seleccion";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnDeporte
            // 
            this.btnDeporte.Location = new System.Drawing.Point(188, 183);
            this.btnDeporte.Name = "btnDeporte";
            this.btnDeporte.Size = new System.Drawing.Size(102, 38);
            this.btnDeporte.TabIndex = 8;
            this.btnDeporte.Text = "Mostrar Seleccion";
            this.btnDeporte.UseVisualStyleBackColor = true;
            this.btnDeporte.Click += new System.EventHandler(this.btnDeporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 247);
            this.Controls.Add(this.btnDeporte);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.opViudo);
            this.Controls.Add(this.opVoley);
            this.Controls.Add(this.opBasquet);
            this.Controls.Add(this.opFutbol);
            this.Controls.Add(this.opDivorciado);
            this.Controls.Add(this.opCasado);
            this.Controls.Add(this.opSoltero);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton opSoltero;
        private System.Windows.Forms.RadioButton opCasado;
        private System.Windows.Forms.RadioButton opDivorciado;
        private System.Windows.Forms.CheckBox opFutbol;
        private System.Windows.Forms.CheckBox opBasquet;
        private System.Windows.Forms.CheckBox opVoley;
        private System.Windows.Forms.RadioButton opViudo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnDeporte;
    }
}

