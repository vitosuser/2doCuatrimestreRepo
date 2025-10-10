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

        private void eJ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListasEnlazadas.Ejercicio2.FormEj2ListasEnlazadas Ej2 = new ListasEnlazadas.Ejercicio2.FormEj2ListasEnlazadas();

            Ej2.ShowDialog();
        }

        private void eJ3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListasEnlazadas.Ejercicio3.FormEj3ListasEnlazadas Ej3 = new ListasEnlazadas.Ejercicio3.FormEj3ListasEnlazadas();

            Ej3.ShowDialog();
        }

        private void eJ1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pilas.FormEj1Pilas Ej1 = new Pilas.FormEj1Pilas();

            Ej1.ShowDialog();
        }

        private void eJ2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pilas.FormEj2Pilas Ej2 = new Pilas.FormEj2Pilas();

            Ej2.ShowDialog();

        }

        private void eJ3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pilas.FormEj3Pilas Ej3 = new Pilas.FormEj3Pilas();

            Ej3.ShowDialog();
        }
    }
}
