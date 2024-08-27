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
    public partial class RecepcionControl : UserControl
    {
        public RecepcionControl()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 600); // Ajusta el tamaño mínimo según sea necesario
        }

        private void RecepcionControl_Load(object sender, EventArgs e)
        {
            // Configurar columnas del DataGridView para productos disponibles
            ConfigurarColumnasProductosDisponibles();
            // Configurar columnas del DataGridView para productos recepcionados
            ConfigurarColumnasProductosRecepcionados();
            // Cargar productos disponibles en el DataGridView
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
            dgvProductosDisponibles.Columns.Add("colEstatus", "Estatus");
            dgvProductosDisponibles.Columns.Add("colPrecioCompra", "Precio Compra");
            dgvProductosDisponibles.Columns.Add("colCantidadComprada", "Cantidad Comprada");
        }

        private void ConfigurarColumnasProductosRecepcionados()
        {
            dgvProductosRecepcionados.Columns.Clear();
            dgvProductosRecepcionados.Columns.Add("colId", "ID");
            dgvProductosRecepcionados.Columns.Add("colCodigo", "Código");
            dgvProductosRecepcionados.Columns.Add("colNombre", "Nombre");
            dgvProductosRecepcionados.Columns.Add("colCategoria", "Categoría");
            dgvProductosRecepcionados.Columns.Add("colMarca", "Marca");
            dgvProductosRecepcionados.Columns.Add("colEstatus", "Estatus");
            dgvProductosRecepcionados.Columns.Add("colPrecioVenta", "Precio Venta");
            dgvProductosRecepcionados.Columns.Add("colCantidadRecepcionada", "Cantidad Recepcionada");
            dgvProductosRecepcionados.Columns.Add("colPasillo", "Pasillo");
            dgvProductosRecepcionados.Columns.Add("colEstante", "Estante");
            dgvProductosRecepcionados.Columns.Add("colGanancia", "Ganancia"); // Colocar la columna de Ganancia al final
        }

        private void CargarProductosDisponibles()
        {
            // Lógica para cargar productos disponibles. Este es un ejemplo estático, reemplázalo con tu lógica dinámica.
            dgvProductosDisponibles.Rows.Add(1, "P001", "Producto A", "Categoría A", "Marca X", "Disponible", 10.00, 50);
            dgvProductosDisponibles.Rows.Add(2, "P002", "Producto B", "Categoría B", "Marca Y", "Disponible", 15.00, 30);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductosDisponibles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar.");
                return;
            }

            // Obtener la fila seleccionada del DataGridView de productos disponibles
            DataGridViewRow selectedRow = dgvProductosDisponibles.SelectedRows[0];

            // Obtener la cantidad comprada actual y el precio de compra
            int cantidadComprada = Convert.ToInt32(selectedRow.Cells["colCantidadComprada"].Value);
            decimal precioCompra = Convert.ToDecimal(selectedRow.Cells["colPrecioCompra"].Value);

            // Abrir el Form2 para ingresar la cantidad a recepcionar, el nuevo precio de venta, y el pasillo y estante
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    int cantidadRecepcionada = form2.CantidadRecepcionada;
                    decimal nuevoPrecioVenta = form2.PrecioVenta;
                    string pasillo = form2.Pasillo;
                    string estante = form2.Estante;

                    // Validar que la cantidad a recepcionar no sea mayor a la cantidad disponible
                    if (cantidadRecepcionada > cantidadComprada)
                    {
                        MessageBox.Show("La cantidad a recepcionar no puede ser mayor que la cantidad comprada.");
                        return;
                    }

                    // Calcular la ganancia individual
                    decimal gananciaIndividual = CalcularGanancia(precioCompra, nuevoPrecioVenta, cantidadRecepcionada);

                    // Actualizar la cantidad comprada en el DataGridView de productos disponibles
                    int nuevaCantidadComprada = cantidadComprada - cantidadRecepcionada;
                    selectedRow.Cells["colCantidadComprada"].Value = nuevaCantidadComprada;

                    // Agregar el producto recepcionado al DataGridView de productos recepcionados
                    dgvProductosRecepcionados.Rows.Add(
                        selectedRow.Cells["colId"].Value,
                        selectedRow.Cells["colCodigo"].Value,
                        selectedRow.Cells["colNombre"].Value,
                        selectedRow.Cells["colCategoria"].Value,
                        selectedRow.Cells["colMarca"].Value,
                        selectedRow.Cells["colEstatus"].Value,
                        nuevoPrecioVenta,
                        cantidadRecepcionada,
                        pasillo,
                        estante,
                        gananciaIndividual // Agregar ganancia individual a la última columna
                    );

                    // Actualizar la ganancia total en el label
                    ActualizarGananciaTotal();

                    MessageBox.Show("Producto agregado al inventario de recepción.");
                }
            }
        }

        private decimal CalcularGanancia(decimal precioCompra, decimal precioVenta, int cantidad)
        {
            // Calcular la ganancia por unidad y multiplicar por la cantidad
            decimal gananciaPorUnidad = precioVenta - precioCompra;
            return gananciaPorUnidad * cantidad;
        }

        private void ActualizarGananciaTotal()
        {
            decimal gananciaTotal = 0;

            // Calcular la suma de todas las ganancias individuales en el DataGridView de productos recepcionados
            foreach (DataGridViewRow row in dgvProductosRecepcionados.Rows)
            {
                if (row.Cells["colGanancia"].Value != null)
                {
                    gananciaTotal += Convert.ToDecimal(row.Cells["colGanancia"].Value);
                }
            }

            lblGanancia.Text = $"Ganancia Total: {gananciaTotal:C2}";
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductosRecepcionados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para quitar.");
                return;
            }

            // Obtener la fila seleccionada del DataGridView de productos recepcionados
            DataGridViewRow selectedRow = dgvProductosRecepcionados.SelectedRows[0];

            // Obtener los datos necesarios para revertir la acción
            int cantidadRecepcionada = Convert.ToInt32(selectedRow.Cells["colCantidadRecepcionada"].Value);
            int idProducto = Convert.ToInt32(selectedRow.Cells["colId"].Value);

            // Encontrar el producto en el DataGridView de productos disponibles
            foreach (DataGridViewRow row in dgvProductosDisponibles.Rows)
            {
                if (Convert.ToInt32(row.Cells["colId"].Value) == idProducto)
                {
                    // Revertir la cantidad comprada
                    int cantidadCompradaActual = Convert.ToInt32(row.Cells["colCantidadComprada"].Value);
                    row.Cells["colCantidadComprada"].Value = cantidadCompradaActual + cantidadRecepcionada;
                    break;
                }
            }

            // Quitar el producto de la tabla de productos recepcionados
            dgvProductosRecepcionados.Rows.Remove(selectedRow);

            // Actualizar la ganancia total en el label
            ActualizarGananciaTotal();

            MessageBox.Show("Producto removido del inventario de recepción.");
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductosRecepcionados.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para confirmar.");
                return;
            }

            StringBuilder factura = new StringBuilder();
            decimal gananciaTotalFactura = 0;

            factura.AppendLine("Factura de Recepción de Productos");
            factura.AppendLine("---------------------------------");

            // Recorrer todos los productos recepcionados para generar la factura
            foreach (DataGridViewRow row in dgvProductosRecepcionados.Rows)
            {
                if (row.Cells["colCodigo"].Value == null ||
                    row.Cells["colNombre"].Value == null ||
                    row.Cells["colPrecioVenta"].Value == null ||
                    row.Cells["colCantidadRecepcionada"].Value == null ||
                    row.Cells["colGanancia"].Value == null)
                {
                    continue; // Si alguna celda es null, salta a la siguiente fila
                }

                string codigo = row.Cells["colCodigo"].Value.ToString();
                string nombre = row.Cells["colNombre"].Value.ToString();
                decimal precioVenta = Convert.ToDecimal(row.Cells["colPrecioVenta"].Value);
                int cantidad = Convert.ToInt32(row.Cells["colCantidadRecepcionada"].Value);
                decimal ganancia = Convert.ToDecimal(row.Cells["colGanancia"].Value);

                // Sumar ganancia total para la factura
                gananciaTotalFactura += ganancia;

                // Añadir detalles del producto a la factura
                factura.AppendLine($"Código: {codigo}, Nombre: {nombre}, Precio Venta: {precioVenta:C2}, Cantidad: {cantidad}, Ganancia: {ganancia:C2}");
            }

            factura.AppendLine("---------------------------------");
            factura.AppendLine($"Ganancia Total de la Factura: {gananciaTotalFactura:C2}");

            MessageBox.Show(factura.ToString(), "Factura Generada");

            // Limpiar productos recepcionados después de confirmar
            dgvProductosRecepcionados.Rows.Clear();
            lblGanancia.Text = "Ganancia Total: $0.00";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
