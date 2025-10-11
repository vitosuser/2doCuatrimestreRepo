namespace TPEstructurasDinamicasParte2.Diccionario
{
    partial class FormEj3Diccionario
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
            txtEspanol = new TextBox();
            btnBuscar = new Button();
            lblEspanol = new Label();
            btnAgregar = new Button();
            lblIngles = new Label();
            txtIngles = new TextBox();
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
            // txtEspanol
            // 
            txtEspanol.Font = new Font("Segoe UI", 10F);
            txtEspanol.Location = new Point(459, 186);
            txtEspanol.Margin = new Padding(3, 2, 3, 2);
            txtEspanol.Name = "txtEspanol";
            txtEspanol.Size = new Size(227, 25);
            txtEspanol.TabIndex = 68;
            txtEspanol.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(459, 249);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 36);
            btnBuscar.TabIndex = 67;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblEspanol
            // 
            lblEspanol.AutoSize = true;
            lblEspanol.Font = new Font("Segoe UI", 11F);
            lblEspanol.Location = new Point(484, 153);
            lblEspanol.Name = "lblEspanol";
            lblEspanol.Size = new Size(163, 20);
            lblEspanol.TabIndex = 66;
            lblEspanol.Text = "Significado en Español:";
            lblEspanol.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(594, 249);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 36);
            btnAgregar.TabIndex = 65;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIngles
            // 
            lblIngles.AutoSize = true;
            lblIngles.Font = new Font("Segoe UI", 11F);
            lblIngles.Location = new Point(502, 76);
            lblIngles.Name = "lblIngles";
            lblIngles.Size = new Size(133, 20);
            lblIngles.TabIndex = 64;
            lblIngles.Text = "Termino en Ingles: ";
            lblIngles.Visible = false;
            // 
            // txtIngles
            // 
            txtIngles.Font = new Font("Segoe UI", 10F);
            txtIngles.Location = new Point(459, 114);
            txtIngles.Margin = new Padding(3, 2, 3, 2);
            txtIngles.Name = "txtIngles";
            txtIngles.Size = new Size(227, 25);
            txtIngles.TabIndex = 63;
            txtIngles.Visible = false;
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(70, 249);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(309, 169);
            listMostrar.TabIndex = 62;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(70, 77);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 61;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioBuscar);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(70, 98);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(309, 113);
            gboxAccion.TabIndex = 60;
            gboxAccion.TabStop = false;
            // 
            // rdioBuscar
            // 
            rdioBuscar.AutoSize = true;
            rdioBuscar.Font = new Font("Segoe UI", 12F);
            rdioBuscar.Location = new Point(18, 65);
            rdioBuscar.Margin = new Padding(3, 2, 3, 2);
            rdioBuscar.Name = "rdioBuscar";
            rdioBuscar.Size = new Size(153, 25);
            rdioBuscar.TabIndex = 1;
            rdioBuscar.TabStop = true;
            rdioBuscar.Text = "Buscar Traduccion";
            rdioBuscar.UseVisualStyleBackColor = true;
            rdioBuscar.CheckedChanged += rdioBuscar_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 12F);
            rdioAgregar.Location = new Point(18, 26);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(163, 25);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Traduccion";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(70, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 28);
            lblTitulo.TabIndex = 59;
            lblTitulo.Text = "Traductor de Idiomas";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(638, 352);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 58;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj3Diccionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEspanol);
            Controls.Add(btnBuscar);
            Controls.Add(lblEspanol);
            Controls.Add(btnAgregar);
            Controls.Add(lblIngles);
            Controls.Add(txtIngles);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj3Diccionario";
            Text = "FormEj3Diccionario";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEspanol;
        private Button btnBuscar;
        private Label lblEspanol;
        private Button btnAgregar;
        private Label lblIngles;
        private TextBox txtIngles;
        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioBuscar;
        private RadioButton rdioAgregar;
        private Label lblTitulo;
        private Button btnSalir;
    }
}