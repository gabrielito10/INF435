namespace _09Practica
{
    partial class Form2
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
            this.rbtMenor = new System.Windows.Forms.RadioButton();
            this.rbtMayor = new System.Windows.Forms.RadioButton();
            this.chk435 = new System.Windows.Forms.CheckBox();
            this.chk430 = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.Location = new System.Drawing.Point(44, 48);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(90, 17);
            this.rbtMenor.TabIndex = 0;
            this.rbtMenor.TabStop = true;
            this.rbtMenor.Text = "MENOR A 20";
            this.rbtMenor.UseVisualStyleBackColor = true;
            // 
            // rbtMayor
            // 
            this.rbtMayor.AutoSize = true;
            this.rbtMayor.Location = new System.Drawing.Point(44, 71);
            this.rbtMayor.Name = "rbtMayor";
            this.rbtMayor.Size = new System.Drawing.Size(89, 17);
            this.rbtMayor.TabIndex = 1;
            this.rbtMayor.TabStop = true;
            this.rbtMayor.Text = "MAYOR A 20";
            this.rbtMayor.UseVisualStyleBackColor = true;
            // 
            // chk435
            // 
            this.chk435.AutoSize = true;
            this.chk435.Location = new System.Drawing.Point(226, 48);
            this.chk435.Name = "chk435";
            this.chk435.Size = new System.Drawing.Size(61, 17);
            this.chk435.TabIndex = 2;
            this.chk435.Text = "INF435";
            this.chk435.UseVisualStyleBackColor = true;
            // 
            // chk430
            // 
            this.chk430.AutoSize = true;
            this.chk430.Location = new System.Drawing.Point(226, 72);
            this.chk430.Name = "chk430";
            this.chk430.Size = new System.Drawing.Size(61, 17);
            this.chk430.TabIndex = 3;
            this.chk430.Text = "INF430";
            this.chk430.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(99, 112);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(165, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "MOSTRAR INFORMACION";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 147);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chk430);
            this.Controls.Add(this.chk435);
            this.Controls.Add(this.rbtMayor);
            this.Controls.Add(this.rbtMenor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtMenor;
        private System.Windows.Forms.RadioButton rbtMayor;
        private System.Windows.Forms.CheckBox chk435;
        private System.Windows.Forms.CheckBox chk430;
        private System.Windows.Forms.Button btnMostrar;
    }
}