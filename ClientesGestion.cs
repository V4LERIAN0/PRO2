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
    public partial class ClientesGestion : UserControl
    {
        // Simulamos una base de datos en memoria
        private List<Cliente> clientes = new List<Cliente>();
        private int nextId = 1; // Controla el próximo ID a asignar

        public ClientesGestion()
        {
            InitializeComponent();
            ConfigurarColumnasClientes();
            CargarClientes();
        }

        private void ConfigurarColumnasClientes()
        {
            dgvClientes.Columns.Clear(); // Limpiar cualquier columna existente

            // Agregar columnas al DataGridView y establecer su ancho
            dgvClientes.Columns.Add("colId", "ID");
            dgvClientes.Columns["colId"].Width = 50; // Ajusta el ancho de la columna ID

            dgvClientes.Columns.Add("colCodigo", "Código");
            dgvClientes.Columns["colCodigo"].Width = 80; // Ajusta el ancho de la columna Código

            dgvClientes.Columns.Add("colNombres", "Nombres");
            dgvClientes.Columns["colNombres"].Width = 150; // Ajusta el ancho de la columna Nombres

            dgvClientes.Columns.Add("colApellidos", "Apellidos");
            dgvClientes.Columns["colApellidos"].Width = 150; // Ajusta el ancho de la columna Apellidos

            dgvClientes.Columns.Add("colCorreo", "Correo");
            dgvClientes.Columns["colCorreo"].Width = 180; // Ajusta el ancho de la columna Correo

            dgvClientes.Columns.Add("colTelefono", "Teléfono");
            dgvClientes.Columns["colTelefono"].Width = 110; // Ajusta el ancho de la columna Teléfono

            dgvClientes.Columns.Add("colDireccion", "Dirección");
            dgvClientes.Columns["colDireccion"].Width = 750; // Ajusta el ancho de la columna Dirección

            // Definir la columna de ID como solo lectura porque es autoincremental
            dgvClientes.Columns["colId"].ReadOnly = true;
        }

        private void CargarClientes()
        {
            // Limpiar DataGridView antes de cargar
            dgvClientes.Rows.Clear();

            // Cargar clientes en el DataGridView
            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(cliente.Id, cliente.Codigo, cliente.Nombres, cliente.Apellidos, cliente.Correo, cliente.Telefono, cliente.Direccion);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (!ValidarCampos())
            {
                return;
            }

            // Crear y agregar nuevo cliente
            Cliente nuevoCliente = new Cliente
            {
                Id = nextId++, // Asignar ID autoincrementable
                Codigo = txtCodigo.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDirreccion.Text
            };

            clientes.Add(nuevoCliente);
            CargarClientes();
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDirreccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de correo
            if (!IsValidEmail(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de teléfono (solo números y longitud específica)
            if (!long.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length < 8 || txtTelefono.Text.Length > 15)
            {
                MessageBox.Show("Ingrese un número de teléfono válido (solo números, entre 8 y 15 dígitos).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar código único al agregar (no al modificar)
            if (dgvClientes.SelectedRows.Count == 0 && clientes.Any(c => c.Codigo == txtCodigo.Text))
            {
                MessageBox.Show("El código de cliente ya existe.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para modificar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            int selectedIndex = dgvClientes.SelectedRows[0].Index;
            Cliente clienteExistente = clientes[selectedIndex];

            // Validar código único solo si se cambia el código
            if (clientes.Any(c => c.Codigo == txtCodigo.Text && c.Id != clienteExistente.Id))
            {
                MessageBox.Show("El código de cliente ya existe en otro registro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Modificar los datos del cliente (excepto el ID)
            clienteExistente.Codigo = txtCodigo.Text;
            clienteExistente.Nombres = txtNombres.Text;
            clienteExistente.Apellidos = txtApellidos.Text;
            clienteExistente.Correo = txtCorreo.Text;
            clienteExistente.Telefono = txtTelefono.Text;
            clienteExistente.Direccion = txtDirreccion.Text;

            CargarClientes();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                int selectedIndex = dgvClientes.SelectedRows[0].Index;
                clientes.RemoveAt(selectedIndex);
                CargarClientes();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            // No se limpia txtId porque es autoincrementable
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDirreccion.Clear();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Rellenar los campos de texto con los datos seleccionados para modificación
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];
                txtCodigo.Text = selectedRow.Cells["colCodigo"].Value.ToString();
                txtNombres.Text = selectedRow.Cells["colNombres"].Value.ToString();
                txtApellidos.Text = selectedRow.Cells["colApellidos"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["colCorreo"].Value.ToString();
                txtTelefono.Text = selectedRow.Cells["colTelefono"].Value.ToString();
                txtDirreccion.Text = selectedRow.Cells["colDireccion"].Value.ToString();
            }
        }

        private void ClientesGestion_Load(object sender, EventArgs e)
        {
            // Configurar el evento de cambio de selección del DataGridView
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
        }
    }
}
