namespace TPEstructurasDinamicasParte2.Listas
{
    partial class FormEj2Listas
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
            btnCompletar = new Button();
            btnAgregar = new Button();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioCompletada = new RadioButton();
            rdioAgregar = new RadioButton();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(87, 246);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(303, 169);
            listMostrar.TabIndex = 25;
            // 
            // btnCompletar
            // 
            btnCompletar.Font = new Font("Segoe UI", 10F);
            btnCompletar.Location = new Point(446, 168);
            btnCompletar.Margin = new Padding(3, 2, 3, 2);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(82, 36);
            btnCompletar.TabIndex = 23;
            btnCompletar.Text = "Completar";
            btnCompletar.UseVisualStyleBackColor = true;
            btnCompletar.Visible = false;
            btnCompletar.Click += btnCompletar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(618, 168);
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
            gboxAccion.Controls.Add(rdioCompletada);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(87, 95);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(214, 98);
            gboxAccion.TabIndex = 20;
            gboxAccion.TabStop = false;
            // 
            // rdioCompletada
            // 
            rdioCompletada.AutoSize = true;
            rdioCompletada.Font = new Font("Segoe UI", 10F);
            rdioCompletada.Location = new Point(16, 61);
            rdioCompletada.Margin = new Padding(3, 2, 3, 2);
            rdioCompletada.Name = "rdioCompletada";
            rdioCompletada.Size = new Size(136, 23);
            rdioCompletada.TabIndex = 1;
            rdioCompletada.TabStop = true;
            rdioCompletada.Text = "Tarea Completada";
            rdioCompletada.UseVisualStyleBackColor = true;
            rdioCompletada.CheckedChanged += rdioCompletada_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 10F);
            rdioAgregar.Location = new Point(16, 29);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(154, 23);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Nueva Tarea";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(473, 112);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 25);
            txtNombre.TabIndex = 18;
            txtNombre.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(327, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(101, 19);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre Tarea: ";
            lblNombre.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(87, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(235, 28);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Lista de Tareas Pendientes";
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
            // FormEj2Listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(listMostrar);
            Controls.Add(btnCompletar);
            Controls.Add(btnAgregar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj2Listas";
            Text = "Formulario Ejercicio 2";
            Load += FormEj2Listas_Load;
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Button btnCompletar;
        private Button btnAgregar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioCompletada;
        private RadioButton rdioAgregar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTitulo;
        private Button btnSalir;
    }
}