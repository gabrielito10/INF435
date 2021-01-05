namespace Clase04___Listas
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
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnLisBox = new System.Windows.Forms.Button();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.lstDep = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(33, 122);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(121, 23);
            this.btnComboBox.TabIndex = 2;
            this.btnComboBox.Text = "SALUDAR";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // btnLisBox
            // 
            this.btnLisBox.Location = new System.Drawing.Point(235, 181);
            this.btnLisBox.Name = "btnLisBox";
            this.btnLisBox.Size = new System.Drawing.Size(121, 23);
            this.btnLisBox.TabIndex = 3;
            this.btnLisBox.Text = "SALUDAR";
            this.btnLisBox.UseVisualStyleBackColor = true;
            this.btnLisBox.Click += new System.EventHandler(this.btnLisBox_Click);
            // 
            // cmbDep
            // 
            this.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Items.AddRange(new object[] {
            "LA PAZ",
            "COCHABAMBA",
            "SANTA CRUZ",
            "ORURO",
            "POTOSI",
            "CHUQUISACA",
            "TARIJA",
            "BENI",
            "PANDO"});
            this.cmbDep.Location = new System.Drawing.Point(33, 51);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(121, 21);
            this.cmbDep.TabIndex = 4;
            // 
            // lstDep
            // 
            this.lstDep.FormattingEnabled = true;
            this.lstDep.Items.AddRange(new object[] {
            "LA PAZ",
            "COCHABAMBA",
            "SANTA CRUZ",
            "ORURO",
            "POTOSI",
            "CHUQUISACA",
            "TARIJA",
            "BENI",
            "PANDO"});
            this.lstDep.Location = new System.Drawing.Point(236, 51);
            this.lstDep.Name = "lstDep";
            this.lstDep.Size = new System.Drawing.Size(120, 121);
            this.lstDep.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 276);
            this.Controls.Add(this.lstDep);
            this.Controls.Add(this.cmbDep);
            this.Controls.Add(this.btnLisBox);
            this.Controls.Add(this.btnComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComboBox;
        private System.Windows.Forms.Button btnLisBox;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.ListBox lstDep;
    }
}

