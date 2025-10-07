using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio1;

namespace TPEstructurasDinamicasParte2.Listas_Enlazadas.Ejercicio1
{
    public partial class FormEj1ListasEnlazadas : Form
    {
        private static NodoEj1? cabeza;

        
        public FormEj1ListasEnlazadas()
        {
            InitializeComponent();

            cabeza = null;

        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblCliente.Visible = true;
                txtCliente.Visible = true;

                btnAgregar.Visible = true;
                btnAgregar.Enabled = true;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                string cliente = txtCliente.Text;

                if (!string.IsNullOrEmpty(cliente))
                {
                    NodoEj1 nuevo = new NodoEj1(cliente);

                    if(cabeza == null)
                    {
                        cabeza = nuevo;
                    }
                    else
                    {
                        NodoEj1 actual = cabeza;

                        while(actual.Siguiente != null)
                        {
                            actual = actual.Siguiente;
                        }

                        actual.Siguiente = nuevo;
                        listMostrar.Items.Add(nuevo);
                        
                    }
                }
                else
                {
                    MessageBox.Show("La casilla Nombre Cliente esta vacia");
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdioSentar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioSentar.Checked)
            {
                lblCliente.Visible = false;
                txtCliente.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;
            }

            //agregar funcionamiento
        }

        private void rdioEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioEliminar.Checked)
            {
                lblCliente.Visible = true;
                txtCliente.Visible = true;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = true;
                btnEliminar.Enabled = true;
            }
            //agregar funcionamiento
        }
    }
}
