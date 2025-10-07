using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstructurasDinamicasParte2.Listas.Ejercicio3;


namespace TPEstructurasDinamicasParte2.Listas
{
    public partial class FormEj3Listas : Form
    {
        List<Calificacion> notas = new List<Calificacion>();

        public FormEj3Listas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdioAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioAgregar.Checked)
            {
                lblCalificacion.Visible = true;
                txtCalificacion.Visible = true;

                btnAgregar.Visible = true;
                btnAgregar.Enabled = true;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;
            }
        }

        private void rdioPromedio_CheckedChanged(object sender, EventArgs e)
        {
            int cantCalif = notas.Count;

            if (rdioPromedio.Checked)
            {
                lblCalificacion.Visible = false;
                txtCalificacion.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                if(cantCalif != 0)
                {
                    double sumaNotas = 0;

                    foreach(var nota in notas)
                    {
                        sumaNotas = sumaNotas + nota.Nota;

                    }

                    double promedio = sumaNotas / cantCalif;

                    MessageBox.Show($"Promedio de calificaciones: {promedio}");

                    
                }
                else
                {
                    MessageBox.Show("La listas de Calificaciones esta vacia");
                }
            }
            
        }

        private void rdioEliminarAlta_CheckedChanged(object sender, EventArgs e)
        {
            int cantCalif = notas.Count;
            if (rdioEliminarAlta.Checked)
            {
                lblCalificacion.Visible = false;
                txtCalificacion.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                
                if(cantCalif != 0)
                {
                    double notaMasAlta = -1;

                    foreach(var nota in notas)
                    {
                        if(nota.Nota > notaMasAlta)
                        {
                            notaMasAlta = nota.Nota;
                        }
                    }

                    Calificacion alta = notas.Find(n => n.Nota.Equals(notaMasAlta));

                    notas.Remove(alta);
                    listMostrar.Items.Remove(alta);

                    MessageBox.Show($"Se elimino la nota mas alta ({notaMasAlta})");

                }
                else
                {

                    MessageBox.Show("La lista de calificaciones esta vacia");

                }

                rdioEliminarAlta.Checked = false;

            }
            
        }

        private void rdioEliminarBaja_CheckedChanged(object sender, EventArgs e)
        {
            int cantCalif = notas.Count;

            if (rdioEliminarBaja.Checked)
            {
                lblCalificacion.Visible = false;
                txtCalificacion.Visible = false;

                btnAgregar.Visible = false;
                btnAgregar.Enabled = false;

                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;

                if(cantCalif != 0)
                {
                    double notaMasBaja = 11;

                    foreach (var nota in notas)
                    {
                        if(nota.Nota < notaMasBaja)
                        {
                            notaMasBaja = nota.Nota;
                        }
                    }

                    Calificacion baja = notas.Find(n => n.Nota.Equals(notaMasBaja));

                    notas.Remove(baja);
                    listMostrar.Items.Remove(baja);

                    MessageBox.Show($"Se elimino la nota mas baja ({notaMasBaja})");
                    
                }
                else
                {

                    MessageBox.Show("La lista de calificaciones esta vacia");


                }

                rdioEliminarBaja.Checked = false;

            }
            //agregar funcionamiento
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string calif = txtCalificacion.Text.Trim();

            if (!string.IsNullOrEmpty(calif))
            {
                if(double.TryParse(calif, out double nota))
                {
                    if(nota >= 0 && nota <= 10)
                    {
                        Calificacion nueva = new Calificacion(nota);

                        notas.Add(nueva);
                        listMostrar.Items.Add(nueva);

                    }
                    else
                    {
                        MessageBox.Show("La Calificacion debe estar entre 0 y 10");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numerico en Calificacion");
                }
            }
            else
            {
                MessageBox.Show("La casilla Calificacion esta vacia");
            }
        }
    }
}
