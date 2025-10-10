namespace TPEstructurasDinamicasParte2
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuList = new ToolStripMenuItem();
            eJ1GestionDeInventarioToolStripMenuItem = new ToolStripMenuItem();
            eJ2ListaDeTareasToolStripMenuItem = new ToolStripMenuItem();
            eJ3CalificacionesToolStripMenuItem = new ToolStripMenuItem();
            menuLinkedList = new ToolStripMenuItem();
            eJ1ToolStripMenuItem = new ToolStripMenuItem();
            eJ2ToolStripMenuItem = new ToolStripMenuItem();
            eJ3ToolStripMenuItem = new ToolStripMenuItem();
            menuPilas = new ToolStripMenuItem();
            eJ1ToolStripMenuItem1 = new ToolStripMenuItem();
            eJ2ToolStripMenuItem1 = new ToolStripMenuItem();
            eJ3ToolStripMenuItem1 = new ToolStripMenuItem();
            menuQueue = new ToolStripMenuItem();
            eJ1ToolStripMenuItem2 = new ToolStripMenuItem();
            eJ2ToolStripMenuItem2 = new ToolStripMenuItem();
            eJ3ToolStripMenuItem2 = new ToolStripMenuItem();
            menuDiccionario = new ToolStripMenuItem();
            eJ1DirectorioTelefonicoToolStripMenuItem = new ToolStripMenuItem();
            eJ2ToolStripMenuItem3 = new ToolStripMenuItem();
            eJ3TraductorDeIdiomasToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, menuList, menuLinkedList, menuPilas, menuQueue, menuDiccionario, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // menuList
            // 
            menuList.DropDownItems.AddRange(new ToolStripItem[] { eJ1GestionDeInventarioToolStripMenuItem, eJ2ListaDeTareasToolStripMenuItem, eJ3CalificacionesToolStripMenuItem });
            menuList.Name = "menuList";
            menuList.Size = new Size(48, 20);
            menuList.Text = "Listas";
            // 
            // eJ1GestionDeInventarioToolStripMenuItem
            // 
            eJ1GestionDeInventarioToolStripMenuItem.Name = "eJ1GestionDeInventarioToolStripMenuItem";
            eJ1GestionDeInventarioToolStripMenuItem.Size = new Size(211, 22);
            eJ1GestionDeInventarioToolStripMenuItem.Text = "EJ 1: Gestion de Inventario";
            eJ1GestionDeInventarioToolStripMenuItem.Click += eJ1GestionDeInventarioToolStripMenuItem_Click;
            // 
            // eJ2ListaDeTareasToolStripMenuItem
            // 
            eJ2ListaDeTareasToolStripMenuItem.Name = "eJ2ListaDeTareasToolStripMenuItem";
            eJ2ListaDeTareasToolStripMenuItem.Size = new Size(211, 22);
            eJ2ListaDeTareasToolStripMenuItem.Text = "EJ 2: Lista de Tareas";
            eJ2ListaDeTareasToolStripMenuItem.Click += eJ2ListaDeTareasToolStripMenuItem_Click;
            // 
            // eJ3CalificacionesToolStripMenuItem
            // 
            eJ3CalificacionesToolStripMenuItem.Name = "eJ3CalificacionesToolStripMenuItem";
            eJ3CalificacionesToolStripMenuItem.Size = new Size(211, 22);
            eJ3CalificacionesToolStripMenuItem.Text = "EJ 3: Calificaciones";
            eJ3CalificacionesToolStripMenuItem.Click += eJ3CalificacionesToolStripMenuItem_Click;
            // 
            // menuLinkedList
            // 
            menuLinkedList.DropDownItems.AddRange(new ToolStripItem[] { eJ1ToolStripMenuItem, eJ2ToolStripMenuItem, eJ3ToolStripMenuItem });
            menuLinkedList.Name = "menuLinkedList";
            menuLinkedList.Size = new Size(102, 20);
            menuLinkedList.Text = "Listas Enlazadas";
            // 
            // eJ1ToolStripMenuItem
            // 
            eJ1ToolStripMenuItem.Name = "eJ1ToolStripMenuItem";
            eJ1ToolStripMenuItem.Size = new Size(257, 22);
            eJ1ToolStripMenuItem.Text = "EJ 1:  Lista de Espera Restaurante";
            eJ1ToolStripMenuItem.Click += eJ1ToolStripMenuItem_Click;
            // 
            // eJ2ToolStripMenuItem
            // 
            eJ2ToolStripMenuItem.Name = "eJ2ToolStripMenuItem";
            eJ2ToolStripMenuItem.Size = new Size(257, 22);
            eJ2ToolStripMenuItem.Text = "EJ 2: Historial Editor de Texto";
            eJ2ToolStripMenuItem.Click += eJ2ToolStripMenuItem_Click;
            // 
            // eJ3ToolStripMenuItem
            // 
            eJ3ToolStripMenuItem.Name = "eJ3ToolStripMenuItem";
            eJ3ToolStripMenuItem.Size = new Size(257, 22);
            eJ3ToolStripMenuItem.Text = "EJ 3: Lista de Reproduccion Musica";
            eJ3ToolStripMenuItem.Click += eJ3ToolStripMenuItem_Click;
            // 
            // menuPilas
            // 
            menuPilas.DropDownItems.AddRange(new ToolStripItem[] { eJ1ToolStripMenuItem1, eJ2ToolStripMenuItem1, eJ3ToolStripMenuItem1 });
            menuPilas.Name = "menuPilas";
            menuPilas.Size = new Size(43, 20);
            menuPilas.Text = "Pilas";
            // 
            // eJ1ToolStripMenuItem1
            // 
            eJ1ToolStripMenuItem1.Name = "eJ1ToolStripMenuItem1";
            eJ1ToolStripMenuItem1.Size = new Size(296, 22);
            eJ1ToolStripMenuItem1.Text = "EJ 1: Simulador de Pila de Platos";
            eJ1ToolStripMenuItem1.Click += eJ1ToolStripMenuItem1_Click;
            // 
            // eJ2ToolStripMenuItem1
            // 
            eJ2ToolStripMenuItem1.Name = "eJ2ToolStripMenuItem1";
            eJ2ToolStripMenuItem1.Size = new Size(296, 22);
            eJ2ToolStripMenuItem1.Text = "EJ 2: Verificador de Parentesis Balanceados";
            eJ2ToolStripMenuItem1.Click += eJ2ToolStripMenuItem1_Click;
            // 
            // eJ3ToolStripMenuItem1
            // 
            eJ3ToolStripMenuItem1.Name = "eJ3ToolStripMenuItem1";
            eJ3ToolStripMenuItem1.Size = new Size(296, 22);
            eJ3ToolStripMenuItem1.Text = "EJ 3: Historial de Navegacion Web";
            eJ3ToolStripMenuItem1.Click += eJ3ToolStripMenuItem1_Click;
            // 
            // menuQueue
            // 
            menuQueue.DropDownItems.AddRange(new ToolStripItem[] { eJ1ToolStripMenuItem2, eJ2ToolStripMenuItem2, eJ3ToolStripMenuItem2 });
            menuQueue.Name = "menuQueue";
            menuQueue.Size = new Size(48, 20);
            menuQueue.Text = "Colas";
            // 
            // eJ1ToolStripMenuItem2
            // 
            eJ1ToolStripMenuItem2.Name = "eJ1ToolStripMenuItem2";
            eJ1ToolStripMenuItem2.Size = new Size(316, 22);
            eJ1ToolStripMenuItem2.Text = "EJ 1: Cola de Impresion de Documentos";
            // 
            // eJ2ToolStripMenuItem2
            // 
            eJ2ToolStripMenuItem2.Name = "eJ2ToolStripMenuItem2";
            eJ2ToolStripMenuItem2.Size = new Size(316, 22);
            eJ2ToolStripMenuItem2.Text = "EJ 2: Simulador de Call Center";
            // 
            // eJ3ToolStripMenuItem2
            // 
            eJ3ToolStripMenuItem2.Name = "eJ3ToolStripMenuItem2";
            eJ3ToolStripMenuItem2.Size = new Size(316, 22);
            eJ3ToolStripMenuItem2.Text = "EJ 3: Cola de Procesos en el Sistema Operativo";
            eJ3ToolStripMenuItem2.Click += eJ3ToolStripMenuItem2_Click;
            // 
            // menuDiccionario
            // 
            menuDiccionario.DropDownItems.AddRange(new ToolStripItem[] { eJ1DirectorioTelefonicoToolStripMenuItem, eJ2ToolStripMenuItem3, eJ3TraductorDeIdiomasToolStripMenuItem });
            menuDiccionario.Name = "menuDiccionario";
            menuDiccionario.Size = new Size(79, 20);
            menuDiccionario.Text = "Diccionario";
            // 
            // eJ1DirectorioTelefonicoToolStripMenuItem
            // 
            eJ1DirectorioTelefonicoToolStripMenuItem.Name = "eJ1DirectorioTelefonicoToolStripMenuItem";
            eJ1DirectorioTelefonicoToolStripMenuItem.Size = new Size(283, 22);
            eJ1DirectorioTelefonicoToolStripMenuItem.Text = "EJ 1: Directorio Telefonico";
            // 
            // eJ2ToolStripMenuItem3
            // 
            eJ2ToolStripMenuItem3.Name = "eJ2ToolStripMenuItem3";
            eJ2ToolStripMenuItem3.Size = new Size(283, 22);
            eJ2ToolStripMenuItem3.Text = "EJ 2: Catalogo de Productos por Codigo";
            // 
            // eJ3TraductorDeIdiomasToolStripMenuItem
            // 
            eJ3TraductorDeIdiomasToolStripMenuItem.Name = "eJ3TraductorDeIdiomasToolStripMenuItem";
            eJ3TraductorDeIdiomasToolStripMenuItem.Size = new Size(283, 22);
            eJ3TraductorDeIdiomasToolStripMenuItem.Text = "EJ 3: Traductor de Idiomas";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuList;
        private ToolStripMenuItem menuLinkedList;
        private ToolStripMenuItem menuPilas;
        private ToolStripMenuItem menuQueue;
        private ToolStripMenuItem menuDiccionario;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem eJ1GestionDeInventarioToolStripMenuItem;
        private ToolStripMenuItem eJ2ListaDeTareasToolStripMenuItem;
        private ToolStripMenuItem eJ3CalificacionesToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem eJ1ToolStripMenuItem;
        private ToolStripMenuItem eJ2ToolStripMenuItem;
        private ToolStripMenuItem eJ3ToolStripMenuItem;
        private ToolStripMenuItem eJ1ToolStripMenuItem1;
        private ToolStripMenuItem eJ2ToolStripMenuItem1;
        private ToolStripMenuItem eJ3ToolStripMenuItem1;
        private ToolStripMenuItem eJ1ToolStripMenuItem2;
        private ToolStripMenuItem eJ2ToolStripMenuItem2;
        private ToolStripMenuItem eJ3ToolStripMenuItem2;
        private ToolStripMenuItem eJ1DirectorioTelefonicoToolStripMenuItem;
        private ToolStripMenuItem eJ2ToolStripMenuItem3;
        private ToolStripMenuItem eJ3TraductorDeIdiomasToolStripMenuItem;
    }
}
