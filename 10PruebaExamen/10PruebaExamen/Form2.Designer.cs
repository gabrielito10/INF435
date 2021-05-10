namespace _10PruebaExamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.opSuma = new System.Windows.Forms.RadioButton();
            this.opResta = new System.Windows.Forms.RadioButton();
            this.opMultiplicacion = new System.Windows.Forms.RadioButton();
            this.opDivision = new System.Windows.Forms.RadioButton();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer Valor";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(258, 25);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 3;
            // 
            // opSuma
            // 
            this.opSuma.AutoSize = true;
            this.opSuma.Location = new System.Drawing.Point(12, 28);
            this.opSuma.Name = "opSuma";
            this.opSuma.Size = new System.Drawing.Size(56, 17);
            this.opSuma.TabIndex = 4;
            this.opSuma.TabStop = true;
            this.opSuma.Text = "SUMA";
            this.opSuma.UseVisualStyleBackColor = true;
            // 
            // opResta
            // 
            this.opResta.AutoSize = true;
            this.opResta.Location = new System.Drawing.Point(12, 51);
            this.opResta.Name = "opResta";
            this.opResta.Size = new System.Drawing.Size(61, 17);
            this.opResta.TabIndex = 5;
            this.opResta.TabStop = true;
            this.opResta.Text = "RESTA";
            this.opResta.UseVisualStyleBackColor = true;
            // 
            // opMultiplicacion
            // 
            this.opMultiplicacion.AutoSize = true;
            this.opMultiplicacion.Location = new System.Drawing.Point(12, 74);
            this.opMultiplicacion.Name = "opMultiplicacion";
            this.opMultiplicacion.Size = new System.Drawing.Size(114, 17);
            this.opMultiplicacion.TabIndex = 6;
            this.opMultiplicacion.TabStop = true;
            this.opMultiplicacion.Text = "MULTIPLICACION";
            this.opMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // opDivision
            // 
            this.opDivision.AutoSize = true;
            this.opDivision.Location = new System.Drawing.Point(12, 97);
            this.opDivision.Name = "opDivision";
            this.opDivision.Size = new System.Drawing.Size(72, 17);
            this.opDivision.TabIndex = 7;
            this.opDivision.TabStop = true;
            this.opDivision.Text = "DIVISION";
            this.opDivision.UseVisualStyleBackColor = true;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(258, 61);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(124, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segundo Valor";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(128, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 39);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 179);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opDivision);
            this.Controls.Add(this.opMultiplicacion);
            this.Controls.Add(this.opResta);
            this.Controls.Add(this.opSuma);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.RadioButton opSuma;
        private System.Windows.Forms.RadioButton opResta;
        private System.Windows.Forms.RadioButton opMultiplicacion;
        private System.Windows.Forms.RadioButton opDivision;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
    }
}