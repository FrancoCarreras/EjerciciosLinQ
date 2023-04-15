namespace EjemplosWin
{
    partial class frmMenu
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
            this.llbExtensiones = new System.Windows.Forms.LinkLabel();
            this.llbQueries1 = new System.Windows.Forms.LinkLabel();
            this.llbQueries2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llbExtensiones
            // 
            this.llbExtensiones.AutoSize = true;
            this.llbExtensiones.Location = new System.Drawing.Point(91, 28);
            this.llbExtensiones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llbExtensiones.Name = "llbExtensiones";
            this.llbExtensiones.Size = new System.Drawing.Size(0, 29);
            this.llbExtensiones.TabIndex = 0;
            this.llbExtensiones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExtensiones_LinkClicked);
            // 
            // llbQueries1
            // 
            this.llbQueries1.AutoSize = true;
            this.llbQueries1.Location = new System.Drawing.Point(100, 70);
            this.llbQueries1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llbQueries1.Name = "llbQueries1";
            this.llbQueries1.Size = new System.Drawing.Size(118, 29);
            this.llbQueries1.TabIndex = 1;
            this.llbQueries1.TabStop = true;
            this.llbQueries1.Text = "Queries 1";
            this.llbQueries1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQueries1_LinkClicked);
            // 
            // llbQueries2
            // 
            this.llbQueries2.AutoSize = true;
            this.llbQueries2.Location = new System.Drawing.Point(100, 118);
            this.llbQueries2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llbQueries2.Name = "llbQueries2";
            this.llbQueries2.Size = new System.Drawing.Size(0, 29);
            this.llbQueries2.TabIndex = 2;
            this.llbQueries2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQueries2_LinkClicked);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 190);
            this.Controls.Add(this.llbQueries2);
            this.Controls.Add(this.llbQueries1);
            this.Controls.Add(this.llbExtensiones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbExtensiones;
        private System.Windows.Forms.LinkLabel llbQueries1;
        private System.Windows.Forms.LinkLabel llbQueries2;
    }
}

