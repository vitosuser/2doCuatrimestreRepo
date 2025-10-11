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
    public partial class FormEj1Colas : Form
    {
        Queue<string> cola = new Queue<string>();

        public FormEj1Colas()
        {
            InitializeComponent();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                int numDoc = cola.Count + 1;

                cola.Enqueue($"Documento {numDoc}");

                listMostrar.Items.Add(cola.Last());

                rdioAgregar.Checked = false;
            }
        }

        private void rdioImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioImprimir.Checked)
            {
                int cantDocs = cola.Count;

                if (cantDocs != 0)
                {
                    listMostrar.Items.Remove(cola.Dequeue());
                }
                else
                {
                    MessageBox.Show("La cola de impresion esta vacia");
                }

                rdioImprimir.Checked = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
