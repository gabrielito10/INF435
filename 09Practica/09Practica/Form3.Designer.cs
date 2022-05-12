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
            this.lstUno = new System.Windows.Forms.ListBox();
            this.lstDos = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUno
            // 
            this.lstUno.FormattingEnabled = true;
            this.lstUno.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.lstUno.Location = new System.Drawing.Point(125, 62);
            this.lstUno.Name = "lstUno";
            this.lstUno.Size = new System.Drawing.Size(120, 95);
            this.lstUno.TabIndex = 0;
            // 
            // lstDos
            // 
            this.lstDos.FormattingEnabled = true;
            this.lstDos.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.lstDos.Location = new System.Drawing.Point(314, 62);
            this.lstDos.Name = "lstDos";
            this.lstDos.Size = new System.Drawing.Size(120, 95);
            this.lstDos.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(202, 181);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(169, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 236);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstDos);
            this.Controls.Add(this.lstUno);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUno;
        private System.Windows.Forms.ListBox lstDos;
        private System.Windows.Forms.Button btnCalcular;
    }
}