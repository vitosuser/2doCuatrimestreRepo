using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio2
{
    public partial class FormEj2ListasEnlazadas : Form
    {
        private NodoEj2? actual;

        public FormEj2ListasEnlazadas()
        {
            InitializeComponent();
            actual = null;
        }

        private void rdioEscribir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioEscribir.Checked)
            {
                lblTexto.Visible = true;
                txtTexto.Visible = true;

                btnOk.Visible = true;
                btnOk.Enabled = true;
            }
        }

        private void rdioDeshacer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioDeshacer.Checked)
            {
                lblTexto.Visible = false;
                txtTexto.Visible = false;

                btnOk.Visible = false;
                btnOk.Enabled = false;

                //NodoEj2 anterior = actual.Anterior;

                if(actual != null)
                {
                    listMostrar.Items.Remove(actual);

                    actual = actual.Anterior;

                }
                else
                {
                    MessageBox.Show("No hay nada que deshacer");
                }

                rdioDeshacer.Checked = false;
            }
        }

        private void rdioRehacer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioRehacer.Checked)
            {
                lblTexto.Visible = false;
                txtTexto.Visible = false;

                btnOk.Visible = false;
                btnOk.Enabled = false;

                if(actual != null && actual.Siguiente != null)
                {
                    actual = actual.Siguiente;

                    listMostrar.Items.Add(actual);

                }
                else
                {
                    MessageBox.Show("No hay nada que rehacer");
                }

                rdioRehacer.Checked = false;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string text = txtTexto.Text;
            if (!string.IsNullOrEmpty(text))
            {
                NodoEj2 nuevo = new NodoEj2(text);

                if(actual != null)
                {
                    actual.Siguiente = nuevo;
                    nuevo.Anterior = actual;
                }
                
                   actual = nuevo;
                   listMostrar.Items.Add(actual);
                
            }
            else
            {
                MessageBox.Show("La casilla Texto esta vacia");
            }
        }
    }
}
