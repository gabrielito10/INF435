namespace _10Proyecto
{
    partial class frmCliente
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblRegistro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opSoltero = new System.Windows.Forms.RadioButton();
            this.opCasado = new System.Windows.Forms.RadioButton();
            this.opViudo = new System.Windows.Forms.RadioButton();
            this.opDivorciado = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdNuevo = new System.Windows.Forms.ToolStripButton();
            this.cmdEditar = new System.Windows.Forms.ToolStripButton();
            this.cmdEliminar = new System.Windows.Forms.ToolStripButton();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.cmdPrimer = new System.Windows.Forms.ToolStripButton();
            this.cmdAnterior = new System.Windows.Forms.ToolStripButton();
            this.cmdSiguinte = new System.Windows.Forms.ToolStripButton();
            this.cmdUltimo = new System.Windows.Forms.ToolStripButton();
            this.cmdCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmdImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNuevo,
            this.cmdEditar,
            this.cmdEliminar,
            this.cmdGuardar,
            this.toolStripSeparator1,
            this.cmdPrimer,
            this.cmdAnterior,
            this.lblRegistro,
            this.cmdSiguinte,
            this.cmdUltimo,
            this.toolStripSeparator2,
            this.cmdCancelar,
            this.cmdImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(63, 28);
            this.lblRegistro.Text = "lblRegistro";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CI";
            // 
            // txtCI
            // 
            this.txtCI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCI.Enabled = false;
            this.txtCI.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCI.Location = new System.Drawing.Point(186, 69);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 30);
            this.txtCI.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(186, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(444, 30);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCelular.Enabled = false;
            this.txtCelular.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCelular.Location = new System.Drawing.Point(186, 141);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 30);
            this.txtCelular.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(47, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "CELULAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(47, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "ESTADO CIVIL";
            // 
            // opSoltero
            // 
            this.opSoltero.AutoSize = true;
            this.opSoltero.Enabled = false;
            this.opSoltero.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opSoltero.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.opSoltero.Location = new System.Drawing.Point(227, 187);
            this.opSoltero.Name = "opSoltero";
            this.opSoltero.Size = new System.Drawing.Size(129, 27);
            this.opSoltero.TabIndex = 8;
            this.opSoltero.TabStop = true;
            this.opSoltero.Text = "SOLTERO(A)";
            this.opSoltero.UseVisualStyleBackColor = true;
            // 
            // opCasado
            // 
            this.opCasado.AutoSize = true;
            this.opCasado.Enabled = false;
            this.opCasado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opCasado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.opCasado.Location = new System.Drawing.Point(362, 187);
            this.opCasado.Name = "opCasado";
            this.opCasado.Size = new System.Drawing.Size(122, 27);
            this.opCasado.TabIndex = 9;
            this.opCasado.TabStop = true;
            this.opCasado.Text = "CASADO(A)";
            this.opCasado.UseVisualStyleBackColor = true;
            // 
            // opViudo
            // 
            this.opViudo.AutoSize = true;
            this.opViudo.Enabled = false;
            this.opViudo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opViudo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.opViudo.Location = new System.Drawing.Point(659, 187);
            this.opViudo.Name = "opViudo";
            this.opViudo.Size = new System.Drawing.Size(109, 27);
            this.opViudo.TabIndex = 10;
            this.opViudo.TabStop = true;
            this.opViudo.Text = "VIUDO(A)";
            this.opViudo.UseVisualStyleBackColor = true;
            // 
            // opDivorciado
            // 
            this.opDivorciado.AutoSize = true;
            this.opDivorciado.Enabled = false;
            this.opDivorciado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDivorciado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.opDivorciado.Location = new System.Drawing.Point(490, 187);
            this.opDivorciado.Name = "opDivorciado";
            this.opDivorciado.Size = new System.Drawing.Size(163, 27);
            this.opDivorciado.TabIndex = 11;
            this.opDivorciado.TabStop = true;
            this.opDivorciado.Text = "DIVORCIADO(A)";
            this.opDivorciado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(47, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "NACIMIENTO";
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.Enabled = false;
            this.cmbDepartamentos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.ForeColor = System.Drawing.SystemColors.MenuBar;
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
            this.cmbDepartamentos.Location = new System.Drawing.Point(186, 216);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(170, 31);
            this.cmbDepartamentos.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 162);
            this.dataGridView1.TabIndex = 14;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNuevo.Image = global::_10Proyecto.Properties.Resources.imgNuevo;
            this.cmdNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(28, 28);
            this.cmdNuevo.Text = "NUEVO";
            // 
            // cmdEditar
            // 
            this.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdEditar.Image = global::_10Proyecto.Properties.Resources.imgEditar;
            this.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(28, 28);
            this.cmdEditar.Text = "EDITAR";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdEliminar.Image = global::_10Proyecto.Properties.Resources.imgEliminar;
            this.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(28, 28);
            this.cmdEliminar.Text = "ELIMINAR";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdGuardar.Image = global::_10Proyecto.Properties.Resources.imgGuardar;
            this.cmdGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(28, 28);
            this.cmdGuardar.Text = "GUARDAR";
            // 
            // cmdPrimer
            // 
            this.cmdPrimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPrimer.Image = global::_10Proyecto.Properties.Resources.imgPrimero;
            this.cmdPrimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrimer.Name = "cmdPrimer";
            this.cmdPrimer.Size = new System.Drawing.Size(28, 28);
            this.cmdPrimer.Text = "PRIMER REGISTRO";
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAnterior.Image = global::_10Proyecto.Properties.Resources.imgAnterior;
            this.cmdAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(28, 28);
            this.cmdAnterior.Text = "ANTERIOR REGISTRO";
            // 
            // cmdSiguinte
            // 
            this.cmdSiguinte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSiguinte.Image = global::_10Proyecto.Properties.Resources.imgSiguiente;
            this.cmdSiguinte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSiguinte.Name = "cmdSiguinte";
            this.cmdSiguinte.Size = new System.Drawing.Size(28, 28);
            this.cmdSiguinte.Text = "SIGUIENTE REGISTRO";
            // 
            // cmdUltimo
            // 
            this.cmdUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUltimo.Image = global::_10Proyecto.Properties.Resources.imgUltimo;
            this.cmdUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUltimo.Name = "cmdUltimo";
            this.cmdUltimo.Size = new System.Drawing.Size(28, 28);
            this.cmdUltimo.Text = "ULTIMO REGISTRO";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCancelar.Image = global::_10Proyecto.Properties.Resources.imgCancelar;
            this.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(28, 28);
            this.cmdCancelar.Text = "CANCELAR";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdImprimir.Image = global::_10Proyecto.Properties.Resources.imgImprimir;
            this.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(28, 28);
            this.cmdImprimir.Text = "IMPRIMIR";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.opDivorciado);
            this.Controls.Add(this.opViudo);
            this.Controls.Add(this.opCasado);
            this.Controls.Add(this.opSoltero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdNuevo;
        private System.Windows.Forms.ToolStripButton cmdEditar;
        private System.Windows.Forms.ToolStripButton cmdEliminar;
        private System.Windows.Forms.ToolStripButton cmdGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdPrimer;
        private System.Windows.Forms.ToolStripButton cmdAnterior;
        private System.Windows.Forms.ToolStripLabel lblRegistro;
        private System.Windows.Forms.ToolStripButton cmdSiguinte;
        private System.Windows.Forms.ToolStripButton cmdUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cmdCancelar;
        private System.Windows.Forms.ToolStripButton cmdImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton opSoltero;
        private System.Windows.Forms.RadioButton opCasado;
        private System.Windows.Forms.RadioButton opViudo;
        private System.Windows.Forms.RadioButton opDivorciado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}