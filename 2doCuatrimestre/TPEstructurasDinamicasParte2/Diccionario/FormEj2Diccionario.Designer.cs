namespace TPEstructurasDinamicasParte2.Diccionario
{
    partial class FormEj2Diccionario
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
            txtSKU = new TextBox();
            btnBuscar = new Button();
            lblSKU = new Label();
            btnAgregar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            listMostrar = new ListBox();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioBuscar = new RadioButton();
            rdioAgregar = new RadioButton();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI", 10F);
            txtSKU.Location = new Point(459, 176);
            txtSKU.Margin = new Padding(3, 2, 3, 2);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(227, 25);
            txtSKU.TabIndex = 57;
            txtSKU.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(459, 239);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 36);
            btnBuscar.TabIndex = 56;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI", 11F);
            lblSKU.Location = new Point(525, 142);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(96, 20);
            lblSKU.TabIndex = 54;
            lblSKU.Text = "Codigo SKU: ";
            lblSKU.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(594, 239);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 36);
            btnAgregar.TabIndex = 53;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(536, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre: ";
            lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(459, 104);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 25);
            txtNombre.TabIndex = 51;
            txtNombre.Visible = false;
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(70, 239);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(309, 169);
            listMostrar.TabIndex = 50;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(70, 67);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 49;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioBuscar);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(70, 88);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(309, 113);
            gboxAccion.TabIndex = 48;
            gboxAccion.TabStop = false;
            // 
            // rdioBuscar
            // 
            rdioBuscar.AutoSize = true;
            rdioBuscar.Font = new Font("Segoe UI", 12F);
            rdioBuscar.Location = new Point(18, 66);
            rdioBuscar.Margin = new Padding(3, 2, 3, 2);
            rdioBuscar.Name = "rdioBuscar";
            rdioBuscar.Size = new Size(141, 25);
            rdioBuscar.TabIndex = 1;
            rdioBuscar.TabStop = true;
            rdioBuscar.Text = "Buscar Producto";
            rdioBuscar.UseVisualStyleBackColor = true;
            rdioBuscar.CheckedChanged += rdioBuscar_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 12F);
            rdioAgregar.Location = new Point(18, 27);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(151, 25);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Producto";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(70, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 28);
            lblTitulo.TabIndex = 47;
            lblTitulo.Text = "Catalogo de Productos por Codigo";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(638, 342);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 46;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj2Diccionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSKU);
            Controls.Add(btnBuscar);
            Controls.Add(lblSKU);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj2Diccionario";
            Text = "Formulario Ejercicio 2 Diccionario";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSKU;
        private Button btnBuscar;
        private Label lblSKU;
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
    }
}