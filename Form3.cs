using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial
{
    public partial class Form3 : Form
    {

        public int Cantidad { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCantidad.Clear();


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar la entrada para la cantidad
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                Cantidad = cantidad;
                DialogResult = DialogResult.OK; // Indica que se aceptó la operación
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero mayor que 0).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Permite al usuario cerrar el formulario sin realizar cambios
            DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}   
