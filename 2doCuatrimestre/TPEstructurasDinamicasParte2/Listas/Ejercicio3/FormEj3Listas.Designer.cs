namespace TPEstructurasDinamicasParte2.Listas
{
    partial class FormEj3Listas
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
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioEliminarBaja = new RadioButton();
            rdioEliminarAlta = new RadioButton();
            rdioPromedio = new RadioButton();
            rdioAgregar = new RadioButton();
            txtCalificacion = new TextBox();
            lblCalificacion = new Label();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(87, 269);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(303, 169);
            listMostrar.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(429, 174);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(574, 174);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 36);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(87, 74);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 21;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioEliminarBaja);
            gboxAccion.Controls.Add(rdioEliminarAlta);
            gboxAccion.Controls.Add(rdioPromedio);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(87, 95);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(214, 157);
            gboxAccion.TabIndex = 20;
            gboxAccion.TabStop = false;
            // 
            // rdioEliminarBaja
            // 
            rdioEliminarBaja.AutoSize = true;
            rdioEliminarBaja.Font = new Font("Segoe UI", 10F);
            rdioEliminarBaja.Location = new Point(16, 123);
            rdioEliminarBaja.Margin = new Padding(3, 2, 3, 2);
            rdioEliminarBaja.Name = "rdioEliminarBaja";
            rdioEliminarBaja.Size = new Size(167, 23);
            rdioEliminarBaja.TabIndex = 3;
            rdioEliminarBaja.TabStop = true;
            rdioEliminarBaja.Text = "Eliminar Calif. Mas Baja";
            rdioEliminarBaja.UseVisualStyleBackColor = true;
            rdioEliminarBaja.CheckedChanged += rdioEliminarBaja_CheckedChanged;
            // 
            // rdioEliminarAlta
            // 
            rdioEliminarAlta.AutoSize = true;
            rdioEliminarAlta.Font = new Font("Segoe UI", 10F);
            rdioEliminarAlta.Location = new Point(16, 92);
            rdioEliminarAlta.Margin = new Padding(3, 2, 3, 2);
            rdioEliminarAlta.Name = "rdioEliminarAlta";
            rdioEliminarAlta.Size = new Size(166, 23);
            rdioEliminarAlta.TabIndex = 2;
            rdioEliminarAlta.TabStop = true;
            rdioEliminarAlta.Text = "Eliminar Calif. Mas Alta";
            rdioEliminarAlta.UseVisualStyleBackColor = true;
            rdioEliminarAlta.CheckedChanged += rdioEliminarAlta_CheckedChanged;
            // 
            // rdioPromedio
            // 
            rdioPromedio.AutoSize = true;
            rdioPromedio.Font = new Font("Segoe UI", 10F);
            rdioPromedio.Location = new Point(16, 61);
            rdioPromedio.Margin = new Padding(3, 2, 3, 2);
            rdioPromedio.Name = "rdioPromedio";
            rdioPromedio.Size = new Size(171, 23);
            rdioPromedio.TabIndex = 1;
            rdioPromedio.TabStop = true;
            rdioPromedio.Text = "Calcular Promedio Calif.";
            rdioPromedio.UseVisualStyleBackColor = true;
            rdioPromedio.CheckedChanged += rdioPromedio_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 10F);
            rdioAgregar.Location = new Point(16, 29);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(147, 23);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Calificacion";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Font = new Font("Segoe UI", 11F);
            txtCalificacion.Location = new Point(429, 111);
            txtCalificacion.Margin = new Padding(3, 2, 3, 2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(227, 27);
            txtCalificacion.TabIndex = 18;
            txtCalificacion.Visible = false;
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Font = new Font("Segoe UI", 11F);
            lblCalificacion.Location = new Point(327, 112);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(93, 20);
            lblCalificacion.TabIndex = 16;
            lblCalificacion.Text = "Calificacion: ";
            lblCalificacion.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(87, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(342, 28);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Registro de Calificaciones de Alumnos";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(564, 388);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj3Listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(listMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(txtCalificacion);
            Controls.Add(lblCalificacion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj3Listas";
            Text = "Formulario Ejercicio 2";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioEliminarAlta;
        private RadioButton rdioPromedio;
        private RadioButton rdioAgregar;
        private TextBox txtCantidad;
        private TextBox txtCalificacion;
        private Label lblCantidad;
        private Label lblCalificacion;
        private Label lblTitulo;
        private Button btnSalir;
        private RadioButton rdioEliminarBaja;
    }
}