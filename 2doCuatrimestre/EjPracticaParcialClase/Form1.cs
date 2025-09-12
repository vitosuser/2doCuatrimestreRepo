namespace EjPracticaParcialClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0;
            string cotizacion = "";

            cotizacion = "Cotizacion de viaje para " + txtPasajero.Text + "\r\n";

            cotizacion = cotizacion + "Costo base: $" + txtPBase.Text + "\r\n";

            costo = Convert.ToDouble(txtPBase.Text);

            if (rdioPlaya.Checked == true)
            {
                costo = costo + 600;
                cotizacion = cotizacion + "Destino playa: + $600 \r\n";
            }
            else if(rdioMontana.Checked == true)
            {
                costo = costo + 700;
                cotizacion = cotizacion + "Destino montana: + $700 \r\n";
            }
            else
            {
                costo = costo + 400;
                cotizacion = cotizacion + "Destino ciudad: + $400 \r\n";
            }

            if(chkGuia.Checked == true)
            {
                costo = costo + 100;
                cotizacion = cotizacion + "Guia incluido: + $100 \r\n";
            }
            if (chkTraslado.Checked == true)
            {
                costo = costo + 150;
                cotizacion = cotizacion + "Traslado incluido: + $150 \r\n";
            }
            if(chkComidas.Checked == true)
            {
                costo = costo + 200;
                cotizacion = cotizacion + "Comidas incluidas: + $200 \r\n";
            }

            cotizacion = cotizacion + "El costo toal del viajes es $" + costo.ToString();

            txtInfo.Text = cotizacion;

        }
    }
}
