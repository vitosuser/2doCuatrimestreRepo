namespace TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio3
{
    partial class FormEj3ListasEnlazadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listMostrar = new ListBox();
            btnAgregar = new Button();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioEliminar = new RadioButton();
            rdioAnterior = new RadioButton();
            rdioSiguiente = new RadioButton();
            rdioAgregar = new RadioButton();
            txtCancion = new TextBox();
            lblNombre = new Label();
            lblTitulo = new Label();
            btnSalir = new Button();
            btnEliminar = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(109, 269);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(303, 169);
            listMostrar.TabIndex = 51;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(610, 171);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 36);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(109, 74);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 49;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioEliminar);
            gboxAccion.Controls.Add(rdioAnterior);
            gboxAccion.Controls.Add(rdioSiguiente);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(109, 95);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(214, 152);
            gboxAccion.TabIndex = 48;
            gboxAccion.TabStop = false;
            // 
            // rdioEliminar
            // 
            rdioEliminar.AutoSize = true;
            rdioEliminar.Font = new Font("Segoe UI", 10F);
            rdioEliminar.Location = new Point(16, 116);
            rdioEliminar.Margin = new Padding(3, 2, 3, 2);
            rdioEliminar.Name = "rdioEliminar";
            rdioEliminar.Size = new Size(152, 23);
            rdioEliminar.TabIndex = 3;
            rdioEliminar.TabStop = true;
            rdioEliminar.Text = "Eliminar una cancion";
            rdioEliminar.UseVisualStyleBackColor = true;
            rdioEliminar.CheckedChanged += rdioEliminar_CheckedChanged;
            // 
            // rdioAnterior
            // 
            rdioAnterior.AutoSize = true;
            rdioAnterior.Font = new Font("Segoe UI", 10F);
            rdioAnterior.Location = new Point(16, 89);
            rdioAnterior.Margin = new Padding(3, 2, 3, 2);
            rdioAnterior.Name = "rdioAnterior";
            rdioAnterior.Size = new Size(147, 23);
            rdioAnterior.TabIndex = 2;
            rdioAnterior.TabStop = true;
            rdioAnterior.Text = "Reproducir Anterior";
            rdioAnterior.UseVisualStyleBackColor = true;
            rdioAnterior.CheckedChanged += rdioAnterior_CheckedChanged;
            // 
            // rdioSiguiente
            // 
            rdioSiguiente.AutoSize = true;
            rdioSiguiente.Font = new Font("Segoe UI", 10F);
            rdioSiguiente.Location = new Point(16, 58);
            rdioSiguiente.Margin = new Padding(3, 2, 3, 2);
            rdioSiguiente.Name = "rdioSiguiente";
            rdioSiguiente.Size = new Size(153, 23);
            rdioSiguiente.TabIndex = 1;
            rdioSiguiente.TabStop = true;
            rdioSiguiente.Text = "Reproducir Siguiente";
            rdioSiguiente.UseVisualStyleBackColor = true;
            rdioSiguiente.CheckedChanged += rdioSiguiente_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 10F);
            rdioAgregar.Location = new Point(16, 26);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(129, 23);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Cancion";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // txtCancion
            // 
            txtCancion.Font = new Font("Segoe UI", 11F);
            txtCancion.Location = new Point(465, 111);
            txtCancion.Margin = new Padding(3, 2, 3, 2);
            txtCancion.Name = "txtCancion";
            txtCancion.Size = new Size(227, 27);
            txtCancion.TabIndex = 47;
            txtCancion.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(331, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 20);
            lblNombre.TabIndex = 46;
            lblNombre.Text = "Nombre Cancion: ";
            lblNombre.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(109, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 28);
            lblTitulo.TabIndex = 45;
            lblTitulo.Text = "Lista de Reproduccion de Musica";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(551, 326);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 44;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(465, 171);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormEj3ListasEnlazadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(listMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(txtCancion);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj3ListasEnlazadas";
            Text = "Formulario Ejercicio 3 Listas Enlazadas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Button btnAgregar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioAnterior;
        private RadioButton rdioSiguiente;
        private RadioButton rdioAgregar;
        private TextBox txtCancion;
        private Label lblNombre;
        private Label lblTitulo;
        private Button btnSalir;
        private RadioButton rdioEliminar;
        private Button btnEliminar;
    }
}