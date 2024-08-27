namespace ProyectoParcial
{
    partial class CompraControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreProducto = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioCompra = new TextBox();
            cmbProveedor = new ComboBox();
            btnAgregarProducto = new Button();
            dgvCarritoCompras = new DataGridView();
            btnConfirmarCompra = new Button();
            cmbCategoria = new ComboBox();
            cmbMarca = new ComboBox();
            cmbEstatus = new ComboBox();
            txtCodigo = new TextBox();
            txtId = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoCompras).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(68, 182);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(219, 27);
            txtNombreProducto.TabIndex = 0;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(68, 238);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(219, 27);
            txtCantidad.TabIndex = 1;
            txtCantidad.KeyPress += txtCantidad_KeyPress_1;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(68, 302);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(219, 27);
            txtPrecioCompra.TabIndex = 2;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress_1;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(68, 368);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(219, 28);
            cmbProveedor.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(323, 296);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(157, 39);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click_1;
            // 
            // dgvCarritoCompras
            // 
            dgvCarritoCompras.AllowUserToAddRows = false;
            dgvCarritoCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarritoCompras.Location = new Point(323, 368);
            dgvCarritoCompras.Name = "dgvCarritoCompras";
            dgvCarritoCompras.RowHeadersWidth = 51;
            dgvCarritoCompras.Size = new Size(1302, 223);
            dgvCarritoCompras.TabIndex = 5;
            dgvCarritoCompras.CellClick += dgvCarritoCompras_CellClick;
            dgvCarritoCompras.CellContentClick += dgvCarritoCompras_CellContentClick;
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Location = new Point(1427, 290);
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.Size = new Size(198, 36);
            btnConfirmarCompra.TabIndex = 6;
            btnConfirmarCompra.Text = "Confirmar Compra";
            btnConfirmarCompra.UseVisualStyleBackColor = true;
            btnConfirmarCompra.Click += btnConfirmarCompra_Click_1;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(68, 433);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(219, 28);
            cmbCategoria.TabIndex = 7;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(68, 497);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(219, 28);
            cmbMarca.TabIndex = 8;
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Location = new Point(68, 552);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(219, 28);
            cmbEstatus.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(68, 124);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(219, 27);
            txtCodigo.TabIndex = 10;
            txtCodigo.KeyPress += txtCodigo_KeyPress_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(68, 75);
            txtId.Name = "txtId";
            txtId.Size = new Size(219, 27);
            txtId.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(504, 296);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(157, 39);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar Producto";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(685, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 39);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(1423, 607);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(202, 34);
            lblTotal.TabIndex = 14;
            // 
            // label1
            // 
            label1.Location = new Point(1294, 607);
            label1.Name = "label1";
            label1.Size = new Size(135, 34);
            label1.TabIndex = 15;
            label1.Text = "TOTAL A PAGAR: ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(653, 124);
            label2.Name = "label2";
            label2.Size = new Size(565, 42);
            label2.TabIndex = 16;
            label2.Text = "GESTIÓN DE COMPRAS A PROVEEDORES";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // CompraControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtId);
            Controls.Add(txtCodigo);
            Controls.Add(cmbEstatus);
            Controls.Add(cmbMarca);
            Controls.Add(cmbCategoria);
            Controls.Add(btnConfirmarCompra);
            Controls.Add(dgvCarritoCompras);
            Controls.Add(btnAgregarProducto);
            Controls.Add(cmbProveedor);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreProducto);
            Name = "CompraControl";
            Size = new Size(1684, 671);
            Load += CompraControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarritoCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecioCompra;
        private ComboBox cmbProveedor;
        private Button btnAgregarProducto;
        private DataGridView dgvCarritoCompras;
        private Button btnConfirmarCompra;
        private ComboBox cmbCategoria;
        private ComboBox cmbMarca;
        private ComboBox cmbEstatus;
        private TextBox txtCodigo;
        private TextBox txtId;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Button btnVolver;
    }
}
