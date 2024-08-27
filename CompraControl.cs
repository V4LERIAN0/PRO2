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
    public partial class CompraControl : UserControl, IVolverControl
    {
        public event EventHandler VolverClicked;
        private List<Producto> carritoCompras = new List<Producto>();
        private int currentId = 1; // Variable para manejar el ID autoincremental

        public CompraControl()
        {
            InitializeComponent();
            dgvCarritoCompras.SelectionChanged += DgvCarritoCompras_SelectionChanged; // Añadir manejador para el evento de selección
        }

        private void CompraControl_Load(object sender, EventArgs e)
        {
            // Configurar columnas del DataGridView
            dgvCarritoCompras.Columns.Clear();
            dgvCarritoCompras.Columns.Add("colId", "ID");
            dgvCarritoCompras.Columns.Add("colCodigo", "Código");
            dgvCarritoCompras.Columns.Add("colNombreProducto", "Producto");
            dgvCarritoCompras.Columns.Add("colCantidad", "Cantidad");
            dgvCarritoCompras.Columns.Add("colPrecioCompra", "Precio Compra");
            dgvCarritoCompras.Columns.Add("colCategoria", "Categoría");
            dgvCarritoCompras.Columns.Add("colMarca", "Marca");
            dgvCarritoCompras.Columns.Add("colEstatus", "Estatus");
            dgvCarritoCompras.Columns.Add("colProveedor", "Proveedor");
            dgvCarritoCompras.Columns.Add("colTotal", "Total"); // Nueva columna para el total

            // Inicializar ComboBoxes
            cmbCategoria.Items.AddRange(new string[] { "Categoría A", "Categoría B", "Categoría C" });
            cmbMarca.Items.AddRange(new string[] { "Marca X", "Marca Y", "Marca Z" });
            cmbEstatus.Items.AddRange(new string[] { "Disponible", "No disponible" });
            cmbProveedor.Items.AddRange(new string[] { "Proveedor A", "Proveedor B", "Proveedor C" });

            // Inicializar el ID del producto
            txtId.Text = currentId.ToString();
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || !txtNombreProducto.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre del producto solo puede contener letras.");
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out _))
            {
                MessageBox.Show("El precio de compra debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un número entero.");
                return;
            }

            try
            {
                // Validar que todos los campos estén llenos
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                    cmbProveedor.SelectedIndex == -1 ||
                    cmbCategoria.SelectedIndex == -1 ||
                    cmbMarca.SelectedIndex == -1 ||
                    cmbEstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.");
                    return;
                }

                // Convertir los valores a los tipos correctos
                string codigoProducto = txtCodigo.Text;
                string nombreProducto = txtNombreProducto.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precioCompra = decimal.Parse(txtPrecioCompra.Text);
                string proveedor = cmbProveedor.SelectedItem.ToString();
                string categoria = cmbCategoria.SelectedItem.ToString();
                string marca = cmbMarca.SelectedItem.ToString();
                string estatus = cmbEstatus.SelectedItem.ToString();

                // Calcular el total para este producto
                decimal totalProducto = cantidad * precioCompra;

                // Crear un nuevo producto y añadirlo al carrito
                Producto nuevoProducto = new Producto(currentId, nombreProducto, precioCompra, cantidad)
                {
                    Codigo = codigoProducto,
                    Categoria = categoria,
                    Marca = marca,
                    Estatus = estatus
                };
                carritoCompras.Add(nuevoProducto);

                // Asegurar que el DataGridView no tiene un DataSource configurado
                dgvCarritoCompras.DataSource = null;

                // Agregar los datos al DataGridView para visualización
                dgvCarritoCompras.Rows.Add(nuevoProducto.Id, nuevoProducto.Codigo, nuevoProducto.Nombre, nuevoProducto.Cantidad, nuevoProducto.PrecioCompra, nuevoProducto.Categoria, nuevoProducto.Marca, nuevoProducto.Estatus, proveedor, totalProducto);

                // Incrementar el ID para el próximo producto
                currentId++;
                txtId.Text = currentId.ToString();

                MessageBox.Show("Producto agregado correctamente al DataGridView.");

                // Actualizar el total general
                ActualizarTotalGeneral();

                // Limpiar los campos después de agregar el producto
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para la cantidad y el precio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
        }

        private void btnConfirmarCompra_Click_1(object sender, EventArgs e)
        {
            // Verificar que haya productos en el carrito
            if (carritoCompras.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para confirmar la compra.");
                return;
            }

            // Generar y mostrar la factura
            GenerarFactura();

            // Limpiar el carrito después de confirmar la compra
            carritoCompras.Clear();
            dgvCarritoCompras.Rows.Clear();
            lblTotal.Text = "Total: $0.00"; // Reiniciar el total general

            MessageBox.Show("Compra confirmada exitosamente.");
        }

        private void GenerarFactura()
        {
            // Crear un nuevo formulario para mostrar la factura
            Form facturaForm = new Form();
            facturaForm.Text = "Factura de Compra";
            facturaForm.Size = new Size(400, 600);

            // Crear un TextBox multilinea para mostrar los detalles de la factura
            TextBox txtFactura = new TextBox();
            txtFactura.Multiline = true;
            txtFactura.Dock = DockStyle.Fill;
            txtFactura.ReadOnly = true;
            txtFactura.ScrollBars = ScrollBars.Vertical;

            // Generar el contenido de la factura
            StringBuilder facturaContent = new StringBuilder();
            facturaContent.AppendLine("Factura de Compra");
            facturaContent.AppendLine("----------------------------");
            facturaContent.AppendLine("ID\tProducto\tCantidad\tPrecio Compra\tSubtotal");
            facturaContent.AppendLine("----------------------------");

            decimal total = 0;

            foreach (Producto producto in carritoCompras)
            {
                decimal subtotal = producto.PrecioCompra * producto.Cantidad;
                total += subtotal;
                facturaContent.AppendLine($"{producto.Id}\t{producto.Nombre}\t{producto.Cantidad}\t{producto.PrecioCompra:C2}\t{subtotal:C2}");
            }

            facturaContent.AppendLine("----------------------------");
            facturaContent.AppendLine($"Total: {total:C2}");

            // Asignar el contenido generado al TextBox
            txtFactura.Text = facturaContent.ToString();

            // Agregar el TextBox al formulario
            facturaForm.Controls.Add(txtFactura);

            // Mostrar el formulario de la factura
            facturaForm.ShowDialog();
        }

        private void ActualizarTotalGeneral()
        {
            decimal totalGeneral = 0;

            foreach (DataGridViewRow row in dgvCarritoCompras.Rows)
            {
                if (row.Cells["colTotal"].Value != null)
                {
                    totalGeneral += Convert.ToDecimal(row.Cells["colTotal"].Value);
                }
            }

            lblTotal.Text = $"Total: {totalGeneral:C2}";
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarritoCompras.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para modificar.");
                    return;
                }

                // Obtener el producto seleccionado
                DataGridViewRow row = dgvCarritoCompras.SelectedRows[0];
                int id = int.Parse(row.Cells["colId"].Value.ToString());
                Producto producto = carritoCompras.FirstOrDefault(p => p.Id == id);

                if (producto != null)
                {
                    // Actualizar los datos del producto
                    producto.Codigo = txtCodigo.Text;
                    producto.Nombre = txtNombreProducto.Text;
                    producto.Cantidad = int.Parse(txtCantidad.Text);
                    producto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                    producto.Categoria = cmbCategoria.SelectedItem.ToString();
                    producto.Marca = cmbMarca.SelectedItem.ToString();
                    producto.Estatus = cmbEstatus.SelectedItem.ToString();

                    // Calcular el nuevo total para el producto modificado
                    decimal totalProducto = producto.Cantidad * producto.PrecioCompra;

                    // Actualizar el DataGridView
                    row.Cells["colCodigo"].Value = producto.Codigo;
                    row.Cells["colNombreProducto"].Value = producto.Nombre;
                    row.Cells["colCantidad"].Value = producto.Cantidad;
                    row.Cells["colPrecioCompra"].Value = producto.PrecioCompra;
                    row.Cells["colCategoria"].Value = producto.Categoria;
                    row.Cells["colMarca"].Value = producto.Marca;
                    row.Cells["colEstatus"].Value = producto.Estatus;
                    row.Cells["colProveedor"].Value = cmbProveedor.SelectedItem.ToString();
                    row.Cells["colTotal"].Value = totalProducto; // Actualizar la columna Total

                    MessageBox.Show("Producto modificado correctamente.");

                    // Actualizar el total general
                    ActualizarTotalGeneral();

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar producto: {ex.Message}");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarritoCompras.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.");
                    return;
                }

                // Obtener el producto seleccionado
                DataGridViewRow row = dgvCarritoCompras.SelectedRows[0];
                int id = int.Parse(row.Cells["colId"].Value.ToString());
                Producto producto = carritoCompras.FirstOrDefault(p => p.Id == id);

                if (producto != null)
                {
                    // Eliminar el producto del carrito y del DataGridView
                    carritoCompras.Remove(producto);
                    dgvCarritoCompras.Rows.Remove(row);

                    MessageBox.Show("Producto eliminado correctamente.");

                    // Actualizar el total general
                    ActualizarTotalGeneral();

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
            }
        }

        private void DgvCarritoCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCarritoCompras.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvCarritoCompras.SelectedRows[0];

                // Evitar error de conversión si alguna celda está vacía
                if (row.Cells["colId"].Value == null ||
                    row.Cells["colCodigo"].Value == null ||
                    row.Cells["colNombreProducto"].Value == null ||
                    row.Cells["colCantidad"].Value == null ||
                    row.Cells["colPrecioCompra"].Value == null ||
                    row.Cells["colCategoria"].Value == null ||
                    row.Cells["colMarca"].Value == null ||
                    row.Cells["colEstatus"].Value == null ||
                    row.Cells["colProveedor"].Value == null ||
                    row.Cells["colTotal"].Value == null)
                {
                    return;
                }

                int id = int.Parse(row.Cells["colId"].Value.ToString());
                Producto producto = carritoCompras.FirstOrDefault(p => p.Id == id);

                if (producto != null)
                {
                    // Mostrar los datos del producto en los campos de texto y comboboxes
                    txtId.Text = producto.Id.ToString();
                    txtCodigo.Text = producto.Codigo;
                    txtNombreProducto.Text = producto.Nombre;
                    txtCantidad.Text = producto.Cantidad.ToString();
                    txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                    cmbCategoria.SelectedItem = producto.Categoria;
                    cmbMarca.SelectedItem = producto.Marca;
                    cmbEstatus.SelectedItem = producto.Estatus;
                    cmbProveedor.SelectedItem = row.Cells["colProveedor"].Value.ToString();
                }
            }
        }

        private void dgvCarritoCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que se selecciona una fila y no un encabezado de columna
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvCarritoCompras.Rows[e.RowIndex];

                // Evitar error de conversión si alguna celda está vacía
                if (row.Cells["colId"].Value == null ||
                    row.Cells["colCodigo"].Value == null ||
                    row.Cells["colNombreProducto"].Value == null ||
                    row.Cells["colCantidad"].Value == null ||
                    row.Cells["colPrecioCompra"].Value == null ||
                    row.Cells["colCategoria"].Value == null ||
                    row.Cells["colMarca"].Value == null ||
                    row.Cells["colEstatus"].Value == null ||
                    row.Cells["colProveedor"].Value == null ||
                    row.Cells["colTotal"].Value == null)
                {
                    return;
                }

                int id = int.Parse(row.Cells["colId"].Value.ToString());
                Producto producto = carritoCompras.FirstOrDefault(p => p.Id == id);

                if (producto != null)
                {
                    // Mostrar los datos del producto en los campos de texto y comboboxes
                    txtId.Text = producto.Id.ToString();
                    txtCodigo.Text = producto.Codigo;
                    txtNombreProducto.Text = producto.Nombre;
                    txtCantidad.Text = producto.Cantidad.ToString();
                    txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                    cmbCategoria.SelectedItem = producto.Categoria;
                    cmbMarca.SelectedItem = producto.Marca;
                    cmbEstatus.SelectedItem = producto.Estatus;
                    cmbProveedor.SelectedItem = row.Cells["colProveedor"].Value.ToString();
                }
            }
        }

        // Validaciones:
        private void ValidarSoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarSoloNumerosEnteros(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (digitos) y teclas de control (como la tecla de retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si el carácter no es un número
            }
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Si ya hay un punto en el campo de texto, impedir otro punto
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void ValidarSinCaracteresEspeciales(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarSinCaracteresEspeciales(e);
        }

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumerosEnteros(sender, e); // Usar la validación solo para números enteros
        }

        private void txtNombreProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(e);
        }

        private void txtPrecioCompra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbEstatus.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            txtId.Text = currentId.ToString(); // Reiniciar el ID mostrado en la interfaz
        }

        private void dgvCarritoCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            VolverClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}

