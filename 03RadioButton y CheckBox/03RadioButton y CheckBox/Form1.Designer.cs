namespace _03RadioButton_y_CheckBox
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
            this.rbtSoltero = new System.Windows.Forms.RadioButton();
            this.rbtCasado = new System.Windows.Forms.RadioButton();
            this.rbtDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtViudo = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtSoltero
            // 
            this.rbtSoltero.AutoSize = true;
            this.rbtSoltero.Location = new System.Drawing.Point(47, 30);
            this.rbtSoltero.Name = "rbtSoltero";
            this.rbtSoltero.Size = new System.Drawing.Size(76, 17);
            this.rbtSoltero.TabIndex = 0;
            this.rbtSoltero.TabStop = true;
            this.rbtSoltero.Text = "SOLTERO";
            this.rbtSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtCasado
            // 
            this.rbtCasado.AutoSize = true;
            this.rbtCasado.Location = new System.Drawing.Point(47, 65);
            this.rbtCasado.Name = "rbtCasado";
            this.rbtCasado.Size = new System.Drawing.Size(69, 17);
            this.rbtCasado.TabIndex = 1;
            this.rbtCasado.TabStop = true;
            this.rbtCasado.Text = "CASADO";
            this.rbtCasado.UseVisualStyleBackColor = true;
            // 
            // rbtDivorciado
            // 
            this.rbtDivorciado.AutoSize = true;
            this.rbtDivorciado.Location = new System.Drawing.Point(47, 101);
            this.rbtDivorciado.Name = "rbtDivorciado";
            this.rbtDivorciado.Size = new System.Drawing.Size(92, 17);
            this.rbtDivorciado.TabIndex = 2;
            this.rbtDivorciado.TabStop = true;
            this.rbtDivorciado.Text = "DIVORCIADO";
            this.rbtDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtViudo
            // 
            this.rbtViudo.AutoSize = true;
            this.rbtViudo.Location = new System.Drawing.Point(47, 138);
            this.rbtViudo.Name = "rbtViudo";
            this.rbtViudo.Size = new System.Drawing.Size(59, 17);
            this.rbtViudo.TabIndex = 3;
            this.rbtViudo.TabStop = true;
            this.rbtViudo.Text = "VIUDO";
            this.rbtViudo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(230, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "FUTBOL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(230, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "BASQUET";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(230, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "VOLIBOL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(230, 138);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "RAQUET";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.Navy;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstado.Location = new System.Drawing.Point(24, 202);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(158, 40);
            this.btnEstado.TabIndex = 8;
            this.btnEstado.Text = "Mostrar Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 243);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbtViudo);
            this.Controls.Add(this.rbtDivorciado);
            this.Controls.Add(this.rbtCasado);
            this.Controls.Add(this.rbtSoltero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtSoltero;
        private System.Windows.Forms.RadioButton rbtCasado;
        private System.Windows.Forms.RadioButton rbtDivorciado;
        private System.Windows.Forms.RadioButton rbtViudo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnEstado;
    }
}

