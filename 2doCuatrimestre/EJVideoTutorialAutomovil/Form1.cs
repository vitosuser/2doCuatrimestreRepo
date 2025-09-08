using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJVideoTutorialAutomovil
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0; //porque no puedo usar float
            string cotizacion = "";

            cotizacion = "Cotizacion de auto para " + txtNombre.Text + "\r\n";

            //leo el valor del textbox costo inicial
            costo = Convert.ToDouble(txtCosto.Text); 


            //Verifico que cobertura de seguro eligio

            if(rbRespCivil.Checked == true)
            {
                costo = costo + 500;
                cotizacion = cotizacion + "Seguro Resp. Civil de $500 \r\n";
            }
            if(rbTerceros.Checked == true)
            {
                costo = costo + 750;
                cotizacion = cotizacion + "Seguro Contra Terceros de $750 \r\n";
            }
            if(rbTodoRiesgo.Checked == true)
            {
                costo = costo + 1000;
                cotizacion = cotizacion + "Seguro Todo Riesgo de $1000 \r\n";
            }

            //Verifico equipamento
            if(ckbAire.Checked == true)
            {
                costo = costo + 500;
                cotizacion = cotizacion + "Aire acondicionado: $500 \r\n";
            }
            if(ckbAudio.Checked == true)
            {
                costo = costo + 700;
                cotizacion = cotizacion + "Sistema audio: $700 \r\n";
            }

            cotizacion = cotizacion + "El costo total es de" + costo.ToString();

            txtCotizacion.Text = cotizacion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
