namespace TPEstructurasDinamicasParte2.Pilas
{
    partial class FormEj2Pilas
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
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioVerificar = new RadioButton();
            rdioAgregar = new RadioButton();
            lblTitulo = new Label();
            btnSalir = new Button();
            txtElemento = new TextBox();
            lblElemento = new Label();
            btnAgregar = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Items.AddRange(new object[] { "Elementos de la expresion: " });
            listMostrar.Location = new Point(81, 249);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(443, 169);
            listMostrar.TabIndex = 30;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(81, 77);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 29;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioVerificar);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(81, 98);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(309, 127);
            gboxAccion.TabIndex = 28;
            gboxAccion.TabStop = false;
            // 
            // rdioVerificar
            // 
            rdioVerificar.AutoSize = true;
            rdioVerificar.Font = new Font("Segoe UI", 12F);
            rdioVerificar.Location = new Point(16, 77);
            rdioVerificar.Margin = new Padding(3, 2, 3, 2);
            rdioVerificar.Name = "rdioVerificar";
            rdioVerificar.Size = new Size(287, 25);
            rdioVerificar.TabIndex = 1;
            rdioVerificar.TabStop = true;
            rdioVerificar.Text = "Verificar Parentesis, llaves y corchetes";
            rdioVerificar.UseVisualStyleBackColor = true;
            rdioVerificar.CheckedChanged += rdioVerificar_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 12F);
            rdioAgregar.Location = new Point(18, 29);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(252, 25);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Elemento a la Expresion";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(81, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(334, 28);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "Verificador de Partentesis Balancedos";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(602, 351);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtElemento
            // 
            txtElemento.Font = new Font("Segoe UI", 10F);
            txtElemento.Location = new Point(467, 129);
            txtElemento.Margin = new Padding(3, 2, 3, 2);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(227, 25);
            txtElemento.TabIndex = 31;
            txtElemento.Visible = false;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Font = new Font("Segoe UI", 11F);
            lblElemento.Location = new Point(537, 98);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(79, 20);
            lblElemento.TabIndex = 32;
            lblElemento.Text = "Elemento: ";
            lblElemento.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(534, 175);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 36);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormEj2Pilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lblElemento);
            Controls.Add(txtElemento);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj2Pilas";
            Text = "Formulario Ejercicio 2 Pilas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioVerificar;
        private RadioButton rdioAgregar;
        private Label lblTitulo;
        private Button btnSalir;
        private TextBox txtElemento;
        private Label lblElemento;
        private Button btnAgregar;
    }
}