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
    public partial class FormEj3Pilas : Form
    {
        Stack<string> historia = new Stack<string>();

        public FormEj3Pilas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdioNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioNueva.Checked)
            {
                lblNombre.Visible = true;
                txtPagina.Visible = true;

                btnVisitar.Visible = true;
                btnVisitar.Enabled = true;

            }
        }

        private void rdioAtras_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAtras.Checked)
            {
                lblNombre.Visible = false;
                txtPagina.Visible = false;

                btnVisitar.Visible = false;
                btnVisitar.Enabled = false;

                int contPaginas = historia.Count;

                if (contPaginas != 0)
                {
                    listMostrar.Items.Remove(historia.Pop());
                }
                else
                {
                    MessageBox.Show("El historial esta vacio");

                }

                rdioAtras.Checked = false;
            }
        }

        private void btnVisitar_Click(object sender, EventArgs e)
        {
            string pagina = txtPagina.Text;
            if (!string.IsNullOrEmpty(pagina))
            {
                historia.Push(pagina);
                listMostrar.Items.Add(pagina);
            }
            else
            {
                MessageBox.Show("La casilla \"Nombre pagina\" esta vacia");
            }
        }
    }
}
