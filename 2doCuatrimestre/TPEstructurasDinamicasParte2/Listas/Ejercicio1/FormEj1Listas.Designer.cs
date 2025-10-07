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
            rdioEliminar = new RadioButton();
            rdioBuscar = new RadioButton();
            rdioAgregar = new RadioButton();
            lblSeleccione = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            listMostrar = new ListBox();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(507, 390);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(30, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestion de Inventario";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(270, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre Producto: ";
            lblNombre.Visible = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(270, 154);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(71, 19);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad: ";
            lblCantidad.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(416, 114);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 25);
            txtNombre.TabIndex = 4;
            txtNombre.Visible = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(367, 152);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(110, 25);
            txtCantidad.TabIndex = 5;
            txtCantidad.Visible = false;
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioEliminar);
            gboxAccion.Controls.Add(rdioBuscar);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(30, 97);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(214, 127);
            gboxAccion.TabIndex = 7;
            gboxAccion.TabStop = false;
            // 
            // rdioEliminar
            // 
            rdioEliminar.AutoSize = true;
            rdioEliminar.Font = new Font("Segoe UI", 10F);
            rdioEliminar.Location = new Point(16, 93);
            rdioEliminar.Margin = new Padding(3, 2, 3, 2);
            rdioEliminar.Name = "rdioEliminar";
            rdioEliminar.Size = new Size(135, 23);
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
            rdioBuscar.Location = new Point(16, 62);
            rdioBuscar.Margin = new Padding(3, 2, 3, 2);
            rdioBuscar.Name = "rdioBuscar";
            rdioBuscar.Size = new Size(127, 23);
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
            rdioAgregar.Location = new Point(16, 30);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(136, 23);
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
            lblSeleccione.Location = new Point(30, 76);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 8;
            lblSeleccione.Text = "Seleccione una opcion";
            lblSeleccione.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(575, 188);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 36);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(470, 188);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(367, 188);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 36);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(30, 248);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(303, 169);
            listMostrar.TabIndex = 13;
            // 
            // FormEj1Listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(668, 438);
            Controls.Add(listMostrar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(lblCantidad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEj1Listas";
            Text = "Formulario Ejercicio 1";
            Load += FormEj1Listas_Load;
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
        private RadioButton rdioEliminar;
        private RadioButton rdioBuscar;
        private RadioButton rdioAgregar;
        private Label lblSeleccione;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnBuscar;
        private ListBox listMostrar;
    }
}