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
    public partial class FormEj1Diccionario : Form
    {
        Dictionary<string, int> agenda = new Dictionary<string, int>();
        public FormEj1Diccionario()
        {
            InitializeComponent();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblNombre.Visible = true;
                lblNumero.Visible = true;

                txtNombre.Visible = true;
                txtNumero.Visible = true;

                btnAgregar.Visible = true;

                btnEliminar.Visible = false;

                btnBuscar.Visible = false;
            }
        }

        private void rdioBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioBuscar.Checked)
            {
                lblNombre.Visible = true;
                lblNumero.Visible = false;

                txtNombre.Visible = true;
                txtNumero.Visible = false;

                btnAgregar.Visible = false;

                btnEliminar.Visible = false;

                btnBuscar.Visible = true;
            }
        }

        private void rdioEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioEliminar.Checked)
            {
                lblNombre.Visible = true;
                lblNumero.Visible = false;

                txtNombre.Visible = true;
                txtNumero.Visible = false;

                btnAgregar.Visible = false;

                btnEliminar.Visible = true;

                btnBuscar.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim().ToLower();
            string numeroTel = txtNumero.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(nombre))
            {
                if (int.TryParse(numeroTel, out int numero))
                {
                    if (!agenda.ContainsKey(nombre))
                    {
                        agenda.Add(nombre, numero);
                        listMostrar.Items.Add($"Nombre: {nombre} -- Tel: {numero}");
                    }
                    else
                    {
                        MessageBox.Show("El contacto ya existe en la agenda");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero valido en la casilla \"Numero Telefonico \" ");

                }
            }
            else
            {
                MessageBox.Show("La casilla \"Nombre\" esta vacia");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cantContactos = agenda.Count;

            if (cantContactos != 0)
            {
                string nombre = txtNombre.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(nombre))
                {
                    if (agenda.ContainsKey(nombre))
                    {
                        MessageBox.Show($"Contacto Encontrado !! \n Nombre: {nombre} -- Tel.: {agenda[nombre]}");
                    }
                    else
                    {
                        MessageBox.Show($"No se encontro el contacto \"{nombre}\" en la agenda");
                    }
                }
                else
                {
                    MessageBox.Show("La casilla \"Nombre\" esta vacia");

                }
            }
            else
            {
                MessageBox.Show("No se puede buscar un contacto porque la agenda esta vacia");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cantContactos = agenda.Count;

            if(cantContactos != 0)
            {
                string nombre = txtNombre.Text.Trim().ToLower();

                if (agenda.ContainsKey(nombre))
                {
                    agenda.Remove(nombre);
                    int i;

                    for (i = 0; i < listMostrar.Items.Count; i ++)
                    {
                        if (listMostrar.Items[i].ToString().Contains(nombre))
                        {
                            listMostrar.Items.RemoveAt(i);

                        }
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontro el contacto \"{nombre}\" en la agenda");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un contacto porque la agenda esta vacia");

            }
        }
    }
}
