using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace prueba_inicio_sesion
{
    public partial class formRegister : Form
    {
        const int US = 4; // cantidad de usuarios maximos 
        public formRegister()
        {
            InitializeComponent();

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            bool registrado = false;

            if (txtUserReg.TextLength > 0)
            {
                if (txtPassReg1.TextLength > 0)
                {
                    if (txtPassReg2.Text == txtPassReg1.Text)
                    {

                        for (i = 0; i < US; i++)
                        {
                            
                            if (string.IsNullOrEmpty(DatosInicio.datos[0, i]))
                            {
                                DatosInicio.datos[0, i] = txtUserReg.Text;
                                DatosInicio.datos[1, i] = txtPassReg2.Text;
                                lblErrorReg.Text = "Usuario Registrado Correctamente";
                                registrado = true;
                                break;
                            }
                            
                        }
                        if(registrado != true) {

                            lblErrorReg.Text = "No hay espacio en la matriz para otro usuario";
                        }
                        

                    }
                    else
                    {
                        lblErrorReg.Text = "Las contraseñas no son iguales";
                    }

                }
                else
                {
                    lblErrorReg.Text = "Ingrese una contraseña valida";
                }
            }
            else
            {
                lblErrorReg.Text = "Ingrese un usuario valido";
            }
        }


        private void formRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
