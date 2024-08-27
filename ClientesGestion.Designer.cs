namespace ProyectoParcial
{
    partial class ClientesGestion
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
            panel1 = new Panel();
            label8 = new Label();
            txtDirreccion = new TextBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtId = new TextBox();
            txtNombres = new TextBox();
            dgvClientes = new DataGridView();
            btnAgregarCliente = new Button();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            txtCodigo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDirreccion);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(dgvClientes);
            panel1.Controls.Add(btnAgregarCliente);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtCodigo);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1639, 718);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Location = new Point(768, 237);
            label8.Name = "label8";
            label8.Size = new Size(111, 27);
            label8.TabIndex = 35;
            label8.Text = "DIRRECCIÓN";
            // 
            // txtDirreccion
            // 
            txtDirreccion.Location = new Point(885, 234);
            txtDirreccion.Name = "txtDirreccion";
            txtDirreccion.Size = new Size(528, 27);
            txtDirreccion.TabIndex = 34;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1194, 171);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 27);
            txtTelefono.TabIndex = 33;
            txtTelefono.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.Location = new Point(1106, 174);
            label7.Name = "label7";
            label7.Size = new Size(82, 27);
            label7.TabIndex = 32;
            label7.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.Location = new Point(768, 177);
            label6.Name = "label6";
            label6.Size = new Size(82, 27);
            label6.TabIndex = 31;
            label6.Text = "CORREO";
            // 
            // label5
            // 
            label5.Location = new Point(405, 240);
            label5.Name = "label5";
            label5.Size = new Size(101, 27);
            label5.TabIndex = 30;
            label5.Text = "APELLIDOS";
            // 
            // label4
            // 
            label4.Location = new Point(405, 180);
            label4.Name = "label4";
            label4.Size = new Size(101, 27);
            label4.TabIndex = 29;
            label4.Text = "NOMBRES";
            // 
            // label3
            // 
            label3.Location = new Point(73, 243);
            label3.Name = "label3";
            label3.Size = new Size(80, 27);
            label3.TabIndex = 28;
            label3.Text = "CÓDIGO";
            // 
            // label1
            // 
            label1.Location = new Point(73, 183);
            label1.Name = "label1";
            label1.Size = new Size(49, 27);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(651, 67);
            label2.Name = "label2";
            label2.Size = new Size(319, 42);
            label2.TabIndex = 26;
            label2.Text = "GESTIÓN DE CLIENTES";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(452, 327);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 39);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar Cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(265, 327);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(157, 39);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar Cliente";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(159, 180);
            txtId.Name = "txtId";
            txtId.Size = new Size(219, 27);
            txtId.TabIndex = 23;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(512, 177);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(219, 27);
            txtNombres.TabIndex = 22;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(71, 395);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(1518, 223);
            dgvClientes.TabIndex = 21;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(71, 327);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(157, 39);
            btnAgregarCliente.TabIndex = 20;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(512, 237);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(219, 27);
            txtApellidos.TabIndex = 19;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(856, 174);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(219, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(159, 240);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(219, 27);
            txtCodigo.TabIndex = 17;
            // 
            // ClientesGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ClientesGestion";
            Size = new Size(1634, 718);
            Load += ClientesGestion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtId;
        private TextBox txtNombres;
        private DataGridView dgvClientes;
        private Button btnAgregarCliente;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label8;
        private TextBox txtDirreccion;
        private TextBox txtTelefono;
        private Label label7;
        private Label label6;
    }
}
