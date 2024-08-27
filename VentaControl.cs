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
    public partial class VentaControl : UserControl
    {
        private decimal descuentoAplicado = 0; // Variable para almacenar el descuento aplicado

        public VentaControl()
        {
            InitializeComponent();
        }

        private void VentaControl_Load(object sender, EventArgs e)
        {
            // Configurar las columnas del DataGridView para productos disponibles
            ConfigurarColumnasProductosDisponibles();
            // Configurar las columnas del DataGridView para productos de la orden
            ConfigurarColumnasProductosOrden();
            // Cargar clientes y productos disponibles
            CargarClientes();
            CargarProductosDisponibles();
        }

        private void ConfigurarColumnasProductosDisponibles()
        {
            dgvProductosDisponibles.Columns.Clear();
            dgvProductosDisponibles.Columns.Add("colId", "ID");
            dgvProductosDisponibles.Columns.Add("colCodigo", "Código");
            dgvProductosDisponibles.Columns.Add("colNombre", "Nombre");
            dgvProductosDisponibles.Columns.Add("colCategoria", "Categoría");
            dgvProductosDisponibles.Columns.Add("colMarca", "Marca");
            dgvProductosDisponibles.Columns.Add("colPrecioVenta", "Precio Venta");
            dgvProductosDisponibles.Columns.Add("colCantidadDisponible", "Cantidad Disponible");
        }

        private void ConfigurarColumnasProductosOrden()
        {
            dgvProductosOrden.Columns.Clear();
            dgvProductosOrden.Columns.Add("colId", "ID");
            dgvProductosOrden.Columns.Add("colCodigo", "Código");
            dgvProductosOrden.Columns.Add("colNombre", "Nombre");
            dgvProductosOrden.Columns.Add("colPrecioVenta", "Precio Venta");
            dgvProductosOrden.Columns.Add("colCantidad", "Cantidad");
            dgvProductosOrden.Columns.Add("colSubtotal", "Subtotal");
        }

        private void CargarClientes()
        {
            // Simular la carga de clientes. Reemplazar con la lógica real de carga.
            cmbClientes.Items.Add("Cliente A");
            cmbClientes.Items.Add("Cliente B");
            cmbClientes.Items.Add("Cliente C");
        }

        private void CargarProductosDisponibles()
        {
            // Simular la carga de productos disponibles. Reemplazar con la lógica real de carga.
            dgvProductosDisponibles.Rows.Add(1, "P001", "Producto A", "Categoría A", "Marca X", 12.00, 50);
            dgvProductosDisponibles.Rows.Add(2, "P002", "Producto B", "Categoría B", "Marca Y", 20.00, 30);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProductosDisponibles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar.");
                return;
            }

            DataGridViewRow selectedRow = dgvProductosDisponibles.SelectedRows[0];
            int cantidadDisponible = Convert.ToInt32(selectedRow.Cells["colCantidadDisponible"].Value);

            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    int cantidad = form3.Cantidad;

                    if (cantidad > cantidadDisponible)
                    {
                        MessageBox.Show("La cantidad a vender no puede ser mayor que la cantidad disponible.");
                        return;
                    }

                    decimal precioVenta = Convert.ToDecimal(selectedRow.Cells["colPrecioVenta"].Value);
                    decimal subtotal = precioVenta * cantidad;

                    dgvProductosOrden.Rows.Add(
                        selectedRow.Cells["colId"].Value ?? 0, // Valor predeterminado si es nulo
                        selectedRow.Cells["colCodigo"].Value ?? string.Empty, // Valor predeterminado si es nulo
                        selectedRow.Cells["colNombre"].Value ?? string.Empty, // Valor predeterminado si es nulo
                        precioVenta,
                        cantidad,
                        subtotal
                    );

                    int nuevaCantidadDisponible = cantidadDisponible - cantidad;
                    selectedRow.Cells["colCantidadDisponible"].Value = nuevaCantidadDisponible;

                    ActualizarTotalGeneral();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvProductosOrden.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para quitar.");
                return;
            }

            DataGridViewRow selectedRow = dgvProductosOrden.SelectedRows[0];
            int cantidad = Convert.ToInt32(selectedRow.Cells["colCantidad"].Value);
            string codigoProducto = selectedRow.Cells["colCodigo"].Value.ToString();

            // Buscar el producto en la tabla de productos disponibles para devolver la cantidad
            foreach (DataGridViewRow row in dgvProductosDisponibles.Rows)
            {
                if (row.Cells["colCodigo"].Value.ToString() == codigoProducto)
                {
                    int cantidadDisponible = Convert.ToInt32(row.Cells["colCantidadDisponible"].Value);
                    row.Cells["colCantidadDisponible"].Value = cantidadDisponible + cantidad;
                    break;
                }
            }

            // Eliminar la fila seleccionada de la tabla de productos de la orden
            dgvProductosOrden.Rows.Remove(selectedRow);

            // Actualizar el total general
            ActualizarTotalGeneral();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de confirmar la venta.");
                return;
            }

            if (dgvProductosOrden.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la orden para confirmar.");
                return;
            }

            StringBuilder factura = new StringBuilder();
            decimal totalFactura = 0;

            factura.AppendLine("Factura de Venta");
            factura.AppendLine("------------------------------");

            foreach (DataGridViewRow row in dgvProductosOrden.Rows)
            {
                if (row.Cells["colCodigo"].Value == null ||
                    row.Cells["colNombre"].Value == null ||
                    row.Cells["colPrecioVenta"].Value == null ||
                    row.Cells["colCantidad"].Value == null ||
                    row.Cells["colSubtotal"].Value == null)
                {
                    continue; // Si alguna celda es null, salta a la siguiente fila
                }

                string codigo = row.Cells["colCodigo"].Value.ToString();
                string nombre = row.Cells["colNombre"].Value.ToString();
                decimal precioVenta = Convert.ToDecimal(row.Cells["colPrecioVenta"].Value);
                int cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["colSubtotal"].Value);

                totalFactura += subtotal;

                factura.AppendLine($"Código: {codigo}, Nombre: {nombre}, Precio Venta: {precioVenta:C2}, Cantidad: {cantidad}, Subtotal: {subtotal:C2}");
            }

            factura.AppendLine("------------------------------");
            factura.AppendLine($"Subtotal de la Factura: {totalFactura:C2}");

            if (descuentoAplicado > 0)
            {
                factura.AppendLine($"Descuento Aplicado: -{descuentoAplicado:C2}");
                factura.AppendLine($"Total a Pagar: {(totalFactura - descuentoAplicado):C2}");
            }
            else
            {
                factura.AppendLine($"Total a Pagar: {totalFactura:C2}");
            }

            MessageBox.Show(factura.ToString(), "Factura Generada");

            // Limpiar productos de la orden después de confirmar
            dgvProductosOrden.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
            descuentoAplicado = 0; // Restablecer el descuento aplicado
        }

        private void ActualizarTotalGeneral()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductosOrden.Rows)
            {
                if (row.Cells["colSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
                }
            }

            lblTotal.Text = $"Total: {total:C2}";
        }

        private void btnDescuento_Click_1(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente clienteSeleccionado = ObtenerClientePorNombre(cmbClientes.SelectedItem.ToString());

            using (FormDescuento formDescuento = new FormDescuento(clienteSeleccionado))
            {
                if (formDescuento.ShowDialog() == DialogResult.OK)
                {
                    // Calcular el descuento basado en puntos y gift cards
                    descuentoAplicado = 0; // Restablecer descuento anterior
                    if (formDescuento.UsarPuntos)
                    {
                        int puntosUsados = formDescuento.PuntosUsados;
                        descuentoAplicado += CalcularDescuentoPorPuntos(puntosUsados);
                        clienteSeleccionado.Puntos -= puntosUsados;
                    }

                    if (formDescuento.UsarGiftCard)
                    {
                        decimal saldoUsado = formDescuento.SaldoUsado;
                        descuentoAplicado += saldoUsado;
                        clienteSeleccionado.SaldoGiftCard -= saldoUsado;
                    }

                    // Aplicar el descuento al total
                    AplicarDescuento(descuentoAplicado);

                    // Actualizar visualmente los puntos y el saldo del cliente en la interfaz
                    ActualizarInformacionCliente(clienteSeleccionado);
                }
            }
        }

        private decimal CalcularDescuentoPorPuntos(int puntos)
        {
            return puntos / 10m; // 10 puntos equivalen a $1 de descuento
        }

        private void AplicarDescuento(decimal descuento)
        {
            decimal totalActual = ObtenerTotalActual();
            decimal nuevoTotal = totalActual - descuento;
            lblTotal.Text = $"Total: {nuevoTotal:C2}";
        }

        private decimal ObtenerTotalActual()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductosOrden.Rows)
            {
                if (row.Cells["colSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
                }
            }

            return total;
        }

        private Cliente ObtenerClientePorNombre(string nombreCliente)
        {
            // Implementa la lógica para obtener el cliente según el nombre
            // Aquí deberías acceder a tu lista de clientes y devolver el objeto cliente correspondiente.
            // Reemplazar con la lógica real:
            return new Cliente { Nombre = nombreCliente, Puntos = 100, SaldoGiftCard = 50.00m };
        }

        private void ActualizarInformacionCliente(Cliente cliente)
        {
            // Lógica para actualizar visualmente la información del cliente después de aplicar un descuento
            MessageBox.Show($"Puntos restantes: {cliente.Puntos}\nSaldo de Gift Card restante: {cliente.SaldoGiftCard:C2}",
                            "Información del Cliente Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

