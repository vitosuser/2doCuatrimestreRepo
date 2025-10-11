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
    public partial class FormEj3Colas : Form
    {
        Queue<string> procesos = new Queue<string>();
        public FormEj3Colas()
        {
            InitializeComponent();
        }

        private void rdioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioNuevo.Checked)
            {
                int numProceso = procesos.Count + 1;

                procesos.Enqueue($"Proceso {numProceso}");

                listMostrar.Items.Add(procesos.Last());

                rdioNuevo.Checked = false;
            }
        }

        private void rdioEjecutar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioEjecutar.Checked)
            {
                int contProcesos = procesos.Count;

                if (contProcesos != 0)
                {
                    listMostrar.Items.Remove(procesos.Dequeue());
                }
                else
                {
                    MessageBox.Show("La cola de procesos esta vacia");
                }

                rdioEjecutar.Checked = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
