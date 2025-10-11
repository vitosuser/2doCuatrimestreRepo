using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstructurasDinamicasParte2.Colas
{
    public partial class FormEj2Colas : Form
    {
        Queue<string> llamadas = new Queue<string>();
        public FormEj2Colas()
        {
            InitializeComponent();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                int numLlamada = llamadas.Count + 1;

                llamadas.Enqueue($"Llamada {numLlamada}");

                listMostrar.Items.Add(llamadas.Last());

                rdioAgregar.Checked = false;
            }
        }

        private void rdioAtender_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAtender.Checked)
            {
                int contLlamadas = llamadas.Count;

                if (contLlamadas != 0)
                {
                    listMostrar.Items.Remove(llamadas.Dequeue());

                }
                else
                {
                    MessageBox.Show("La cola de llamadas esta vacia");
                }

                rdioAtender.Checked = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
