namespace TPEstructurasDinamicasParte2.Diccionario
{
    partial class FormEj1Diccionario
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
            btnAgregar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            listMostrar = new ListBox();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioEliminar = new RadioButton();
            rdioBuscar = new RadioButton();
            rdioAgregar = new RadioButton();
            lblTitulo = new Label();
            btnSalir = new Button();
            lblNumero = new Label();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtNumero = new TextBox();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(662, 249);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 36);
            btnAgregar.TabIndex = 41;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(560, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre: ";
            lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(483, 114);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 25);
            txtNombre.TabIndex = 39;
            txtNombre.Visible = false;
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(94, 269);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(309, 169);
            listMostrar.TabIndex = 38;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(94, 77);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 37;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioEliminar);
            gboxAccion.Controls.Add(rdioBuscar);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(94, 98);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(309, 143);
            gboxAccion.TabIndex = 36;
            gboxAccion.TabStop = false;
            // 
            // rdioEliminar
            // 
            rdioEliminar.AutoSize = true;
            rdioEliminar.Font = new Font("Segoe UI", 12F);
            rdioEliminar.Location = new Point(16, 105);
            rdioEliminar.Margin = new Padding(3, 2, 3, 2);
            rdioEliminar.Name = "rdioEliminar";
            rdioEliminar.Size = new Size(151, 25);
            rdioEliminar.TabIndex = 2;
            rdioEliminar.TabStop = true;
            rdioEliminar.Text = "Eliminar Contacto";
            rdioEliminar.UseVisualStyleBackColor = true;
            rdioEliminar.CheckedChanged += rdioEliminar_CheckedChanged;
            // 
            // rdioBuscar
            // 
            rdioBuscar.AutoSize = true;
            rdioBuscar.Font = new Font("Segoe UI", 12F);
            rdioBuscar.Location = new Point(18, 67);
            rdioBuscar.Margin = new Padding(3, 2, 3, 2);
            rdioBuscar.Name = "rdioBuscar";
            rdioBuscar.Size = new Size(140, 25);
            rdioBuscar.TabIndex = 1;
            rdioBuscar.TabStop = true;
            rdioBuscar.Text = "Buscar Contacto";
            rdioBuscar.UseVisualStyleBackColor = true;
            rdioBuscar.CheckedChanged += rdioBuscar_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 12F);
            rdioAgregar.Location = new Point(18, 28);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(150, 25);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Contacto";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(94, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 28);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Directorio Telefonico";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(662, 352);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 34;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11F);
            lblNumero.Location = new Point(526, 151);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(147, 20);
            lblNumero.TabIndex = 42;
            lblNumero.Text = "Numero de telefono:";
            lblNumero.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(466, 249);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 36);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(564, 249);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 36);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 10F);
            txtNumero.Location = new Point(483, 186);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(227, 25);
            txtNumero.TabIndex = 45;
            txtNumero.Visible = false;
            // 
            // FormEj1Diccionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(lblNumero);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj1Diccionario";
            Text = "Formulario Ejercicio 1 Diccionario";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblNombre;
        private TextBox txtNombre;
        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioBuscar;
        private RadioButton rdioAgregar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblNumero;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtNumero;
        private RadioButton rdioEliminar;
    }
}