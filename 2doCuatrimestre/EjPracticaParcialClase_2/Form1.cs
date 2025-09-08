namespace EjPracticaParcialClase_2
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0;
            string cotizacion = "";

            cotizacion = "Computadora para " + txtCliente.Text + "\r\n";
            cotizacion = cotizacion + "Costo inicial: " + txtCostoBase.Text + "\r\n";

            costo = Convert.ToDouble(txtCostoBase.Text);

            if(rdioIntel5.Checked == true)
            {
                costo = costo + 100;
                cotizacion = cotizacion + "Procesador seleccionado Intel i5: + $100 \r\n";
            }
            else if (rdioIntel7.Checked == true)
            {
                costo = costo + 200;
                cotizacion = cotizacion + "Procesador seleccionado Intel i7: + $200 \r\n";
            }
            else
            {
                costo = costo + 180;
                cotizacion = cotizacion + "Procesador seleccionado Ryzen 7: + $180 \r\n";
            }

            if(chkRAM.Checked == true)
            {
                costo = costo + 50;
                cotizacion = cotizacion + "Memoria RAM Extra agregada: + $50 \r\n";
            }
            if (chkSSD.Checked == true)
            {
                costo = costo + 50;
                cotizacion = cotizacion + "Disco SSD agregado: + $50 \r\n";
            }
            if(chkGrafica.Checked == true)
            {
                costo = costo + 150;
                cotizacion = cotizacion + "Tarjeta Grafica Externa agregada: + $150 \r\n";
            }

            cotizacion = cotizacion + "El costo total del la computadora es " + costo.ToString();

            txtCotizacion.Text = cotizacion;
        }
    }
}
