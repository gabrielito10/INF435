namespace Clase05___ListView
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
            this.lstPersona = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.opSol = new System.Windows.Forms.RadioButton();
            this.opCas = new System.Windows.Forms.RadioButton();
            this.opDiv = new System.Windows.Forms.RadioButton();
            this.opViu = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPersona
            // 
            this.lstPersona.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstPersona.HideSelection = false;
            this.lstPersona.Location = new System.Drawing.Point(12, 104);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(461, 191);
            this.lstPersona.TabIndex = 0;
            this.lstPersona.UseCompatibleStateImageBehavior = false;
            this.lstPersona.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CI";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRE";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LUGAR_NACIMIENTO";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ESTADO_CIVIL";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(12, 62);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 20);
            this.txtCI.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 2;
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
            this.cmbDep.Location = new System.Drawing.Point(270, 63);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(94, 21);
            this.cmbDep.TabIndex = 3;
            // 
            // opSol
            // 
            this.opSol.AutoSize = true;
            this.opSol.Location = new System.Drawing.Point(366, 12);
            this.opSol.Name = "opSol";
            this.opSol.Size = new System.Drawing.Size(76, 17);
            this.opSol.TabIndex = 4;
            this.opSol.TabStop = true;
            this.opSol.Text = "SOLTERO";
            this.opSol.UseVisualStyleBackColor = true;
            // 
            // opCas
            // 
            this.opCas.AutoSize = true;
            this.opCas.Location = new System.Drawing.Point(366, 35);
            this.opCas.Name = "opCas";
            this.opCas.Size = new System.Drawing.Size(69, 17);
            this.opCas.TabIndex = 5;
            this.opCas.TabStop = true;
            this.opCas.Text = "CASADO";
            this.opCas.UseVisualStyleBackColor = true;
            // 
            // opDiv
            // 
            this.opDiv.AutoSize = true;
            this.opDiv.Location = new System.Drawing.Point(366, 58);
            this.opDiv.Name = "opDiv";
            this.opDiv.Size = new System.Drawing.Size(92, 17);
            this.opDiv.TabIndex = 6;
            this.opDiv.TabStop = true;
            this.opDiv.Text = "DIVORCIADO";
            this.opDiv.UseVisualStyleBackColor = true;
            // 
            // opViu
            // 
            this.opViu.AutoSize = true;
            this.opViu.Location = new System.Drawing.Point(366, 81);
            this.opViu.Name = "opViu";
            this.opViu.Size = new System.Drawing.Size(59, 17);
            this.opViu.TabIndex = 7;
            this.opViu.TabStop = true;
            this.opViu.Text = "VIUDO";
            this.opViu.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(494, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 36);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(494, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(494, 239);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 314);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.opViu);
            this.Controls.Add(this.opDiv);
            this.Controls.Add(this.opCas);
            this.Controls.Add(this.opSol);
            this.Controls.Add(this.cmbDep);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lstPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPersona;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.RadioButton opSol;
        private System.Windows.Forms.RadioButton opCas;
        private System.Windows.Forms.RadioButton opDiv;
        private System.Windows.Forms.RadioButton opViu;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

