using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstructurasDinamicasParte2.Pilas
{
    public partial class FormEj1Pilas : Form
    {
        Stack<string> pila = new Stack<string>();
        public FormEj1Pilas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdioApilar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioApilar.Checked)
            {
                int nroPlato = pila.Count + 1;
                pila.Push($"Plato {nroPlato}");

                listMostrar.Items.Add(pila.Peek());

                rdioApilar.Checked = false;
            }
        }

        private void rdioDesapilar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioDesapilar.Checked)
            {
                int cantPlatos = pila.Count;

                if (cantPlatos != 0)
                {
                    listMostrar.Items.Remove(pila.Pop());

                }
                else
                {
                    MessageBox.Show("La pila esta vacia, no hay platos que desapilar", "Error");
                }
                rdioDesapilar.Checked = false;

            }
        }

        private void rdioMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioMostrar.Checked)
            {
                int cantPlatos = pila.Count;

                if (cantPlatos != 0)
                {
                    MessageBox.Show($"Plato de la cima: {pila.Peek()}");

                }

                else
                {
                    MessageBox.Show("No hay platos en la pila", "Error");
                }

                rdioMostrar.Checked = false;
            }
        }

        private void listMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
