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
    public partial class FormEj2Pilas : Form
    {
        Stack<char> elementos = new Stack<char>();
        public FormEj2Pilas()
        {
            InitializeComponent();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblElemento.Visible = true;
                txtElemento.Visible = true;

                btnAgregar.Visible = true;
                btnAgregar.Enabled = true;
            }
        }

        private void rdioVerificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioVerificar.Checked)
            {
                lblElemento.Visible = false;
                txtElemento.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                int contPila = elementos.Count;

                string expresion = string.Join("", elementos);
                if(contPila != 0)
                {
                    Stack<char> simbolos = new Stack<char>();

                    foreach(char caract in elementos.Reverse())
                    {
                        if(caract == '(' || caract == '{' || caract == '[')
                        {
                            simbolos.Push(caract);
                        }
                        else if(caract == ')' || caract == '}' || caract == ']')
                        {
                            if(simbolos.Count == 0)
                            {
                                MessageBox.Show("Se cerro un simbolo sin que haya sido abierto en un principio");
                                return;
                            }
                            
                                char ultimoSimb = simbolos.Pop();

                                if(caract == ')' && ultimoSimb != '(' || caract == '}' && ultimoSimb != '{'|| caract == ']' && ultimoSimb != '[')
                                {
                                    MessageBox.Show("Los simbolos de la expresion no estan correctamente balanceados o anidados");
                                    return;
                                }
                                
                            
                            
                        }
                        
                    }

                    if (simbolos.Count == 0)
                    {
                        MessageBox.Show("Los simbolos estan correctamente balanceados y anidados");
                    }
                    else
                    {
                        MessageBox.Show("Falta cerrar simbolos");
                    }
                }
                else
                {
                    MessageBox.Show("La pila de elementos esta vacia");
                }

                rdioVerificar.Checked = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text;
            if (!string.IsNullOrEmpty(elemento))
            {
                foreach (char c in elemento)
                {
                    elementos.Push(c);
                    listMostrar.Items.Add(c);

                }

                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("La casilla \"Elemento\" esta vacia");
            }
        }
    }
}
