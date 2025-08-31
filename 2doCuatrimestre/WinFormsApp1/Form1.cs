using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class FRMEJ1 : Form
    {
        public FRMEJ1()
        {
            InitializeComponent();
            this.AcceptButton = this.botonAdivinar;
            linkyt.Links.Add(0, linkyt.Text.Length, "https://www.youtube.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblapellido_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.textboxnombre.Text;
            string apellido = this.textBoxapellido.Text;

            textboxnombre.Text = string.Empty;
            textBoxapellido.Text = string.Empty;

            //aca debo aggregar todos los labels a limpiar
            //lblresultado.Text = $"Usted se llama {nombre} {apellido}";

            if (nombre.Length != 0 && apellido.Length != 0)
            {
                MessageBox.Show($"Usted se llama {nombre} {apellido}");
                // eset me abre otra ventana
            }
            if (nombre.Length == 0 || apellido.Length == 0)
            {
                MessageBox.Show("No se ingresaron datos validos");

            }
        }

        private void textboxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;

            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
        private void limiparVentana()
        {
            
        }
    }
}
