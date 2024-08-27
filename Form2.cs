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
    public partial class Form2 : Form
    {
        // Propiedades públicas para obtener los valores ingresados
        public int CantidadRecepcionada { get; private set; }
        public decimal PrecioVenta { get; private set; }
        public string Pasillo { get; private set; }
        public string Estante { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Configuración inicial de los TextBox
            txtCantidadRecepcion.Clear();
            txtPrecioVenta.Clear();

            // Configuración inicial de los ComboBox
            cmbPasillo.Items.Clear();
            cmbEstante.Items.Clear();

            cmbPasillo.Items.AddRange(new string[] { "Pasillo 1", "Pasillo 2", "Pasillo 3" });
            cmbEstante.Items.AddRange(new string[] { "Estante A", "Estante B", "Estante C" });

            // Opcional: Selecciona el primer elemento de cada ComboBox por defecto si lo deseas
            cmbPasillo.SelectedIndex = 0;
            cmbEstante.SelectedIndex = 0;
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            // Validar la entrada para la cantidad
            if (int.TryParse(txtCantidadRecepcion.Text, out int cantidad) && cantidad > 0)
            {
                // Validar la entrada para el precio de venta
                if (decimal.TryParse(txtPrecioVenta.Text, out decimal precio) && precio > 0)
                {
                    // Validar que se haya seleccionado un pasillo y un estante
                    if (cmbPasillo.SelectedIndex != -1 && cmbEstante.SelectedIndex != -1)
                    {
                        CantidadRecepcionada = cantidad;
                        PrecioVenta = precio;
                        Pasillo = cmbPasillo.SelectedItem.ToString();
                        Estante = cmbEstante.SelectedItem.ToString();

                        DialogResult = DialogResult.OK;
                        this.Close(); // Cerrar el formulario si todo está correcto
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un pasillo y un estante.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un precio de venta válido (mayor que 0).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero mayor que 0).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Permite al usuario cerrar el formulario sin realizar cambios
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

