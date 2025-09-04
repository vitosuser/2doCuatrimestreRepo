using prueba_inicio_sesion;

namespace WinFormsApp2
{
    public partial class disenador : Form
    {
        const int US = 4;

        formRegister registro = new formRegister();

        public disenador()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            registro.ShowDialog();

        }

        private void disenador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int i;
            string user, pass;

            user = txtUser.Text;
            pass = txtPass.Text;

            for(i = 0; i < US; i++)
            {
                if (DatosInicio.datos[0,i] == user)
                {
                    if (DatosInicio.datos[1,i] == pass)
                    {
                        MessageBox
                    }
                }
            }
        }
    }
}
