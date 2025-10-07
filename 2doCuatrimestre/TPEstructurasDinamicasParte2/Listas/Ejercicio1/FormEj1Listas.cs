using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstructurasDinamicasParte2.Listas.Ejercicio1;

namespace TPEstructurasDinamicasParte2.Listas
{
    public partial class FormEj1Listas : Form
    {
        List<Productos> lista = new List<Productos>();


        public FormEj1Listas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void rdioMostrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblNombre.Visible = true;
                lblCantidad.Visible = true;
                txtNombre.Visible = true;
                txtCantidad.Visible = true;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                btnAgregar.Visible = true;
                btnAgregar.Enabled = true;

                btnBuscar.Visible = false;
                btnBuscar.Enabled = false;

            }
        }

        private void rdioBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioBuscar.Checked)
            {
                lblNombre.Visible = true;
                lblCantidad.Visible = false;
                txtNombre.Visible = true;
                txtCantidad.Visible = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnBuscar.Visible = true;
                btnBuscar.Enabled = true;
            }
        }

        private void rdioEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioEliminar.Checked)
            {
                lblNombre.Visible = true;
                lblCantidad.Visible = false;
                txtNombre.Visible = true;
                txtCantidad.Visible = false;

                btnEliminar.Visible = true;
                btnEliminar.Enabled = true;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnBuscar.Visible = false;
                btnBuscar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;


            if (!string.IsNullOrEmpty(nombre))
            {
                if (int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    Productos nuevo = new Productos(nombre, cantidad);

                    lista.Add(nuevo);
                    listMostrar.Items.Add(nuevo); //para agregarlo a la lista
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numerico en Cantidad");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de producto");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = txtNombre.Text.Trim().ToLower(); //ignoro espacios blancos y mayus

            if (!string.IsNullOrEmpty(eliminar))
            {
                Productos eliminado = lista.Find(producto => producto.Nombre.Equals(eliminar, StringComparison.OrdinalIgnoreCase));

                if (eliminado != null)
                {
                    lista.Remove(eliminado);
                    listMostrar.Items.Remove(eliminado);

                }
                else
                {
                    MessageBox.Show("No se encontro el producto en la lista");
                }
            }
            else
            {
                MessageBox.Show("La casilla Nombre esta vacia");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = txtNombre.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(buscado))
            {
                Productos encontrado = lista.Find(p => p.Nombre.Equals(buscado, StringComparison.OrdinalIgnoreCase));

                if (encontrado != null)
                {
                    MessageBox.Show($"Producto Encontrado \n{encontrado}");
                }
                else
                {
                    MessageBox.Show("No se encontro el producto en la lista");

                }
            }
            else
            {
                MessageBox.Show("La casilla Nombre esta vacia");

            }
        }

        private void FormEj1Listas_Load(object sender, EventArgs e)
        {

        }
    }
}
