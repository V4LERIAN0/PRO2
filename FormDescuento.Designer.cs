namespace ProyectoParcial
{
    partial class FormDescuento
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
            lblPuntosDisponibles = new Label();
            txtPuntosUsar = new TextBox();
            lblGiftCardSaldo = new Label();
            txtGiftCardUsar = new TextBox();
            label3 = new Label();
            txtDescuentoAplicado = new TextBox();
            btnAplicar = new Button();
            btnCancelar = new Button();
            chkUsarPuntos = new CheckBox();
            chkUsarGiftCard = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblPuntosDisponibles
            // 
            lblPuntosDisponibles.AutoSize = true;
            lblPuntosDisponibles.Location = new Point(71, 247);
            lblPuntosDisponibles.Name = "lblPuntosDisponibles";
            lblPuntosDisponibles.Size = new Size(135, 20);
            lblPuntosDisponibles.TabIndex = 0;
            lblPuntosDisponibles.Text = "Puntos Disponibles";
            // 
            // txtPuntosUsar
            // 
            txtPuntosUsar.Location = new Point(256, 247);
            txtPuntosUsar.Name = "txtPuntosUsar";
            txtPuntosUsar.Size = new Size(125, 27);
            txtPuntosUsar.TabIndex = 1;
            // 
            // lblGiftCardSaldo
            // 
            lblGiftCardSaldo.AutoSize = true;
            lblGiftCardSaldo.Location = new Point(100, 304);
            lblGiftCardSaldo.Name = "lblGiftCardSaldo";
            lblGiftCardSaldo.Size = new Size(106, 20);
            lblGiftCardSaldo.TabIndex = 2;
            lblGiftCardSaldo.Text = "Saldo GiftCard";
            // 
            // txtGiftCardUsar
            // 
            txtGiftCardUsar.Location = new Point(256, 301);
            txtGiftCardUsar.Name = "txtGiftCardUsar";
            txtGiftCardUsar.Size = new Size(125, 27);
            txtGiftCardUsar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 366);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 4;
            label3.Text = "Descuento Calculado";
            // 
            // txtDescuentoAplicado
            // 
            txtDescuentoAplicado.Location = new Point(256, 366);
            txtDescuentoAplicado.Name = "txtDescuentoAplicado";
            txtDescuentoAplicado.Size = new Size(125, 27);
            txtDescuentoAplicado.TabIndex = 5;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(112, 435);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(94, 29);
            btnAplicar.TabIndex = 6;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(256, 435);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // chkUsarPuntos
            // 
            chkUsarPuntos.AutoSize = true;
            chkUsarPuntos.Location = new Point(122, 170);
            chkUsarPuntos.Name = "chkUsarPuntos";
            chkUsarPuntos.Size = new Size(75, 24);
            chkUsarPuntos.TabIndex = 8;
            chkUsarPuntos.Text = "Puntos";
            chkUsarPuntos.UseVisualStyleBackColor = true;
            // 
            // chkUsarGiftCard
            // 
            chkUsarGiftCard.AutoSize = true;
            chkUsarGiftCard.Location = new Point(245, 170);
            chkUsarGiftCard.Name = "chkUsarGiftCard";
            chkUsarGiftCard.Size = new Size(92, 24);
            chkUsarGiftCard.TabIndex = 9;
            chkUsarGiftCard.Text = "GiftCards";
            chkUsarGiftCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 136);
            label1.Name = "label1";
            label1.Size = new Size(311, 20);
            label1.TabIndex = 10;
            label1.Text = "SELECCIONE EL TIPO DE DESCUENTO A USAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 76);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 11;
            label2.Text = "10 PUNTOS = $ 1";
            // 
            // FormDescuento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 511);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkUsarGiftCard);
            Controls.Add(chkUsarPuntos);
            Controls.Add(btnCancelar);
            Controls.Add(btnAplicar);
            Controls.Add(txtDescuentoAplicado);
            Controls.Add(label3);
            Controls.Add(txtGiftCardUsar);
            Controls.Add(lblGiftCardSaldo);
            Controls.Add(txtPuntosUsar);
            Controls.Add(lblPuntosDisponibles);
            Name = "FormDescuento";
            Text = "FormDescuento";
            Load += FormDescuento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuntosDisponibles;
        private TextBox txtPuntosUsar;
        private Label lblGiftCardSaldo;
        private TextBox txtGiftCardUsar;
        private Label label3;
        private TextBox txtDescuentoAplicado;
        private Button btnAplicar;
        private Button btnCancelar;
        private CheckBox chkUsarPuntos;
        private CheckBox chkUsarGiftCard;
        private Label label1;
        private Label label2;
    }
}