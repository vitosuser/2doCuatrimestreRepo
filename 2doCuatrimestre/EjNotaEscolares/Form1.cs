namespace EjNotaEscolares
{
    public partial class formNotas : Form
    {
        private string elegido = "";
        private int validador = 0;
        public formNotas()
        {
            InitializeComponent();
        }

        private void lblMateria_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa para subir notas creado por Vito");
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validador == 3)
            {
                Form2 planilla = new Form2(txtName.Text, txtMateria.Text, txtNota.Text, elegido);

                planilla.Show();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            validador = 0;
            int nota = 0;

            nota = Convert.ToInt16(txtNota.Text);

            if (nota >= 0 && nota <= 10)
            {
                validador = validador + 1;
            }
            else
            {
                MessageBox.Show("No se ingreso una nota valida. Debe ser entre 0-10");
            }
            if (!string.IsNullOrEmpty(txtName.Text))
            {

                validador = validador + 1;
            }
            else
            {
                MessageBox.Show("No se ingreso nombre del alumno");
            }
            if (!string.IsNullOrEmpty(txtMateria.Text))
            {

                validador = validador + 1;
            }
            else
            {
                MessageBox.Show("No se ingreso una materia");
            }
            if (rdioTP.Checked == true)
            {
                elegido = rdioTP.Text;
            }
            else if (rdioParcial.Checked == true)
            {
                elegido = rdioParcial.Text;
            }
            else
            {
                elegido = rdioFinal.Text;
            }
        }

        private void limpiarEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMateria.Text = "";
            txtNota.Text = "";
            rdioTP.Checked = true;
        }
    }
}
