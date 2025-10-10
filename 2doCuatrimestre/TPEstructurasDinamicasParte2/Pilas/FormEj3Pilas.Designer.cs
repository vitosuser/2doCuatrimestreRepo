namespace TPEstructurasDinamicasParte2.Pilas
{
    partial class FormEj3Pilas
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
            btnVisitar = new Button();
            lblNombre = new Label();
            txtPagina = new TextBox();
            listMostrar = new ListBox();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioAtras = new RadioButton();
            rdioNueva = new RadioButton();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // btnVisitar
            // 
            btnVisitar.Font = new Font("Segoe UI", 10F);
            btnVisitar.Location = new Point(547, 175);
            btnVisitar.Margin = new Padding(3, 2, 3, 2);
            btnVisitar.Name = "btnVisitar";
            btnVisitar.Size = new Size(82, 36);
            btnVisitar.TabIndex = 41;
            btnVisitar.Text = "Visitar";
            btnVisitar.UseVisualStyleBackColor = true;
            btnVisitar.Visible = false;
            btnVisitar.Click += btnVisitar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(529, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(119, 20);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre Pagina: ";
            lblNombre.Visible = false;
            // 
            // txtPagina
            // 
            txtPagina.Font = new Font("Segoe UI", 10F);
            txtPagina.Location = new Point(480, 129);
            txtPagina.Margin = new Padding(3, 2, 3, 2);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(227, 25);
            txtPagina.TabIndex = 39;
            txtPagina.Visible = false;
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(94, 249);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(443, 169);
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
            gboxAccion.Controls.Add(rdioAtras);
            gboxAccion.Controls.Add(rdioNueva);
            gboxAccion.Location = new Point(94, 98);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(309, 127);
            gboxAccion.TabIndex = 36;
            gboxAccion.TabStop = false;
            // 
            // rdioAtras
            // 
            rdioAtras.AutoSize = true;
            rdioAtras.Font = new Font("Segoe UI", 12F);
            rdioAtras.Location = new Point(16, 76);
            rdioAtras.Margin = new Padding(3, 2, 3, 2);
            rdioAtras.Name = "rdioAtras";
            rdioAtras.Size = new Size(64, 25);
            rdioAtras.TabIndex = 1;
            rdioAtras.TabStop = true;
            rdioAtras.Text = "Atras";
            rdioAtras.UseVisualStyleBackColor = true;
            rdioAtras.CheckedChanged += rdioAtras_CheckedChanged;
            // 
            // rdioNueva
            // 
            rdioNueva.AutoSize = true;
            rdioNueva.Font = new Font("Segoe UI", 12F);
            rdioNueva.Location = new Point(18, 28);
            rdioNueva.Margin = new Padding(3, 2, 3, 2);
            rdioNueva.Name = "rdioNueva";
            rdioNueva.Size = new Size(171, 25);
            rdioNueva.TabIndex = 0;
            rdioNueva.TabStop = true;
            rdioNueva.Text = "Visitar Nueva Pagina";
            rdioNueva.UseVisualStyleBackColor = true;
            rdioNueva.CheckedChanged += rdioNueva_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(94, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 28);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Historial de Navegacion Web";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(615, 351);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 34;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj3Pilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisitar);
            Controls.Add(lblNombre);
            Controls.Add(txtPagina);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj3Pilas";
            Text = "Formulario Ejercicio 3 Pilas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVisitar;
        private Label lblNombre;
        private TextBox txtPagina;
        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioAtras;
        private RadioButton rdioNueva;
        private Label lblTitulo;
        private Button btnSalir;
    }
}