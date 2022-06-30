namespace _10Proyecto
{
    partial class frmProducto
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.toolStrip1.TabIndex = 1;
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
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMarca.Location = new System.Drawing.Point(184, 119);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 30);
            this.txtMarca.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(45, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "MARCA";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Location = new System.Drawing.Point(184, 83);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(444, 30);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Location = new System.Drawing.Point(184, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 30);
            this.txtCodigo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "CODIGO";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Location = new System.Drawing.Point(184, 156);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 30);
            this.txtCantidad.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "CANTIDAD";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Location = new System.Drawing.Point(515, 156);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 30);
            this.txtPrecio.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(330, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "PRECIO UNITARIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 232);
            this.dataGridView1.TabIndex = 17;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
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
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}