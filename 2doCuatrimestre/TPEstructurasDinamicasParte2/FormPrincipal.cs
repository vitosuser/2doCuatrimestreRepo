namespace TPEstructurasDinamicasParte2
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void eJ3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor del trabajo: \n Vito Tramontini", "Acerca de");
        }

        private void eJ1GestionDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.FormEj1Listas Ej1 = new Listas.FormEj1Listas();

            Ej1.ShowDialog();
        }

        private void eJ2ListaDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.FormEj2Listas Ej2 = new Listas.FormEj2Listas();


            Ej2.ShowDialog();
        }

        private void eJ3CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.FormEj3Listas Ej3 = new Listas.FormEj3Listas();

            Ej3.ShowDialog();
        }

        private void eJ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas_Enlazadas.Ejercicio1.FormEj1ListasEnlazadas Ej1 = new Listas_Enlazadas.Ejercicio1.FormEj1ListasEnlazadas();

            Ej1.ShowDialog();
        }
    }
}
