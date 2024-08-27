namespace ProyectoParcial
{
    partial class Form2
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
            txtCantidadRecepcion = new TextBox();
            txtPrecioVenta = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            cmbPasillo = new ComboBox();
            label4 = new Label();
            cmbEstante = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCantidadRecepcion
            // 
            txtCantidadRecepcion.Location = new Point(224, 88);
            txtCantidadRecepcion.Name = "txtCantidadRecepcion";
            txtCantidadRecepcion.Size = new Size(151, 27);
            txtCantidadRecepcion.TabIndex = 0;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(224, 143);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(151, 27);
            txtPrecioVenta.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(115, 325);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "OK";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(245, 325);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // label3
            // 
            label3.Location = new Point(81, 204);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 22;
            label3.Text = "PASILLO DESTINO";
            // 
            // cmbPasillo
            // 
            cmbPasillo.FormattingEnabled = true;
            cmbPasillo.Location = new Point(224, 201);
            cmbPasillo.Name = "cmbPasillo";
            cmbPasillo.Size = new Size(151, 28);
            cmbPasillo.TabIndex = 21;
            // 
            // label4
            // 
            label4.Location = new Point(81, 253);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 24;
            label4.Text = "ESTANTE DESTINO";
            // 
            // cmbEstante
            // 
            cmbEstante.FormattingEnabled = true;
            cmbEstante.Location = new Point(224, 253);
            cmbEstante.Name = "cmbEstante";
            cmbEstante.Size = new Size(151, 28);
            cmbEstante.TabIndex = 23;
            // 
            // label1
            // 
            label1.Location = new Point(97, 142);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 25;
            label1.Text = "PRECIO VENTA";
            // 
            // label2
            // 
            label2.Location = new Point(81, 91);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 26;
            label2.Text = "CANTIDAD RECEP";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 404);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(cmbEstante);
            Controls.Add(label3);
            Controls.Add(cmbPasillo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCantidadRecepcion);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidadRecepcion;
        private TextBox txtPrecioVenta;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label3;
        private ComboBox cmbPasillo;
        private Label label4;
        private ComboBox cmbEstante;
        private Label label1;
        private Label label2;
    }
}