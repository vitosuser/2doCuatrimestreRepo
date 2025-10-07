namespace TPEstructurasDinamicasParte2.Listas_Enlazadas.Ejercicio1
{
    partial class FormEj1ListasEnlazadas
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
            rdioEliminarAlta = new RadioButton();
            rdioPromedio = new RadioButton();
            rdioAgregar = new RadioButton();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblTitulo = new Label();
            btnSalir = new Button();
            btnSentar = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(116, 243);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(303, 169);
            listMostrar.TabIndex = 34;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(428, 164);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(638, 165);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 36);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(116, 65);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 31;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioEliminarAlta);
            gboxAccion.Controls.Add(rdioPromedio);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(116, 86);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(214, 133);
            gboxAccion.TabIndex = 30;
            gboxAccion.TabStop = false;
            // 
            // rdioEliminarAlta
            // 
            rdioEliminarAlta.AutoSize = true;
            rdioEliminarAlta.Font = new Font("Segoe UI", 10F);
            rdioEliminarAlta.Location = new Point(16, 91);
            rdioEliminarAlta.Margin = new Padding(3, 2, 3, 2);
            rdioEliminarAlta.Name = "rdioEliminarAlta";
            rdioEliminarAlta.Size = new Size(172, 23);
            rdioEliminarAlta.TabIndex = 2;
            rdioEliminarAlta.TabStop = true;
            rdioEliminarAlta.Text = "Eliminar Cliente de Lista";
            rdioEliminarAlta.UseVisualStyleBackColor = true;
            // 
            // rdioPromedio
            // 
            rdioPromedio.AutoSize = true;
            rdioPromedio.Font = new Font("Segoe UI", 10F);
            rdioPromedio.Location = new Point(16, 60);
            rdioPromedio.Margin = new Padding(3, 2, 3, 2);
            rdioPromedio.Name = "rdioPromedio";
            rdioPromedio.Size = new Size(170, 23);
            rdioPromedio.TabIndex = 1;
            rdioPromedio.TabStop = true;
            rdioPromedio.Text = "Sentar al Primer Cliente";
            rdioPromedio.UseVisualStyleBackColor = true;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 10F);
            rdioAgregar.Location = new Point(16, 28);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(126, 23);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar Cliente ";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11F);
            txtCliente.Location = new Point(463, 102);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(227, 27);
            txtCliente.TabIndex = 29;
            txtCliente.Visible = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F);
            lblCliente.Location = new Point(345, 102);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(121, 20);
            lblCliente.TabIndex = 28;
            lblCliente.Text = "Nombre Cliente: ";
            lblCliente.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(116, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(372, 28);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "Gestion de Lista de Espera en Restaurante";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(558, 317);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnSentar
            // 
            btnSentar.Font = new Font("Segoe UI", 10F);
            btnSentar.Location = new Point(533, 165);
            btnSentar.Margin = new Padding(3, 2, 3, 2);
            btnSentar.Name = "btnSentar";
            btnSentar.Size = new Size(82, 36);
            btnSentar.TabIndex = 35;
            btnSentar.Text = "Sentar";
            btnSentar.UseVisualStyleBackColor = true;
            btnSentar.Visible = false;
            // 
            // FormEj1ListasEnlazadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSentar);
            Controls.Add(listMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(this.txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj1ListasEnlazadas";
            Text = "Formulario Ejercicio 1 Listas Enlazadas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioEliminarBaja;
        private RadioButton rdioEliminarAlta;
        private RadioButton rdioPromedio;
        private RadioButton rdioAgregar;
        private TextBox txtCliente;
        private Label lblCliente;
        private Label lblTitulo;
        private Button btnSalir;
        private Button btnSentar;
    }
}