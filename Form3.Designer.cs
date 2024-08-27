namespace ProyectoParcial
{
    partial class Form3
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
            label2 = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(99, 91);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 30;
            label2.Text = "CANTIDAD";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(225, 167);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(125, 167);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 28;
            btnConfirmar.Text = "OK";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(198, 91);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 27);
            txtCantidad.TabIndex = 27;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 242);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtCantidad);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtCantidad;
    }
}