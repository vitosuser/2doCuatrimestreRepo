namespace TPEstructurasDinamicasParte2.Listas
{
    partial class FormEj1Listas
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
            btnSalir = new Button();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblCantidad = new Label();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            gboxAccion = new GroupBox();
            rdioMostrar = new RadioButton();
            rdioEliminar = new RadioButton();
            rdioBuscar = new RadioButton();
            rdioAgregar = new RadioButton();
            lblSeleccione = new Label();
            txtMostrar = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(581, 503);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(34, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(252, 35);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestion de Inventario";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(309, 152);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(157, 23);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre Producto: ";
            lblNombre.Visible = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(309, 205);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 23);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad: ";
            lblCantidad.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(475, 152);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 30);
            txtNombre.TabIndex = 4;
            txtNombre.Visible = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(419, 202);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 30);
            txtCantidad.TabIndex = 5;
            txtCantidad.Visible = false;
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioMostrar);
            gboxAccion.Controls.Add(rdioEliminar);
            gboxAccion.Controls.Add(rdioBuscar);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(34, 127);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Size = new Size(244, 209);
            gboxAccion.TabIndex = 7;
            gboxAccion.TabStop = false;
            // 
            // rdioMostrar
            // 
            rdioMostrar.AutoSize = true;
            rdioMostrar.Font = new Font("Segoe UI", 10F);
            rdioMostrar.Location = new Point(18, 166);
            rdioMostrar.Name = "rdioMostrar";
            rdioMostrar.Size = new Size(134, 27);
            rdioMostrar.TabIndex = 3;
            rdioMostrar.TabStop = true;
            rdioMostrar.Text = "Mostrar Lista ";
            rdioMostrar.UseVisualStyleBackColor = true;
            rdioMostrar.CheckedChanged += rdioMostrar_CheckedChanged;
            // 
            // rdioEliminar
            // 
            rdioEliminar.AutoSize = true;
            rdioEliminar.Font = new Font("Segoe UI", 10F);
            rdioEliminar.Location = new Point(18, 124);
            rdioEliminar.Name = "rdioEliminar";
            rdioEliminar.Size = new Size(167, 27);
            rdioEliminar.TabIndex = 2;
            rdioEliminar.TabStop = true;
            rdioEliminar.Text = "Eliminar Producto";
            rdioEliminar.UseVisualStyleBackColor = true;
            rdioEliminar.CheckedChanged += rdioEliminar_CheckedChanged;
            // 
            // rdioBuscar
            // 
            rdioBuscar.AutoSize = true;
            rdioBuscar.Font = new Font("Segoe UI", 10F);
            rdioBuscar.Location = new Point(18, 82);
            rdioBuscar.Name = "rdioBuscar";
            rdioBuscar.Size = new Size(156, 27);
            rdioBuscar.TabIndex = 1;
            rdioBuscar.TabStop = true;
            rdioBuscar.Text = "Buscar Producto";
            rdioBuscar.UseVisualStyleBackColor = true;
            rdioBuscar.CheckedChanged += rdioBuscar_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 10F);
            rdioAgregar.Location = new Point(18, 40);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(167, 27);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Producto";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(38, 101);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(181, 23);
            lblSeleccione.TabIndex = 8;
            lblSeleccione.Text = "Seleccione una opcion";
            lblSeleccione.Click += label1_Click;
            // 
            // txtMostrar
            // 
            txtMostrar.Enabled = false;
            txtMostrar.Location = new Point(41, 349);
            txtMostrar.Multiline = true;
            txtMostrar.Name = "txtMostrar";
            txtMostrar.Size = new Size(425, 235);
            txtMostrar.TabIndex = 9;
            txtMostrar.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(657, 251);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(657, 203);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(557, 203);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            // 
            // FormEj1Listas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(763, 604);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(lblCantidad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj1Listas";
            Text = "Formulario Ejercicio 1";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblCantidad;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private ComboBox comboBox1;
        private GroupBox gboxAccion;
        private RadioButton rdioMostrar;
        private RadioButton rdioEliminar;
        private RadioButton rdioBuscar;
        private RadioButton rdioAgregar;
        private Label lblSeleccione;
        private TextBox txtMostrar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}