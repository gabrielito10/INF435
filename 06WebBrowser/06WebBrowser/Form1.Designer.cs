namespace _06WebBrowser
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
            this.miNavegador = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.txtEnlace = new System.Windows.Forms.TextBox();
            this.btnIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // miNavegador
            // 
            this.miNavegador.Location = new System.Drawing.Point(12, 49);
            this.miNavegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.miNavegador.Name = "miNavegador";
            this.miNavegador.Size = new System.Drawing.Size(776, 375);
            this.miNavegador.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "<<< Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(93, 12);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(110, 23);
            this.btnAdelante.TabIndex = 2;
            this.btnAdelante.Text = "Adelante >>>";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // txtEnlace
            // 
            this.txtEnlace.Location = new System.Drawing.Point(209, 15);
            this.txtEnlace.Name = "txtEnlace";
            this.txtEnlace.Size = new System.Drawing.Size(454, 20);
            this.txtEnlace.TabIndex = 3;
            this.txtEnlace.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnlace_KeyUp);
            // 
            // btnIR
            // 
            this.btnIR.Location = new System.Drawing.Point(669, 13);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(75, 23);
            this.btnIR.TabIndex = 4;
            this.btnIR.Text = "Ir >";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.txtEnlace);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.miNavegador);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser miNavegador;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.TextBox txtEnlace;
        private System.Windows.Forms.Button btnIR;
    }
}

