namespace ProyectoParcial
{
    partial class RecepcionControl
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
            dgvProductosDisponibles = new DataGridView();
            dgvProductosRecepcionados = new DataGridView();
            btnAgregar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            btnConfirmar = new Button();
            btnQuitar = new Button();
            label1 = new Label();
            lblGanancia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosRecepcionados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // dgvProductosRecepcionados
            // 
            dgvProductosRecepcionados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProductosRecepcionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosRecepcionados.Location = new Point(968, 195);
            dgvProductosRecepcionados.Name = "dgvProductosRecepcionados";
            dgvProductosRecepcionados.RowHeadersWidth = 51;
            dgvProductosRecepcionados.Size = new Size(801, 313);
            dgvProductosRecepcionados.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(855, 262);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(609, 60);
            label2.Name = "label2";
            label2.Size = new Size(628, 44);
            label2.TabIndex = 17;
            label2.Text = "GESTIÓN DE RECEPCIÓN DE MEDICAMENTOS";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(btnQuitar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblGanancia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(dgvProductosRecepcionados);
            panel1.Controls.Add(dgvProductosDisponibles);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1810, 642);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(855, 380);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 23;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(855, 321);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 29);
            btnQuitar.TabIndex = 22;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click_1;
            // 
            // label1
            // 
            label1.Location = new Point(1399, 549);
            label1.Name = "label1";
            label1.Size = new Size(137, 34);
            label1.TabIndex = 19;
            label1.Text = "GANANCIA TOTAL: ";
            // 
            // lblGanancia
            // 
            lblGanancia.Location = new Point(1542, 549);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(202, 34);
            lblGanancia.TabIndex = 18;
            // 
            // RecepcionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "RecepcionControl";
            Size = new Size(1810, 724);
            Load += RecepcionControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosRecepcionados).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductosDisponibles;
        private DataGridView dgvProductosRecepcionados;
        private Button btnAgregar;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label lblGanancia;
        private Button btnQuitar;
        private Button btnConfirmar;
    }
}
