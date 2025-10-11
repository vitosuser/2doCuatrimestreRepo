using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstructurasDinamicasParte2.Diccionario
{
    public partial class FormEj2Diccionario : Form
    {
        Dictionary<string, int> productos = new Dictionary<string, int>();
        public FormEj2Diccionario()
        {
            InitializeComponent();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblNombre.Visible = true;
                lblSKU.Visible = true;

                txtNombre.Visible = true;
                txtSKU.Visible = true;

                btnAgregar.Visible = true;

                btnBuscar.Visible = false;
            }
        }

        private void rdioBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioBuscar.Checked)
            {
                lblNombre.Visible = true;
                lblSKU.Visible = false;

                txtNombre.Visible = true;
                txtSKU.Visible = false;

                btnAgregar.Visible = false;

                btnBuscar.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim().ToLower();
            string codigo = txtSKU.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(nombre))
            {
                if (int.TryParse(codigo, out int SKU))
                {
                    if (!productos.ContainsKey(nombre))
                    {
                        productos.Add(nombre, SKU);
                        listMostrar.Items.Add($"Nombre: {nombre} -- SKU: {SKU}");
                    }
                    else
                    {
                        MessageBox.Show("El producto ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero valido en la casilla \"Codigo SKU\"");

                }
            }
            else
            {
                MessageBox.Show("La casilla \"Nombre\" esta vacia");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cantProductos = productos.Count;

            if (cantProductos != 0)
            {
                string nombre = txtNombre.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(nombre))
                {
                    if (productos.ContainsKey(nombre))
                    {
                        MessageBox.Show($"Producto Encontrado !! \n Nombre: {nombre} -- SKU.: {productos[nombre]}");
                    }
                    else
                    {
                        MessageBox.Show($"No se encontro el producto \"{nombre}\"");
                    }
                }
                else
                {
                    MessageBox.Show("La casilla \"Nombre\" esta vacia");

                }
            }
            else
            {
                MessageBox.Show("No se agregaron productos. El catalogo esta vacio");
            }
        }
    }
}
