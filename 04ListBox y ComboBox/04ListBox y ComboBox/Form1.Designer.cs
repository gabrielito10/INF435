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
            this.lstDia = new System.Windows.Forms.ListBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.btnListBox = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDia
            // 
            this.lstDia.FormattingEnabled = true;
            this.lstDia.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.lstDia.Location = new System.Drawing.Point(39, 34);
            this.lstDia.Name = "lstDia";
            this.lstDia.Size = new System.Drawing.Size(120, 43);
            this.lstDia.TabIndex = 0;
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.cmbDia.Location = new System.Drawing.Point(217, 34);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 21);
            this.cmbDia.TabIndex = 1;
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(39, 114);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(120, 23);
            this.btnListBox.TabIndex = 2;
            this.btnListBox.Text = "MOSTRAR LISTBOX";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.btnListBox_Click);
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(205, 114);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(133, 23);
            this.btnComboBox.TabIndex = 3;
            this.btnComboBox.Text = "MOSTRAR COMBOBOX";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 226);
            this.Controls.Add(this.btnComboBox);
            this.Controls.Add(this.btnListBox);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lstDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDia;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Button btnListBox;
        private System.Windows.Forms.Button btnComboBox;
    }
}

