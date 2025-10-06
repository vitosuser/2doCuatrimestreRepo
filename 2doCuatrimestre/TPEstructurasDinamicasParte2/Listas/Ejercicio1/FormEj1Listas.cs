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
            if (rdioMostrar.Checked)
            {
                lblNombre.Visible = false;
                lblCantidad.Visible = false;
                txtNombre.Visible = false;
                txtCantidad.Visible = false;
                txtMostrar.Visible = true;

                //desactivo los botones
                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnBuscar.Visible = false;
                btnBuscar.Enabled = false;
            }
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
                txtMostrar.Visible = false;

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
                txtMostrar.Visible = false;

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
                txtMostrar.Visible = false;

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

            if(!string.IsNullOrEmpty(nombre))
            {
                if(int.TryParse(txtCantidad.Text, out int cantidad))
                {

                    lista.Add(new Productos(nombre, cantidad));
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numero en Cantidad");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de producto");
            }
        }
    }
}
