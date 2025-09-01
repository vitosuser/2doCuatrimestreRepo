using prueba_inicio_sesion;

namespace WinFormsApp2
{
    public partial class disenador : Form
    {
        formRegister registro = new formRegister();

        public disenador()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            registro.ShowDialog();

        }
    }
}
