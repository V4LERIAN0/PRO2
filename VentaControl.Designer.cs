namespace ProyectoParcial
{
    partial class VentaControl
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
            lblTotalVenta = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnDescuento = new Button();
            cmbClientes = new ComboBox();
            btnConfirmar = new Button();
            btnQuitar = new Button();
            label1 = new Label();
            lblTotal = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            dgvProductosOrden = new DataGridView();
            dgvProductosDisponibles = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosOrden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).BeginInit();
            SuspendLayout();
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.Location = new Point(-3, 0);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(125, 28);
            lblTotalVenta.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalVenta);
            panel1.Location = new Point(619, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 28);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDescuento);
            panel2.Controls.Add(cmbClientes);
            panel2.Controls.Add(btnConfirmar);
            panel2.Controls.Add(btnQuitar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(dgvProductosOrden);
            panel2.Controls.Add(dgvProductosDisponibles);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(1807, 642);
            panel2.TabIndex = 19;
            // 
            // btnDescuento
            // 
            btnDescuento.Location = new Point(855, 436);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(94, 29);
            btnDescuento.TabIndex = 25;
            btnDescuento.Text = "Descuento";
            btnDescuento.UseVisualStyleBackColor = true;
            btnDescuento.Click += btnDescuento_Click_1;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(33, 125);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(539, 28);
            cmbClientes.TabIndex = 24;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(855, 380);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 23;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(855, 321);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 29);
            btnQuitar.TabIndex = 22;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(1496, 531);
            label1.Name = "label1";
            label1.Size = new Size(62, 34);
            label1.TabIndex = 19;
            label1.Text = "TOTAL: ";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(1564, 531);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(202, 34);
            lblTotal.TabIndex = 18;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(777, 53);
            label2.Name = "label2";
            label2.Size = new Size(295, 44);
            label2.TabIndex = 17;
            label2.Text = "PUNTO DE VENTA";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(855, 262);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProductosOrden
            // 
            dgvProductosOrden.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProductosOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosOrden.Location = new Point(966, 195);
            dgvProductosOrden.Name = "dgvProductosOrden";
            dgvProductosOrden.RowHeadersWidth = 51;
            dgvProductosOrden.Size = new Size(798, 313);
            dgvProductosOrden.TabIndex = 1;
            // 
            // dgvProductosDisponibles
            // 
            dgvProductosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosDisponibles.Location = new Point(33, 195);
            dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            dgvProductosDisponibles.RowHeadersWidth = 51;
            dgvProductosDisponibles.Size = new Size(805, 313);
            dgvProductosDisponibles.TabIndex = 0;
            // 
            // VentaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VentaControl";
            Size = new Size(1807, 784);
            Load += VentaControl_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductosOrden).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTotalVenta;
        private Panel panel1;
        private Panel panel2;
        private Button btnConfirmar;
        private Button btnQuitar;
        private Label label1;
        private Label lblTotal;
        private Label label2;
        private Button btnAgregar;
        private DataGridView dgvProductosOrden;
        private DataGridView dgvProductosDisponibles;
        private ComboBox cmbClientes;
        private Button btnDescuento;
    }
}
