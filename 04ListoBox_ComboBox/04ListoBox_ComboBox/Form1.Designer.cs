namespace _04ListoBox_ComboBox
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
            this.cmbDepartamentos = new System.Windows.Forms.ListBox();
            this.lstSaludo = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListView();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbClub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.ForeColor = System.Drawing.Color.DarkRed;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.ItemHeight = 16;
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
            this.cmbDepartamentos.Location = new System.Drawing.Point(216, 49);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(152, 68);
            this.cmbDepartamentos.TabIndex = 0;
            // 
            // lstSaludo
            // 
            this.lstSaludo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSaludo.FormattingEnabled = true;
            this.lstSaludo.Items.AddRange(new object[] {
            "BUENOS DIAS",
            "BUENAS TARDES",
            "BUENAS NOCHES"});
            this.lstSaludo.Location = new System.Drawing.Point(40, 49);
            this.lstSaludo.Name = "lstSaludo";
            this.lstSaludo.Size = new System.Drawing.Size(121, 21);
            this.lstSaludo.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(135, 152);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 43);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "MOSTRAR SALUDO";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lista
            // 
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(5, 292);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(462, 131);
            this.lista.TabIndex = 3;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(5, 248);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(100, 20);
            this.txtCarnet.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 248);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cmbClub
            // 
            this.cmbClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClub.FormattingEnabled = true;
            this.cmbClub.Items.AddRange(new object[] {
            "PICHINCHA",
            "CALERO",
            "NACIONAL"});
            this.cmbClub.Location = new System.Drawing.Point(352, 248);
            this.cmbClub.Name = "cmbClub";
            this.cmbClub.Size = new System.Drawing.Size(115, 21);
            this.cmbClub.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CARNET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CLUB";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 435);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(331, 435);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(136, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(165, 435);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CARNET";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRE";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CLUB";
            this.columnHeader3.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 470);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClub);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lstSaludo);
            this.Controls.Add(this.cmbDepartamentos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox lstSaludo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbClub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

