using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPEstructurasDinamicasParte2.Diccionario
{
    public partial class FormEj3Diccionario : Form
    {
        Dictionary<string, string> traducciones = new Dictionary<string, string>();
        public FormEj3Diccionario()
        {
            InitializeComponent();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblIngles.Visible = true;
                lblEspanol.Visible = true;

                txtIngles.Visible = true;
                txtEspanol.Visible = true;

                btnAgregar.Visible = true;

                btnBuscar.Visible = false;
            }

        }

        private void rdioBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioBuscar.Checked)
            {
                lblIngles.Visible = true;
                lblEspanol.Visible = false;

                txtIngles.Visible = true;
                txtEspanol.Visible = false;

                btnAgregar.Visible = false;

                btnBuscar.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ingles = txtIngles.Text.Trim().ToLower();
            string espanol = txtEspanol.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(ingles))
            {
                if (!string.IsNullOrEmpty(espanol))
                {
                    if (!traducciones.ContainsKey(ingles))
                    {
                        traducciones.Add(ingles, espanol);
                        listMostrar.Items.Add($"Ingles: {ingles} -- Español: {espanol}");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe la traduccion");

                    }
                }
                else
                {
                    MessageBox.Show("La casilla \"Significado en Español\" esta vacia");

                }
            }
            else
            {
                MessageBox.Show("La casilla \"Termino en Ingles\" esta vacia");

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ingles = txtIngles.Text.Trim().ToLower();
            int cantTraducciones = traducciones.Count;

            if (cantTraducciones != 0)
            {
                if (!string.IsNullOrEmpty(ingles))
                {
                    if (traducciones.ContainsKey(ingles))
                    {
                        MessageBox.Show($"Ingles: {ingles} -- Español: {traducciones[ingles]}");
                    }
                    else
                    {
                        MessageBox.Show("La traduccion no existe en el diccionario");

                    }
                }
                else
                {
                    MessageBox.Show("La casilla \"Termino en Ingles\" esta vacia");

                }
            }
            else
            {
                MessageBox.Show("No se agregaron traducciones. El diccionario esta vacio");

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
