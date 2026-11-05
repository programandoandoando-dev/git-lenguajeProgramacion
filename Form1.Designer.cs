namespace SystemVentas
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
            this.grpListadoProductos = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscaProducto = new System.Windows.Forms.TextBox();
            this.dtgListadoProductos = new System.Windows.Forms.DataGridView();
            this.grpListadoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListadoProductos
            // 
            this.grpListadoProductos.Controls.Add(this.dtgListadoProductos);
            this.grpListadoProductos.Controls.Add(this.txtBuscaProducto);
            this.grpListadoProductos.Controls.Add(this.lblBuscar);
            this.grpListadoProductos.Location = new System.Drawing.Point(446, 33);
            this.grpListadoProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListadoProductos.Name = "grpListadoProductos";
            this.grpListadoProductos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListadoProductos.Size = new System.Drawing.Size(850, 537);
            this.grpListadoProductos.TabIndex = 0;
            this.grpListadoProductos.TabStop = false;
            this.grpListadoProductos.Text = "Listado de Productos";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(20, 42);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscaProducto
            // 
            this.txtBuscaProducto.Location = new System.Drawing.Point(103, 32);
            this.txtBuscaProducto.Name = "txtBuscaProducto";
            this.txtBuscaProducto.Size = new System.Drawing.Size(653, 27);
            this.txtBuscaProducto.TabIndex = 1;
            // 
            // dtgListadoProductos
            // 
            this.dtgListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadoProductos.Location = new System.Drawing.Point(24, 106);
            this.dtgListadoProductos.Name = "dtgListadoProductos";
            this.dtgListadoProductos.RowHeadersWidth = 51;
            this.dtgListadoProductos.RowTemplate.Height = 24;
            this.dtgListadoProductos.Size = new System.Drawing.Size(802, 370);
            this.dtgListadoProductos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 604);
            this.Controls.Add(this.grpListadoProductos);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sistema de Ventas - Festionando Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpListadoProductos.ResumeLayout(false);
            this.grpListadoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListadoProductos;
        private System.Windows.Forms.TextBox txtBuscaProducto;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dtgListadoProductos;
    }
}

