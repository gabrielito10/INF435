namespace _04ListBox_y_ComboBox
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
            this.lstDepartamentos = new System.Windows.Forms.ListBox();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.btnListBox = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDepartamentos
            // 
            this.lstDepartamentos.FormattingEnabled = true;
            this.lstDepartamentos.Items.AddRange(new object[] {
            "LA PAZ",
            "COCHABAMBA",
            "SANTA CRUZ",
            "POTOSI",
            "ORURO",
            "CHUQUISACA",
            "TARIJA",
            "BENI",
            "PANDO"});
            this.lstDepartamentos.Location = new System.Drawing.Point(54, 45);
            this.lstDepartamentos.Name = "lstDepartamentos";
            this.lstDepartamentos.Size = new System.Drawing.Size(120, 69);
            this.lstDepartamentos.TabIndex = 0;
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Items.AddRange(new object[] {
            "LA PAZ",
            "COCHABAMBA",
            "SANTA CRUZ",
            "POTOSI",
            "ORURO",
            "CHUQUISACA",
            "TARIJA",
            "BENI",
            "PANDO"});
            this.cmbDepartamentos.Location = new System.Drawing.Point(243, 45);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamentos.TabIndex = 1;
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(54, 160);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(120, 40);
            this.btnListBox.TabIndex = 2;
            this.btnListBox.Text = "Mostrar ListBox";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.btnListBox_Click);
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(244, 160);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(120, 40);
            this.btnComboBox.TabIndex = 3;
            this.btnComboBox.Text = "Mostrar ComboBox";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.btnComboBox);
            this.Controls.Add(this.btnListBox);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.lstDepartamentos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDepartamentos;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Button btnListBox;
        private System.Windows.Forms.Button btnComboBox;
    }
}

