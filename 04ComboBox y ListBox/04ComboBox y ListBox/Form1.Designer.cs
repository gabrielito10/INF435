namespace _04ComboBox_y_ListBox
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
            this.btnListbox = new System.Windows.Forms.Button();
            this.btnCombobox = new System.Windows.Forms.Button();
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
            this.lstDepartamentos.Location = new System.Drawing.Point(68, 51);
            this.lstDepartamentos.Name = "lstDepartamentos";
            this.lstDepartamentos.Size = new System.Drawing.Size(120, 95);
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
            this.cmbDepartamentos.Location = new System.Drawing.Point(295, 60);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamentos.TabIndex = 1;
            // 
            // btnListbox
            // 
            this.btnListbox.Location = new System.Drawing.Point(68, 182);
            this.btnListbox.Name = "btnListbox";
            this.btnListbox.Size = new System.Drawing.Size(135, 53);
            this.btnListbox.TabIndex = 2;
            this.btnListbox.Text = "SALUDAR LISTBOX";
            this.btnListbox.UseVisualStyleBackColor = true;
            this.btnListbox.Click += new System.EventHandler(this.btnListbox_Click);
            // 
            // btnCombobox
            // 
            this.btnCombobox.Location = new System.Drawing.Point(309, 182);
            this.btnCombobox.Name = "btnCombobox";
            this.btnCombobox.Size = new System.Drawing.Size(141, 53);
            this.btnCombobox.TabIndex = 3;
            this.btnCombobox.Text = "SALUDAR COMBOBOX";
            this.btnCombobox.UseVisualStyleBackColor = true;
            this.btnCombobox.Click += new System.EventHandler(this.btnCombobox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 296);
            this.Controls.Add(this.btnCombobox);
            this.Controls.Add(this.btnListbox);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.lstDepartamentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDepartamentos;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Button btnListbox;
        private System.Windows.Forms.Button btnCombobox;
    }
}

