namespace TP8EJ2
{

    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (!string.IsNullOrEmpty(txtDato.Text))
                {
                    string padre = treeView.SelectedNode.Text;
                    string hijo = txtDato.Text;

                    if (arbol.AgregarIzquierda(padre, hijo))
                    {
                        treeView.SelectedNode.Nodes.Add(new TreeNode(hijo));
                        treeView.SelectedNode.Expand();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar a la izquierda");
                    }
                }
                else
                {
                    MessageBox.Show("La casilla \"Dato\" esta vacia");

                }
            }
            else
            {
                MessageBox.Show("Seleccione un nodo en el TreeView.");
                return;
            }

            txtDato.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRecorrido.Clear();
            txtSeleccionado.Clear();
            txtDato.Clear();
            treeView.Nodes.Clear();
            arbol.Limpiar();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                string dato = txtDato.Text;

                if (arbol.AgregarRaiz(dato) == true)
                {
                    treeView.Nodes.Add(new TreeNode(dato));

                }
                else
                {
                    MessageBox.Show("Ya existe una raiz en el arbol");

                }

                txtDato.Clear();

            }
            else
            {
                MessageBox.Show("La casilla \"Dato\" esta vacia");
            }



        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (!string.IsNullOrEmpty(txtDato.Text))
                {
                    string padre = treeView.SelectedNode.Text;
                    string hijo = txtDato.Text;

                    if (arbol.AgregarDerecha(padre, hijo))
                    {
                        treeView.SelectedNode.Nodes.Add(new TreeNode(hijo));
                        treeView.SelectedNode.Expand();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar a la derecha");
                    }
                }
                else
                {
                    MessageBox.Show("La casilla \"Dato\" esta vacia");

                }
            }
            else
            {
                MessageBox.Show("Seleccione un nodo en el TreeView.");
                return;
            }

            txtDato.Clear();
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            txtRecorrido.Clear();

            if (arbol.raiz != null)
            {
                txtRecorrido.Text = arbol.RecorridoInorden();
            }
            else
            {
                MessageBox.Show("El arbol esta vacio");
            }
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtRecorrido.Clear();

            if (arbol.raiz != null)
            {
                txtRecorrido.Text = arbol.RecorridoPreorden();
            }
            else
            {
                MessageBox.Show("El arbol esta vacio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRecorrido.Clear();

            if (arbol.raiz != null)
            {
                txtRecorrido.Text = arbol.RecorridoPostorden();
            }
            else
            {
                MessageBox.Show("El arbol esta vacio");
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                txtSeleccionado.Text = treeView.SelectedNode.Text;

            }
            else
            {
                txtSeleccionado.Clear();
            }
        }
    }
}
