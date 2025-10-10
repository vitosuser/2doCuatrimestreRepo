using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio3
{
    public partial class FormEj3ListasEnlazadas : Form
    {
        private NodoEj3? actual;
        public FormEj3ListasEnlazadas()
        {
            InitializeComponent();
            actual = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtCancion.Text;

            if (!string.IsNullOrEmpty(nombre))
            {
                NodoEj3 nuevo = new NodoEj3(nombre);

                if (actual != null)
                {
                    NodoEj3 aux = actual;

                    while (aux.Siguiente != null)
                    {
                        aux = aux.Siguiente;
                    }

                    aux.Siguiente = nuevo;
                    nuevo.Anterior = aux;


                }
                else
                {
                    actual = nuevo;
                }

                listMostrar.Items.Add(nuevo);
            }
            else
            {
                MessageBox.Show("La casilla Nombre Cancion esta vacia");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblNombre.Visible = true;
                txtCancion.Text = string.Empty;
                txtCancion.Visible = true;

                btnAgregar.Visible = true;
                btnAgregar.Enabled = true;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

            }
        }

        private void rdioSiguiente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioSiguiente.Checked)
            {
                lblNombre.Visible = false;
                txtCancion.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                if (actual != null)
                {
                    if (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                        listMostrar.Items.Add($"Ahora esta escuchando {actual.Cancion}");
                    }
                    else
                    {
                        MessageBox.Show("No hay una cancion siguiente en la lista de reproduccion");
                    }

                }
                else
                {
                    MessageBox.Show("La lista de reproduccion esta vacia");
                }

                rdioSiguiente.Checked = false;
            }
        }

        private void rdioAnterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAnterior.Checked)
            {
                lblNombre.Visible = false;
                txtCancion.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                if (actual != null)
                {
                    if (actual.Anterior != null)
                    {
                        actual = actual.Anterior;
                        listMostrar.Items.Add($"Ahora esta escuchando {actual.Cancion}");

                    }
                    else
                    {
                        MessageBox.Show("No hay una cancion anterior en la lista de reproduccion");
                    }
                }
                else
                {
                    MessageBox.Show("La lista de reproduccion esta vacia");
                }

                rdioAnterior.Checked = false;

            }
        }

        private void rdioEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioEliminar.Checked)
            {
                lblNombre.Visible = true;
                txtCancion.Text = string.Empty;
                txtCancion.Visible = true;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = true;
                btnEliminar.Enabled = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {
                string eliminar = txtCancion.Text;
                NodoEj3 aux = actual;

                while (aux.Anterior != null) // me voy al principio de la lista
                {
                    aux = aux.Anterior;
                }

                bool encontrado = false;

                while (aux != null && encontrado != true)
                {

                    if (aux.Cancion.Equals(eliminar, StringComparison.OrdinalIgnoreCase))
                    {

                        if (aux.Anterior != null)
                        {
                            aux.Anterior.Siguiente = aux.Siguiente;
                        }
                        if (aux.Siguiente != null)
                        {
                            aux.Siguiente.Anterior = aux.Anterior;
                        }
                        if (aux == actual)
                        {
                            actual = actual.Siguiente ?? actual.Anterior;
                        }
                        encontrado = true;
                        break;
                    }

                    aux = aux.Siguiente;
                }

                if (encontrado == true)
                {
                    listMostrar.Items.Remove(aux);
                    MessageBox.Show($"Se elimino la cancion {eliminar} de la lista de reproduccion");
                }
                else
                {
                    MessageBox.Show("No se encontro la cancion en la lista de reproduccion");

                }

            }
            else
            {
                MessageBox.Show("La lista de reproduccion esta vacia");

            }
        
        }
    }
}
