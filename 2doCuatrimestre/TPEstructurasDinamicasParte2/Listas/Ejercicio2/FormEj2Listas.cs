using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstructurasDinamicasParte2.Listas.Ejercicio2;


namespace TPEstructurasDinamicasParte2.Listas
{
    public partial class FormEj2Listas : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public FormEj2Listas()
        {
            InitializeComponent();
        }

        private void FormEj2Listas_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblNombre.Visible = true;
                txtNombre.Visible = true;

                btnAgregar.Enabled = true;
                btnAgregar.Visible = true;

                btnCompletar.Enabled = false;
                btnCompletar.Visible = false;

            }
        }

        private void rdioCompletada_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioCompletada.Checked)
            {

                lblNombre.Visible = true;
                txtNombre.Visible = true;

                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;

                btnCompletar.Enabled = true;
                btnCompletar.Visible = true;


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(nombre))
            {
                Tarea nueva = new Tarea(nombre);

                tareas.Add(nueva);
                listMostrar.Items.Add(nueva);
            }
            else
            {
                MessageBox.Show("La casilla Nombre esta vacia");
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            string eliminar = txtNombre.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(eliminar))
            {
                Tarea encontrada = tareas.Find(p => p.Nombre.Equals(eliminar, StringComparison.OrdinalIgnoreCase));

                if (encontrada != null)
                {
                    tareas.Remove(encontrada);
                    listMostrar.Items.Remove(encontrada);

                }
                else
                {
                    MessageBox.Show("No se encontro la tarea en la lista");
                }
            }
            else
            {
                MessageBox.Show("La casilla Nombre esta vacia");

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
