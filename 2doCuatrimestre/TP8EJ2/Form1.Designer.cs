namespace TP8EJ2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeView = new TreeView();
            btnRaiz = new Button();
            btnDerecha = new Button();
            btnIzquierda = new Button();
            btnInOrden = new Button();
            btnPreOrden = new Button();
            button1 = new Button();
            txtRecorrido = new TextBox();
            lblRecorrido = new Label();
            lblSeleccionado = new Label();
            txtSeleccionado = new TextBox();
            ctxMenu = new ContextMenuStrip(components);
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lblDato = new Label();
            txtDato = new TextBox();
            ctxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 36);
            treeView.Name = "treeView";
            treeView.Size = new Size(327, 247);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(365, 36);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(113, 32);
            btnRaiz.TabIndex = 1;
            btnRaiz.Text = "Agregar Raiz";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(365, 117);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(113, 34);
            btnDerecha.TabIndex = 7;
            btnDerecha.Text = "Agregar Derecha";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(365, 74);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(113, 37);
            btnIzquierda.TabIndex = 8;
            btnIzquierda.Text = "Agregar Izquierda";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(365, 157);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(113, 34);
            btnInOrden.TabIndex = 9;
            btnInOrden.Text = "Recorrer InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(365, 197);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(113, 34);
            btnPreOrden.TabIndex = 10;
            btnPreOrden.Text = "Recorrer PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // button1
            // 
            button1.Location = new Point(365, 237);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 11;
            button1.Text = "Recorrer PostOrden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRecorrido
            // 
            txtRecorrido.Enabled = false;
            txtRecorrido.Font = new Font("Segoe UI", 10F);
            txtRecorrido.Location = new Point(12, 321);
            txtRecorrido.Name = "txtRecorrido";
            txtRecorrido.Size = new Size(466, 25);
            txtRecorrido.TabIndex = 12;
            // 
            // lblRecorrido
            // 
            lblRecorrido.AutoSize = true;
            lblRecorrido.Font = new Font("Segoe UI", 10F);
            lblRecorrido.Location = new Point(12, 293);
            lblRecorrido.Name = "lblRecorrido";
            lblRecorrido.Size = new Size(111, 19);
            lblRecorrido.TabIndex = 13;
            lblRecorrido.Text = "Recorrido Arbol: ";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Font = new Font("Segoe UI", 10F);
            lblSeleccionado.Location = new Point(239, 374);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(132, 19);
            lblSeleccionado.TabIndex = 14;
            lblSeleccionado.Text = "Nodo Seleccionado: ";
            // 
            // txtSeleccionado
            // 
            txtSeleccionado.Enabled = false;
            txtSeleccionado.Font = new Font("Segoe UI", 10F);
            txtSeleccionado.Location = new Point(367, 374);
            txtSeleccionado.Name = "txtSeleccionado";
            txtSeleccionado.Size = new Size(111, 25);
            txtSeleccionado.TabIndex = 15;
            // 
            // ctxMenu
            // 
            ctxMenu.Items.AddRange(new ToolStripItem[] { limpiarToolStripMenuItem, salirToolStripMenuItem });
            ctxMenu.Name = "ctxMenu";
            ctxMenu.Size = new Size(115, 48);
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(114, 22);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(114, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Font = new Font("Segoe UI", 10F);
            lblDato.Location = new Point(12, 374);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(46, 19);
            lblDato.TabIndex = 16;
            lblDato.Text = "Dato: ";
            // 
            // txtDato
            // 
            txtDato.Font = new Font("Segoe UI", 10F);
            txtDato.Location = new Point(64, 371);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(111, 25);
            txtDato.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(536, 426);
            ContextMenuStrip = ctxMenu;
            Controls.Add(txtDato);
            Controls.Add(lblDato);
            Controls.Add(txtSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(lblRecorrido);
            Controls.Add(txtRecorrido);
            Controls.Add(button1);
            Controls.Add(btnPreOrden);
            Controls.Add(btnInOrden);
            Controls.Add(btnIzquierda);
            Controls.Add(btnDerecha);
            Controls.Add(btnRaiz);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "Arbol";
            ctxMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private Button btnRaiz;
        private Button btnDerecha;
        private Button btnIzquierda;
        private Button btnInOrden;
        private Button btnPreOrden;
        private Button button1;
        private TextBox txtRecorrido;
        private Label lblRecorrido;
        private Label lblSeleccionado;
        private TextBox txtSeleccionado;
        private ContextMenuStrip ctxMenu;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lblDato;
        private TextBox txtDato;
    }
}
